using System;
using System.Windows.Forms;

namespace GMod_Server_Launcher_Console
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if ( string.IsNullOrWhiteSpace( Properties.Settings.Default.FilePath ) )
			{
				DialogResult BrowseCheck = MessageBox.Show( "Browse for server executable path?", "Server file path not found.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );
				if ( BrowseCheck == DialogResult.Yes )
				{
					FolderBrowserDialog browse = new FolderBrowserDialog
					{
						Description = "Select server file path. (The folder containing the srcds.exe file.)"
					};
					if ( browse.ShowDialog() == DialogResult.OK )
					{
						Properties.Settings.Default.FilePath = browse.SelectedPath;
					}
				}
				else return;
			}
			Application.Run( new MainForm() );
			Properties.Settings.Default.Save();
		}
	}
}
