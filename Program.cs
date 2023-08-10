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
			if ( string.IsNullOrWhiteSpace( Properties.Settings.Default.FileName ) || !File.Exists( Properties.Settings.Default.FileName ) )
			{
				DialogResult BrowseCheck = MessageBox.Show( "Please select the server file.", "Server file path not found.", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				if ( BrowseCheck == DialogResult.OK )
				{
					OpenFileDialog browse = new OpenFileDialog();
					browse.Filter = "Server Executable (*.exe)|*.exe";
					browse.RestoreDirectory = true;
					if ( browse.ShowDialog() == DialogResult.OK )
					{
						Properties.Settings.Default.FileName = browse.FileName;
						Properties.Settings.Default.FilePath = Path.GetDirectoryName( browse.FileName );
					}
				}
				else return;
			}
			Application.Run( new MainForm() );
			Properties.Settings.Default.Save();
		}
	}
}
