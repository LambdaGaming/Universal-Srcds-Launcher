using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Universal_Srcds_Launcher
{
	public partial class MainForm : Form
	{
		private Dictionary<string, string> ArgumentList = new Dictionary<string, string>();
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
		}

		private void UpdateLists()
		{
			var Settings = Properties.Settings.Default;
			if ( Directory.Exists( Settings.GamePath + @"\gamemodes" ) )
			{
				string[] listgamemodes = Directory.GetDirectories( Settings.GamePath + @"\gamemodes" );
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
			else if ( Directory.Exists( Settings.GamePath + @"\addons" ) )
			{
				// Insert placeholder for s&box
				gameselect.Text = "facepunch.sandbox";
				ArgumentList.Add( "Gamemode", $"+gamemode {gameselect.Text}" );
				IsGmodOrSbox = true;
			}
			else
			{
				gameselect.Text = Path.GetDirectoryName( Settings.GamePath );
				ArgumentList.Add( "Gamemode", $"-game {gameselect.Text}" );
				IsGmodOrSbox = false;
			}

			string[] listmaps = Directory.GetFiles( Settings.GamePath + @"\maps" );
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

		private void LanCheck( object sender, EventArgs e )
		{
			if ( lancheck.Checked )
			{
				ArgumentList.Add( "LanCheck", "+sv_lan 1" );
				Properties.Settings.Default.Lan = lancheck.Checked;
				return;
			}
			ArgumentList.Remove( "LanCheck" );
			Properties.Settings.Default.Lan = lancheck.Checked;
		}

		private void LegacyCheck( object sender, EventArgs e )
		{
			if ( legacyCheck.Checked )
			{
				ArgumentList.Remove( "LegacyCheck" );
				mapselect.Text = "";
				gameselect.Text = "";
			}
			else
			{
				ArgumentList.Add( "LegacyCheck", "-console" );
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

		private void MaxPlayersChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.MaxPlayers = Convert.ToInt32( maxplayers.Value );
			ArgumentList.Add( "MaxPlayers", $"+maxplayers {maxplayers.Value}" );
		}

		private void MapChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.Map = mapselect.Text;
			ArgumentList.Add( "Map", $"+map {mapselect.Text}" );
		}

		private void GamemodeChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.Gamemode = gameselect.Text;
			ArgumentList.Add( "Gamemode", $"{( IsGmodOrSbox ? "+gamemode" : "-game" )} {gameselect.Text}" );
		}

		private void ChangeExePathClick( object sender, EventArgs e )
		{
			OpenFileDialog browse = new OpenFileDialog();
			browse.Filter = "Server Executable (*.exe)|*.exe";
			browse.RestoreDirectory = true;
			if ( browse.ShowDialog() == DialogResult.OK )
			{
				Properties.Settings.Default.ExeName = browse.FileName;
				Properties.Settings.Default.ExePath = Path.GetDirectoryName( browse.FileName );
				exePathLabel.Text = "Exe path: " + Properties.Settings.Default.ExeName;
			}
		}

		private void ChangeGamePathClick( object sender, EventArgs e )
		{
			FolderBrowserDialog browse = new FolderBrowserDialog();
			if ( browse.ShowDialog() == DialogResult.OK )
			{
				Properties.Settings.Default.GamePath = browse.SelectedPath;
				gamePathLabel.Text = "Game path: " + browse.SelectedPath;
				UpdateLists();
			}
		}

		private void PasswordChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.Password = passwordBox.Text;
			if ( string.IsNullOrWhiteSpace( passwordBox.Text ) )
			{
				ArgumentList.Remove( "Password" );
				return;
			}
			ArgumentList.Add( "Password", $"+sv_password {passwordBox.Text}" );
		}

		private void CollectionIDBoxChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.CollectionID = CollectionIDBox.Text;
			if ( string.IsNullOrWhiteSpace( CollectionIDBox.Text ) )
			{
				ArgumentList.Remove( "CollectionID" );
				return;
			}
			ArgumentList.Add( "CollectionID", $"+host_workshop_collection {CollectionIDBox.Text}" );
		}

		private void LaunchParamsChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.LaunchParams = launchParameters.Text;
			if ( string.IsNullOrWhiteSpace( launchParameters.Text ) )
			{
				ArgumentList.Remove( "LaunchParams" );
				return;
			}
			ArgumentList.Add( "LaunchParams", launchParameters.Text );
		}

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
				string Token = File.ReadAllText( Properties.Settings.Default.TokenPath );
				ArgumentList.Add( "SteamToken", $"+sv_setsteamaccount {Token}" );
			}
			else
			{
				ArgumentList.Remove( "SteamToken" );
			}
			Properties.Settings.Default.TokenEnabled = TokenEnable.Checked;
		}

		private void StartButtonClick( object sender, EventArgs e )
		{
			string arguments = "+r_hunkalloclightmaps 0";
			foreach ( KeyValuePair<string, string> argument in ArgumentList )
			{
				arguments += $" {argument.Value} ";
			}

			var proc = new ProcessStartInfo
			{
				UseShellExecute = true,
				WorkingDirectory = Properties.Settings.Default.ExePath,
				FileName = Properties.Settings.Default.ExeName,
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
