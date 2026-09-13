using System;
using System.IO;
using System.Text.Json;

namespace UniversalSrcdsLauncher;

public class AppSettings
{
	public static string ConfigName { get; set; } = "default";
	public bool LanServer { get; set; } = false;
	public string SelectedMap { get; set; } = "";
	public string SelectedGame { get; set; } = "";
	public int MaxPlayers { get; set; } = 24;
	public string Password { get; set; } = "";
	public string LaunchParams { get; set; } = "";
	public string WorkshopId { get; set; } = "";
	public string ServerPath { get; set; } = "";
	public string TokenPath { get; set; } = "";
	public string SelectedExe { get; set; } = "";
}

public class SettingsService
{
	private static readonly string SettingsPath = Path.Combine( Environment.GetFolderPath(
		Environment.SpecialFolder.LocalApplicationData ),
		"Universal-Srcds-Launcher",
		$"{AppSettings.ConfigName}.json" );

	public AppSettings Load()
	{
		if ( !File.Exists( SettingsPath ) )
			return new AppSettings();

		var json = File.ReadAllText( SettingsPath );
		return JsonSerializer.Deserialize<AppSettings>( json ) ?? new AppSettings();
	}

	public void Save( AppSettings settings )
	{
		var dir = Path.GetDirectoryName( SettingsPath );
		Directory.CreateDirectory( dir );

		var json = JsonSerializer.Serialize( settings, new JsonSerializerOptions {
			WriteIndented = true
		} );
		File.WriteAllText( SettingsPath, json );
	}
}
