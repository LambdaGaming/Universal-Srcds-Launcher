using System.IO;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using UniversalSrcdsLauncher.ViewModels;
using UniversalSrcdsLauncher.Views;

namespace UniversalSrcdsLauncher;

public partial class App : Application
{
	public override void Initialize()
	{
		AvaloniaXamlLoader.Load(this);
	}

	public override void OnFrameworkInitializationCompleted()
	{
		if ( ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop )
		{
			var args = desktop.Args;
			if ( args?.Length > 0 )
			{
				AppSettings.ConfigName = args[0];
			}

			desktop.MainWindow = new MainWindow
			{
				DataContext = new MainViewModel( new SettingsService() ),
			};
			base.OnFrameworkInitializationCompleted();

			if ( desktop.MainWindow.DataContext is MainViewModel view )
			{
				// Prompt for server path if it doesn't exist
				if ( string.IsNullOrWhiteSpace( view.ServerPath ) && !Directory.Exists( view.ServerPath ) )
					_ = view.GetServerPath();
				else
					view.UpdateLists();
			}
		}
	}
}
