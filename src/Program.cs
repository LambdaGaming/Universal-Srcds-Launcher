using System;
using System.IO;
using System.Windows.Forms;

namespace Universal_Srcds_Launcher
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if ( string.IsNullOrWhiteSpace( Properties.Settings.Default.ExeName ) || !File.Exists( Properties.Settings.Default.ExeName ) )
			{
				DialogResult BrowseCheck = MessageBox.Show( "Please select the server executable.", "Server executable not found.", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				if ( BrowseCheck == DialogResult.OK )
				{
					OpenFileDialog browse = new OpenFileDialog();
					browse.Filter = "Server Executable (*.exe;srcds_run*)|*.exe;srcds_run*";
					browse.RestoreDirectory = true;
					if ( browse.ShowDialog() == DialogResult.OK )
					{
						Properties.Settings.Default.ExeName = browse.FileName;
						Properties.Settings.Default.ExePath = Path.GetDirectoryName( browse.FileName );
					}
				}
				else return;
			}
			if ( string.IsNullOrWhiteSpace( Properties.Settings.Default.GamePath ) || !Directory.Exists( Properties.Settings.Default.GamePath ) )
			{
				DialogResult BrowseCheck = MessageBox.Show( "Please select the server's game folder.", "Server game folder not found.", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				if ( BrowseCheck == DialogResult.OK )
				{
					FolderBrowserDialog browse = new FolderBrowserDialog();
					if ( browse.ShowDialog() == DialogResult.OK )
					{
						Properties.Settings.Default.GamePath = browse.SelectedPath;
					}
				}
				else return;
			}
			Application.Run( new MainForm() );
			Properties.Settings.Default.Save();
		}
	}
}
