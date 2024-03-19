# Universal Source Dedicated Server Launcher
 This is a replacement launcher compatible with any GoldSrc, Source, or Source 2 dedicated server that allows you to launch your servers with additional options, without having to use a command line or manually type out parameters for a shortcut. The launcher supports Windows 7 and newer, and should also work on any Linux distro with Mono installed, though only Linux Mint and Manjaro have been tested.

![](https://raw.githubusercontent.com/LambdaGaming/GMod-Server-Launcher-Console/master/reference.PNG)

# Features:
- Option to use legacy launcher. If this is enabled, most other options will be disabled since the legacy launcher will ignore them.
- Map selection (`+map`)
  - Gets the names of maps inside the server's map folder. The map name can also be manually entered into the text box if the map is in a different location.
- Game/Gamemode selection (`+gamemode` or `-game`)
  - For Garry's Mod servers, the launcher will automatically update the list of gamemodes found in the server's gamemodes folder
  - For s&box servers, the box will be filled with a placeholder gamemode that can be manually changed
  - For all other games, it will use the name of the selected game folder
- LAN mode toggle (`+sv_lan`)
- Max players slider (`+maxplayers`)
- Password option (`+sv_password`)
- Steam token input (`+sv_setsteamaccount`)
  - Certain games including Garry's Mod and CS:GO require the server to be registered with Steam in this way for it to show up in the server browser
- Steam workshop collection option (`+host_workshop_collection`)
- Input for additional launch parameters
- The `+r_hunkalloclightmaps` parameter is automatically set to 0
  - Setting this to 0 prevents crashes when loading complex maps. Some games have it set to 1 by default.
- Linux terminal program name
  - If running on Linux, you can have the server open in the terminal program of your choice by entering the terminal's command name, such as gnome-terminal
- All settings are saved when the program closes and will be automatically set when the program is reopened.

# Working with more than one server:
 If you need this program to run more than one server, you can copy the exe and rename it to something else to generate a new config.

# Issues & Pull Requests
 If you would like to contribute to this repository by creating an issue or pull request, please refer to the [contributing guidelines.](https://lambdagaming.github.io/contributing.html)
