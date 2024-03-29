# Welcome to Version 2!🎉🎉
I've made it so anyone can have this script without the need of setting it up. Just download, run the installer, select what features you want and you're done! You may choose for it to place the script shortcut in the start menu, on the desktop, and even run it on startup! It can install [AutoHotkey](https://www.autohotkey.com/) too, which is required for this script to work. Uninstalling the script is as simple as a click of a button. No harm done.

# Important note before you download the installer:
Most browsers flag unsigned .exe files as dangerous or viruses. I do not have money to digitally sign my work, so you will just have to trust me, or read the code, which is openly available for everyone to check. This software is accessing OS reserved folders such as `Program Files`, which is likely one of the reasons it's being flagged as dangerous. I assure you that this software *does not* alter any OS files. It is *not* a virus. If you do not trust me, as I said, the code is openly available for everyone and you may check every bit of it. You may even build it yourself if you wish. The tools used are `Visual Studio 2019`. Project is built in `.NET Core 3.1`.  
**Update:** I added a "iQScriptNotifier" project. Before building the installer project, it's required to publish the notifier as a single file and place it in the resources folder of the installer project with the default name `iQScriptNotifier.exe`.

### [Download Installer](https://download1488.mediafire.com/uallwew0nf9g/iwl5tazeuivtpzi/iQScript_2.5.1.0.zip)  
When updating, please turn off the running script from the taskbar by right-clicking on it and selecting `exit`. I'll try automating this sometime in the future.

## GoTo:
[About](https://github.com/iQuerz/MyAHKScript#about)  
[Feature List](https://github.com/iQuerz/iQScript#feature-list)  
[Current Version](https://github.com/iQuerz/iQScript#current-version-251)  
[Version History](https://github.com/iQuerz/iQScript#version-history)  
[Script Files](https://github.com/iQuerz/iQScript#script-files)  
[Future Plans](https://github.com/iQuerz/iQScript#todo)


## About
This is an [AutoHotkey](https://www.autohotkey.com/) script that I use on a daily basis for my PC. It features a few shortcuts that help me stay productive. They are mostly already existing shortcuts remapped to my liking, all around the use of the "alt" key. I set it up as such because I think the alt key is the best modifier for left hand shortcuts, which is 100% of the time on your keyboard, while the right hand is changing between the mouse and the keyboard. I will list the shortcuts below.


## Feature List:
- **Automagical installer**:  
*Portable installer that concocts the script to your liking. Just select what features you want.*

- **Alt + \\**:  
*Toggles the script on and off.*

- **Alt + Q**:  
*Closes the Active Window and brings to focus last one used.*

- **Alt + W**:  
*Minimizes the Active Window and brings to focus last one used.*

- **Alt + 8, 9 or 0**:  
*Stands for Delete, Home and End functionalities respectively*

- **Alt + E**:  
*Opens File Explorer.*

- **Alt + A**:  
*Opens Windows notifications.*

- **Alt + S**:  
*Runs Windows ScreenSnip for making a quick screenshot. Requires one setting turned on:*  
`"Settings" -> "Accessibility" -> "Keyboard" -> "Use the Print screen button to open screen snipping"`

- **Windows Key**:  
*Runs a [PowerToys](https://github.com/microsoft/PowerToys#microsoft-powertoys) feature called "Run". I use this in conjunction with [TaskBarX](https://chrisandriessen.nl/taskbarx), to create a clean environment.*

- **Alt + Scroll**:  
*Horizontal scroll. Scrolling up means left and down means right.*

- **CapsLock**:  
*A small green popup over the screen in the corner, active when your CapsLock state is on.*

- **Ctrl + CapsLock**:  
*Toggles homerow into a numpad. a=1, s=2, d=3, etc.*

- **Semicolon + `I`,`J`,`K` & `L` Keys**:  
*Simulates arrow keys while holding down the semicolon. Useful when your hands are on the homerow position.*

- **Auto Update**:  
*Checks for updates regularly and offers to download the new version installer*


## Current Version: 2.5.1
Fixed "'Update available' when there's no internet" bug. Installer takes almost half as much space.  

## Version History:
**v2.5**: (New feature: `Alt`+`\` for toggling the script on/off. Switched to windows toast notifications)  
**v2.4**: (Added dynamic location assignment for popup features)  
**v2.3**: (Arrow keys simulation feature now works with every keyboard layout. Big installer improvements.)  
**v2.2**: (Bugfixes. Small QOL changes. Hosting migrated away from GH LFS.)  
**v2.1**: (Added shift and ctrl modifiers to "Alt + 8, 9 or 0" feature. Installer is now packed into one `.exe`.)  
**v2.0**: (Performance tweaks. Added CapsLock floating indicator and NumPad homerow. Easy setup with configurator tool.)  
**v1.7**: (Small bugfixes, code readability tweak and removal of some legacy classes.)  
**v1.6**: (Added support for automatic updates.)  
**v1.5**: (New feature: `Alt` + `8`, `9` or `0` for `Delete`, `Home` & `End`, respectively.)  
**v1.4**: (Minor bugfixes and performance tweaks.)  
**v1.3**: (Fixed a bug where typing ';' or ':' sometimes wouldn't work.)  
**v1.2**: (New feature: arrow keys simulation with `I`,`J`,`K` and `L` keys while holding down the `;` button.)  
**v1.1**: (Fixed "file explorer not opening" and "shortcuts with windows button not working" issues.)  
**v1.0**: (First iteration, when I got the idea to upload this here.)

## Script Files
`"Hey! I know my stuff. I want to set it up myself! Manually!"` Don't worry. I got your back. If you want to copy the contents of the actual scripts and play with them *yourself*, you will find them inside `Tools-Data/iQScript-Configurator/iQScript-Configurator/Resources`. Or you can simply follow [this link here](https://github.com/iQuerz/iQScript/tree/main/Tools-Data/iQScript-Configurator/iQScript-Configurator/Resources). Note that you must add a line of code, `currentVersion = 2.5.1`, to the beginning of the main `iQScript.ahk` file for it to work.

## //TODO:
- Add window layouts, kinda like virtual desktop but faster & for bigger monitors. Kinda like i3 wm workspaces. My idea was to have Alt+Shift+numbers to go through them :)
- Add a hotkey for a gui with all the hotkeys (context menu)
- Add an easily editable programs blacklist for select hotkeys
- V3.0 Installer with easily expandable code  
- Licence  
- Automated updates, or at least something with a bit smoother experience  

Any thoughts or suggestions are more than welcome. 
If you like my work, I have another repository dedicated to running powershell by f12 key with additional fancy stuff. 
You can check it out [here](https://github.com/iQuerz/PowerShellAHK#powershellahk). 
