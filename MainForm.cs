using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Universal_Srcds_Launcher
{
	public partial class MainForm : Form
	{
		private bool IsGmodOrSbox = false;

		public MainForm()
		{
			InitializeComponent();
			BringToFront();
			Focus();

			var Settings = Properties.Settings.Default;
			lancheck.Checked = Settings.Lan;
			legacyCheck.Checked = Settings.Console;
			maxplayers.Value = Settings.MaxPlayers;
			gameselect.Text = Settings.Gamemode;
			gameselect.SelectedItem = Settings.Gamemode;
			mapselect.Text = Settings.Map;
			mapselect.SelectedItem = Settings.Map;
			passwordBox.Text = Settings.Password;
			TokenEnable.Checked = Settings.TokenEnabled;
			CollectionIDBox.Text = Settings.CollectionID;
			launchParameters.Text = Settings.LaunchParams;
			exePathLabel.Text += Settings.ExeName;
			gamePathLabel.Text += Settings.GamePath;

			mapselect.Enabled = !legacyCheck.Checked;
			lancheck.Enabled = !legacyCheck.Checked;
			maxplayers.Enabled = !legacyCheck.Checked;
			gameselect.Enabled = !legacyCheck.Checked;
			passwordBox.Enabled = !legacyCheck.Checked;
			CollectionIDBox.Enabled = !legacyCheck.Checked;
			launchParameters.Enabled = !legacyCheck.Checked;

			UpdateLists();
			Text = "Universal SRCDS Launcher v2.3.0";
		}

		// Update gamemode and map lists when the game path changes
		private void UpdateLists()
		{
			var Settings = Properties.Settings.Default;
			gameselect.Items.Clear();
			mapselect.Items.Clear();
			if ( Directory.Exists( Settings.GamePath + "/gamemodes" ) )
			{
				string[] listgamemodes = Directory.GetDirectories( Settings.GamePath + "/gamemodes" );
				foreach ( string gamemode in listgamemodes )
				{
					string foldername = Path.GetFileName( gamemode );
					if ( foldername != "base" )
					{
						gameselect.Items.Add( foldername );
					}
				}
				IsGmodOrSbox = true;
			}
			else if ( Path.GetFileName( Settings.ExePath ) == "sbox-server.exe" )
			{
				// Insert placeholder for s&box
				if ( string.IsNullOrWhiteSpace( gameselect.Text ) )
				{
					gameselect.Text = "facepunch.sandbox";
				}
				IsGmodOrSbox = true;
			}
			else
			{
				if ( string.IsNullOrWhiteSpace( gameselect.Text ) )
				{
					gameselect.Text = Path.GetFileName( Settings.GamePath );
				}
				IsGmodOrSbox = false;
			}

			if ( Directory.Exists( Settings.GamePath + "/maps" ) )
			{
				string[] listmaps = Directory.GetFiles( Settings.GamePath + "/maps" );
				foreach ( string map in listmaps )
				{
					string extension = Path.GetExtension( map );
					string mapname = Path.GetFileNameWithoutExtension( map );
					if ( extension == ".bsp" )
					{
						mapselect.Items.Add( mapname );
					}
				}
			}
		}

		// Get launch command based on what terminals are installed
		private string GetLinuxCmd()
		{
			string cmd = "";
			var proc = new ProcessStartInfo
			{
				UseShellExecute = false,
				RedirectStandardOutput = true,
				FileName = "/bin/bash",
				Arguments = $"-c '{ Properties.Resources.ResourceManager.GetString( "GetLinuxCmd" ) }'"
			};

			try
			{
				var p = Process.Start( proc );
				cmd = p.StandardOutput.ReadToEnd().Trim( '\n' ); // Trim newline from output so the command isn't messed up
				p.WaitForExit();
			}
			catch ( Exception ex )
			{
				MessageBox.Show( "Failed to get terminal command. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
			return cmd;
		}

		// Called when the lan option is changed
		private void LanCheck( object sender, EventArgs e )
		{
			Properties.Settings.Default.Lan = lancheck.Checked;
		}

		// Called when the legacy launcher option is changed
		private void LegacyCheck( object sender, EventArgs e )
		{
			if ( legacyCheck.Checked )
			{
				mapselect.Text = "";
				gameselect.Text = "";
			}

			mapselect.Enabled = !legacyCheck.Checked;
			lancheck.Enabled = !legacyCheck.Checked;
			maxplayers.Enabled = !legacyCheck.Checked;
			gameselect.Enabled = !legacyCheck.Checked;
			passwordBox.Enabled = !legacyCheck.Checked;
			CollectionIDBox.Enabled = !legacyCheck.Checked;
			launchParameters.Enabled = !legacyCheck.Checked;
			Properties.Settings.Default.Console = legacyCheck.Checked;
		}

		// Called when the max players option is changed
		private void MaxPlayersChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.MaxPlayers = Convert.ToInt32( maxplayers.Value );
		}

		// Called when the map option is changed
		private void MapChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.Map = mapselect.Text;
		}

		// Called when the gamemode option is changed
		private void GamemodeChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.Gamemode = gameselect.Text;
		}

		// Called when the change exe path button is clicked
		private void ChangeExePathClick( object sender, EventArgs e )
		{
			OpenFileDialog browse = new OpenFileDialog();
			browse.Filter = "Server Executable (*.exe)|*.exe|Linux Server Script (srcds_run*)|srcds_run*";
			browse.RestoreDirectory = true;
			if ( browse.ShowDialog() == DialogResult.OK )
			{
				Properties.Settings.Default.ExeName = browse.FileName;
				Properties.Settings.Default.ExePath = Path.GetDirectoryName( browse.FileName );
				exePathLabel.Text = "Exe path: " + Properties.Settings.Default.ExeName;
			}
		}

		// Called when the change game path button is clicked
		private void ChangeGamePathClick( object sender, EventArgs e )
		{
			FolderBrowserDialog browse = new FolderBrowserDialog();
			if ( browse.ShowDialog() == DialogResult.OK )
			{
				Properties.Settings.Default.GamePath = browse.SelectedPath;
				gamePathLabel.Text = "Game path: " + browse.SelectedPath;
				gameselect.Text = "";
				mapselect.Text = "";
				UpdateLists();
			}
		}

		// Called when the password option is changed
		private void PasswordChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.Password = passwordBox.Text;
		}

		// Called when the workshop collection option is changed
		private void CollectionIDBoxChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.CollectionID = CollectionIDBox.Text;
		}

		// Called when the launch parameters option is changed
		private void LaunchParamsChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.LaunchParams = launchParameters.Text;
		}

		// Called when the steam token option is changed
		private void TokenEnableChanged( object sender, EventArgs e )
		{
			if ( TokenEnable.Checked )
			{
				if ( !File.Exists( Properties.Settings.Default.TokenPath ) )
				{
					OpenFileDialog browse = new OpenFileDialog();
					browse.InitialDirectory = Properties.Settings.Default.ExePath;
					browse.Filter = "Text file containing token|*.txt";
					if ( browse.ShowDialog() == DialogResult.OK )
					{
						Properties.Settings.Default.TokenPath = browse.FileName;
						TokenEnable.Checked = !string.IsNullOrEmpty( Properties.Settings.Default.TokenPath );
					}
				}
			}
			Properties.Settings.Default.TokenEnabled = TokenEnable.Checked;
		}

		// Called when the start button is clicked
		private void StartButtonClick( object sender, EventArgs e )
		{
			bool isLinux = RuntimeInformation.IsOSPlatform( OSPlatform.Linux );
			var Settings = Properties.Settings.Default;
			string arguments = "";

			if ( !legacyCheck.Checked )
				arguments += " -console";

			if ( lancheck.Checked )
				arguments += " +sv_lan 1";

			if ( TokenEnable.Checked )
			{
				string Token = File.ReadAllText( Settings.TokenPath );
				arguments += $" +sv_setsteamaccount {Token}";
			}

			if ( IsGmodOrSbox )
				arguments += $" +gamemode {gameselect.Text}";
			else
				arguments += $" -game {gameselect.Text}";

			if ( !string.IsNullOrWhiteSpace( passwordBox.Text ) )
				arguments += $" +sv_password {passwordBox.Text}";

			if ( !string.IsNullOrWhiteSpace( CollectionIDBox.Text ) )
				arguments += $" +host_workshop_collection {CollectionIDBox.Text}";

			arguments += $" +maxplayers {maxplayers.Value} +map {mapselect.Text} {launchParameters.Text}";

			if ( isLinux )
			{
				string cmd = GetLinuxCmd();
				arguments = $"-c \"{cmd} bash -c 'cd {Path.GetDirectoryName( Settings.GamePath )}; ./{Path.GetFileName( Settings.ExeName )} {arguments}; exec bash'\"";
			}

			var proc = new ProcessStartInfo
			{
				UseShellExecute = false,
				RedirectStandardOutput = isLinux,
				WorkingDirectory = Settings.ExePath,
				FileName = isLinux ? "/bin/bash" : Settings.ExeName,
				Arguments = arguments
			};

			try
			{
				Process.Start( proc );
				Close();
			}
			catch ( Exception ex )
			{
				DialogResult launcherror = MessageBox.Show( "Failed to launch. " + ex.Message, "Launch Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				if ( launcherror == DialogResult.OK ) Close();
			}
		}
	}
}
