using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GMod_Server_Launcher_Console
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.BringToFront();
			this.Focus();

			lancheck.Checked = Properties.Settings.Default.Lan;
			consolecheck.Checked = Properties.Settings.Default.Console;
			maxplayers.Value = Properties.Settings.Default.MaxPlayers;
			gameselect.Text = Properties.Settings.Default.Gamemode;
			gameselect.SelectedItem = Properties.Settings.Default.Gamemode;
			mapselect.Text = Properties.Settings.Default.Map;
			mapselect.SelectedItem = Properties.Settings.Default.Map;
			passwordBox.Text = Properties.Settings.Default.Password;

			mapselect.Enabled = consolecheck.Checked;
			lancheck.Enabled = consolecheck.Checked;
			maxplayers.Enabled = consolecheck.Checked;
			gameselect.Enabled = consolecheck.Checked;
			passwordBox.Enabled = consolecheck.Checked;

			StringBuilder path = new StringBuilder( label4.Text );
			path.Append( Properties.Settings.Default.FilePath );
			label4.Text = path.ToString();

			string[] listgamemodes = Directory.GetDirectories( Properties.Settings.Default.FilePath + @"\garrysmod\gamemodes" );
			foreach ( string gamemode in listgamemodes )
			{
				string foldername = Path.GetFileName( gamemode );
				if ( foldername != "base" )
				{
					gameselect.Items.Add( foldername );
				}
			}

			string[] listmaps = Directory.GetFiles( Properties.Settings.Default.FilePath + @"\garrysmod\maps" );
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

		public string ConsoleEnabled = "";
		public string LANEnabled = "";
		public string Password = "";

		private void LanCheck( object sender, EventArgs e )
		{
			if( lancheck.Checked )
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
			if( consolecheck.Checked )
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
			Properties.Settings.Default.Console = consolecheck.Checked;
		}

		private void MaxPlayersChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.MaxPlayers = Convert.ToInt32( maxplayers.Value );
		}

		private void MapChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.Map = mapselect.SelectedItem.ToString();
		}

		private void GamemodeChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.Gamemode = gameselect.SelectedItem.ToString();
		}

		private void ChangePathClick(object sender, EventArgs e)
		{
			FolderBrowserDialog browse = new FolderBrowserDialog();
			browse.Description = "Select server file path. (The folder containing the srcds.exe file.)";
			if (browse.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.FilePath = browse.SelectedPath;
				label4.Text = "Current server file path: " + Properties.Settings.Default.FilePath;
			}
		}

		private void PasswordChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.Password = passwordBox.Text;
			if (string.IsNullOrWhiteSpace(passwordBox.Text))
			{
				Password = "";
				return;
			}
			Password = " +sv_password " + passwordBox.Text;
		}

		private void StartButtonClick( object sender, EventArgs e )
		{
			var proc = new ProcessStartInfo
			{
				UseShellExecute = true,
				WorkingDirectory = Properties.Settings.Default.FilePath,
				FileName = Properties.Settings.Default.FilePath + @"\srcds.exe",
				Arguments = "+gamemode " + gameselect.Text.ToString() + ConsoleEnabled + LANEnabled + "+map " + mapselect.Text.ToString() + " +maxplayers " + maxplayers.Value + " +r_hunkalloclightmaps 0" + Password,
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
	}
}
