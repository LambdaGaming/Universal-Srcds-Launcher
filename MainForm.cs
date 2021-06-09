using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GMod_Server_Launcher_Console
{
	public partial class MainForm : Form
	{
		public string ConsoleEnabled = "";
		public string LANEnabled = "";
		public string Password = "";
		public string SteamToken = "";
		public string CollectionID = "";

		public MainForm()
		{
			InitializeComponent();
			BringToFront();
			Focus();

			var Settings = Properties.Settings.Default;
			lancheck.Checked = Settings.Lan;
			consolecheck.Checked = Settings.Console;
			maxplayers.Value = Settings.MaxPlayers;
			gameselect.Text = Settings.Gamemode;
			gameselect.SelectedItem = Settings.Gamemode;
			mapselect.Text = Settings.Map;
			mapselect.SelectedItem = Settings.Map;
			passwordBox.Text = Settings.Password;
			TokenEnable.Checked = Settings.TokenEnabled;
			CollectionIDBox.Text = Settings.CollectionID;

			mapselect.Enabled = consolecheck.Checked;
			lancheck.Enabled = consolecheck.Checked;
			maxplayers.Enabled = consolecheck.Checked;
			gameselect.Enabled = consolecheck.Checked;
			passwordBox.Enabled = consolecheck.Checked;
			CollectionIDBox.Enabled = consolecheck.Checked;

			StringBuilder path = new StringBuilder( label4.Text );
			path.Append( Properties.Settings.Default.FilePath );
			label4.Text = path.ToString();

			string[] listgamemodes = Directory.GetDirectories( Settings.FilePath + @"\garrysmod\gamemodes" );
			foreach ( string gamemode in listgamemodes )
			{
				string foldername = Path.GetFileName( gamemode );
				if ( foldername != "base" )
				{
					gameselect.Items.Add( foldername );
				}
			}

			string[] listmaps = Directory.GetFiles( Settings.FilePath + @"\garrysmod\maps" );
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
				LANEnabled = " +sv_lan 1 ";
				Properties.Settings.Default.Lan = lancheck.Checked;
				return;
			}
			LANEnabled = "";
			Properties.Settings.Default.Lan = lancheck.Checked;
		}

		private void ConsoleCheck( object sender, EventArgs e )
		{
			if ( consolecheck.Checked )
			{
				ConsoleEnabled = " -console ";
			}
			else
			{
				ConsoleEnabled = "";
				mapselect.Text = "";
				gameselect.Text = "";
			}
			mapselect.Enabled = consolecheck.Checked;
			lancheck.Enabled = consolecheck.Checked;
			maxplayers.Enabled = consolecheck.Checked;
			gameselect.Enabled = consolecheck.Checked;
			passwordBox.Enabled = consolecheck.Checked;
			CollectionIDBox.Enabled = consolecheck.Checked;
			Properties.Settings.Default.Console = consolecheck.Checked;
		}

		private void MaxPlayersChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.MaxPlayers = Convert.ToInt32( maxplayers.Value );
		}

		private void MapChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.Map = mapselect.Text;
		}

		private void GamemodeChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.Gamemode = gameselect.Text;
		}

		private void ChangePathClick( object sender, EventArgs e )
		{
			FolderBrowserDialog browse = new FolderBrowserDialog();
			browse.Description = "Select server file path. (The folder containing the srcds.exe file.)";
			if ( browse.ShowDialog() == DialogResult.OK )
			{
				Properties.Settings.Default.FilePath = browse.SelectedPath;
				label4.Text = "Current server file path: " + Properties.Settings.Default.FilePath;
			}
		}

		private void PasswordChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.Password = passwordBox.Text;
			if ( string.IsNullOrWhiteSpace( passwordBox.Text ) )
			{
				Password = "";
				return;
			}
			Password = " +sv_password " + passwordBox.Text;
		}

		private void TokenEnableChanged( object sender, EventArgs e )
		{
			if ( TokenEnable.Checked )
			{
				try
				{
					string Token = File.ReadAllText( Properties.Settings.Default.TokenPath );
					SteamToken = " +sv_setsteamaccount " + Token;
				}
				catch
				{
					DialogResult error = MessageBox.Show( "Failed to find token directory. Make sure you have selected one through the Browse for Token button.", "Path Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error );
					if ( error == DialogResult.OK )
					{
						TokenEnable.Checked = false;
					}
				}
			}
			else
			{
				SteamToken = "";
			}
			Properties.Settings.Default.TokenEnabled = TokenEnable.Checked;
		}

		private void TokenFolderClick( object sender, EventArgs e )
		{
			OpenFileDialog browse = new OpenFileDialog();
			browse.InitialDirectory = Properties.Settings.Default.FilePath;
			browse.Filter = "Text file containing token|*.txt";
			if ( browse.ShowDialog() == DialogResult.OK )
			{
				Properties.Settings.Default.TokenPath = browse.FileName;
				TokenEnable.Enabled = !string.IsNullOrEmpty( Properties.Settings.Default.TokenPath );
			}
		}

		private void StartButtonClick( object sender, EventArgs e )
		{
			var proc = new ProcessStartInfo
			{
				UseShellExecute = true,
				WorkingDirectory = Properties.Settings.Default.FilePath,
				FileName = Properties.Settings.Default.FilePath + @"\srcds.exe",
				Arguments = "+gamemode " + gameselect.Text.ToString() + ConsoleEnabled + LANEnabled + "+map " + mapselect.Text.ToString() + " +maxplayers " + maxplayers.Value + " +r_hunkalloclightmaps 0" + Password + SteamToken + CollectionID,
			};

			try
			{
				Process.Start( proc );
				Close();
			}
			catch ( Exception )
			{
				DialogResult launcherror = MessageBox.Show( "Failed to launch. Invalid file path.", "Launch Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				if ( launcherror == DialogResult.OK ) Close();
			}
		}

		private void CollectionIDBoxChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.CollectionID = CollectionIDBox.Text;
			if ( string.IsNullOrWhiteSpace( CollectionIDBox.Text ) )
			{
				CollectionID = "";
				return;
			}
			CollectionID = " +host_workshop_collection " + CollectionIDBox.Text;
		}
	}
}
