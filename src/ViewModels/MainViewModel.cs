using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Platform;
using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace UniversalSrcdsLauncher.ViewModels;

public partial class MainViewModel : ObservableObject
{
	private enum GameType {
		None,
		GarrysMod,
		Sbox
	}
	private GameType SpecialGameType = GameType.None;

	private readonly SettingsService _service;
	private readonly AppSettings _settings;

	public MainViewModel( SettingsService service )
	{
		_service = service;
		_settings = service.Load();
		_lanServer = _settings.LanServer;
		_selectedMap = _settings.SelectedMap;
		_selectedGame = _settings.SelectedGame;
		_maxPlayers = _settings.MaxPlayers;
		_password = _settings.Password;
		_launchParams = _settings.LaunchParams;
		_workshopId = _settings.WorkshopId;
		_serverPath = _settings.ServerPath;
		_tokenPath = _settings.TokenPath;
		_selectedExe = _settings.SelectedExe;
		if ( !string.IsNullOrEmpty( _tokenPath ) && File.Exists( _tokenPath ) )
			_enableToken = true;
	}

	public ObservableCollection<string> GameListItems { get; set; } = [];
	public ObservableCollection<string> MapListItems { get; set; } = [];
	public ObservableCollection<string> ExeListItems { get; set; } = [];

	[ObservableProperty]
	private bool _lanServer = false;

	[ObservableProperty]
	private bool _enableToken = false;

	[ObservableProperty]
	private string? _selectedMap;

	[ObservableProperty]
    private string? _selectedGame;

    [ObservableProperty]
	private decimal? _maxPlayers = 24;

	[ObservableProperty]
	private string? _password;

	[ObservableProperty]
	private string? _launchParams;

	[ObservableProperty]
	private string? _workshopId;

	[ObservableProperty]
	public string? _serverPath;

	[ObservableProperty]
	public string? _selectedExe;

	[ObservableProperty]
	public string? _tokenPath;

	public async Task GetServerPath( bool reset = false )
	{
		if ( Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime life )
		{
			var dir = await life.MainWindow.StorageProvider.OpenFolderPickerAsync( new FolderPickerOpenOptions() {
				Title = "Select server game folder (Ex: garrysmod, tf, valve, ricochet)",
				AllowMultiple = false
			} );
			if ( dir.Count > 0 )
			{
				ServerPath = dir[0].Path.LocalPath;
				UpdateLists( reset );
			}
			else
			{
				await GetServerPath();
			}
		}
	}

	private async Task GetTokenPath()
	{
		if ( Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime life )
		{
			var file = await life.MainWindow.StorageProvider.OpenFilePickerAsync( new FilePickerOpenOptions {
				Title = "Select text file containing Steam token",
				FileTypeFilter = [FilePickerFileTypes.TextPlain],
				AllowMultiple = false
			} );
			if ( file.Count > 0 )
				TokenPath = file[0].Path.LocalPath;
			else
				EnableToken = false;
		}
	}

	internal void UpdateLists( bool reset = false )
	{
		// Reset the lists if the path has changed
		if ( reset )
		{
			GameListItems.Clear();
			MapListItems.Clear();
			ExeListItems.Clear();
			SelectedGame = "";
			SelectedMap = "";
			SelectedExe = "";
		}

		if ( Directory.Exists( ServerPath + "/gamemodes" ) )
		{
			var gamemodes = Directory.GetDirectories( ServerPath + "/gamemodes" );
			foreach ( string gm in gamemodes )
			{
				var name = Path.GetFileName( gm );
				if ( name == "base" )
					continue;
				GameListItems.Add( name );
			}
			SpecialGameType = GameType.GarrysMod;
		}
		else if ( File.Exists( $"{ServerPath}/../sbox-server.exe" ) )
		{
			// Insert placeholders for s&box
			if ( string.IsNullOrWhiteSpace( SelectedGame ) )
			{
				SelectedGame = "facepunch.sandbox";
				SelectedMap = "facepunch.flatgrass";
			}
			SpecialGameType = GameType.Sbox;
		}
		else
		{
			GameListItems.Add( Path.GetFileName( ServerPath?.TrimEnd( Path.DirectorySeparatorChar ) ) ?? "Error" );
		}

		if ( Directory.Exists( ServerPath + "/maps" ) )
		{
			var maps = Directory.GetFiles( ServerPath + "/maps" );
			foreach ( string map in maps )
			{
				var ext = Path.GetExtension( map );
				var name = Path.GetFileNameWithoutExtension( map );
				if ( ext == ".bsp" || ext == ".vpk" )
					MapListItems.Add( name );
			}
		}

		var files = Directory.GetFiles( ServerPath + "/.." );
		foreach ( string file in files )
		{
			var name = Path.GetFileName( file );
			if ( name.Contains( ".exe" ) || name.Contains( "_run" ) || name.Contains( ".sh" ) )
				ExeListItems.Add( name );
		}
	}

	partial void OnEnableTokenChanged( bool enabled )
	{
		if ( enabled )
            _ = GetTokenPath();
		else
			TokenPath = "";
	}

	private string GetLinuxCmd()
	{
		string cmd = "";
		using var asset = AssetLoader.Open( new Uri( "avares://UniversalSrcdsLauncher/Assets/GetLinuxCmd.sh" ) );
		using var reader = new StreamReader( asset );
		var code = reader.ReadToEnd().Trim();
		var proc = new ProcessStartInfo
		{
			UseShellExecute = false,
			RedirectStandardOutput = true,
			FileName = "/bin/bash",
			Arguments = $"-c \"{code}\""
		};

		try
		{
			var p = Process.Start( proc );
			cmd = p.StandardOutput.ReadToEnd().Trim();
			p.WaitForExit();
		}
		catch ( Exception e )
		{
			Console.WriteLine( "Error reading GetLinuxCmd.sh" );
		}
		return cmd;
	}

	private void StartServer()
	{
		bool isLinux = OperatingSystem.IsLinux();
		string args = "-console";

		// Apply launch parameters
		if ( LanServer )
			args += " +sv_lan 1";

		if ( EnableToken )
		{
			string token = File.ReadAllText( TokenPath );
			args += $" +sv_setsteamaccount {token}";
		}

		if ( SpecialGameType == GameType.GarrysMod )
			args += $" +gamemode {SelectedGame}";
		else if ( SpecialGameType == GameType.Sbox )
			args += $" +game {SelectedGame} {SelectedMap}";
		else
			args += $" -game {SelectedGame}";

		if ( SpecialGameType != GameType.Sbox )
			args += $" +map {SelectedMap}";

		if ( !string.IsNullOrWhiteSpace( Password ) )
			args += $" +sv_password {Password}";

		if ( !string.IsNullOrWhiteSpace( WorkshopId ) )
			args += $" +host_workshop_collection {WorkshopId}";

		args += $" +maxplayers {MaxPlayers} {LaunchParams}";

		// Launch executable
		if ( isLinux )
		{
			string cmd = GetLinuxCmd();
			if ( string.IsNullOrWhiteSpace( cmd ) )
			{
				Console.WriteLine( "Error getting terminal name" );
				return;
			}
			args = $"-c \"{cmd} bash -c 'cd {Path.GetDirectoryName( ServerPath )}/../; ./{SelectedExe} {args}; exec bash'\"";
		}

		var proc = new ProcessStartInfo()
		{
			UseShellExecute = false,
			RedirectStandardOutput = isLinux,
			WorkingDirectory = ServerPath + "/../",
			FileName = isLinux ? "/bin/bash" : SelectedExe,
			Arguments = args
		};

		try
		{
			Process.Start( proc );
		}
		catch ( Exception e )
		{
			Console.WriteLine( "Error launching server: " + e.Message );
		}
	}

	[RelayCommand]
	private void ChangePath()
	{
		_ = GetServerPath( true );
	}

	[RelayCommand]
	private void Start()
	{
		StartServer();
		_settings.LanServer = LanServer;
		_settings.SelectedMap = SelectedMap ?? "";
		_settings.SelectedGame = SelectedGame ?? "";
		_settings.MaxPlayers = ( int ) ( MaxPlayers ?? 24 );
		_settings.Password = Password ?? "";
		_settings.LaunchParams = LaunchParams ?? "";
		_settings.WorkshopId = WorkshopId ?? "";
		_settings.ServerPath = ServerPath ?? "";
		_settings.TokenPath = TokenPath ?? "";
		_settings.SelectedExe = SelectedExe ?? "";
		_service.Save( _settings );
		if ( Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime life )
			life.Shutdown();
	}
}
