# Welcome to Version 2.0!🎉🎉
I've made it so anyone can have this script without the need of setting it up. Just download [the zip file](https://github.com/iQuerz/MyAHKScript/raw/main/iQScript-Configurator.zip) and run the `iQScriptConfigurator.exe` that sits inside the folder, select what features you want, and you're done! You may choose for it to place the script in the start menu, on the desktop, and even run it on startup! It can install [AutoHotkey](https://www.autohotkey.com/) too, which is required for this script to work. Uninstalling is as simple as a click of a button. No harm done.

#### Important note before we start:
Most browsers flag unsigned .exe files as dangerous or viruses. I do not have money to digitally sign my work, so you will just have to trust me, read the code, or build it yourself. You can find the same .exe file inside the project, following this path: `iQ-AHK-Script\Tools-Data\iQScript-Configurator\iQScript-Configurator\bin\Release\netcoreapp3.1`. If you wish to build the code yourself, you need .net core installed along with Microsoft Visual Studio. The .sln file is inside `Tools-data\iQScript-Configurator`. 

## GoTo:
[About](https://github.com/iQuerz/MyAHKScript#about)  
[Feature List](https://github.com/iQuerz/MyAHKScript#feature-list)  
[Current Version](https://github.com/iQuerz/MyAHKScript#current-version-17)  
[Version History](https://github.com/iQuerz/MyAHKScript#version-history)  
[Future Plans](https://github.com/iQuerz/MyAHKScript#todo)

## About
This is an [AutoHotkey](https://www.autohotkey.com/) script that I use on a daily basis for my PC. It features a few shortcuts that help me stay productive. They are mostly already existing shortcuts remapped to my liking, all around the use of the "alt" key. I set it up as such because I think the alt key is the best modifier for left hand shortcuts, which is 100% of the time on your keyboard, while the right hand is changing between the mouse and the keyboard. I will list the shortcuts below.

## Feature List:
- **Automagical installer**:  
*Portable installer that concocts the script to your liking. Just select what features you want.*

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
*Runs Windows ScreenSnip for making a quick screenshot.*

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
*Checks for updates on startup and offers to update the script for you, automagically* - **not supported for 2.0 yet**


## Current Version: 2.0
Performance tweaks. Added CapsLock floating indicator and NumPad homerow. Easy setup with configurator tool.

## Version History:
**v1.7**: (Small bugfixes, code readability tweak and removal of some legacy classes.)  
**v1.6**: (Added support for automatic updates.)  
**v1.5**: (New feature: Alt + 8, 9 or 0 for Delete, Home and End, respectively.)  
**v1.4**: (Minor bugfixes and performance tweaks)  
**v1.3**: (Fixed a bug where typing ';' or ':' sometimes wouldn't work.)  
**v1.2**: (New feature: arrow keys simulation with `I`,`J`,`K` and `L` keys while holding down the `;` button.)  
**v1.1**: (Fixed "file explorer not opening" and "shortcuts with windows button not working" issues)  
**v1.0**: (first iteration, at least... when I got the idea to upload this here)


## //TODO:
- Add a hotkey for a gui with all the hotkeys (context menu)
- Add an easily editable programs blacklist for select hotkeys
- Add an on/off toggle hotkey for the whole script

Any thoughts or suggestions are more than welcome. 
If you like my work, I have another repository dedicated to running powershell by f12 key with additional fancy stuff. 
You can check it out [here](https://github.com/iQuerz/PowerShellAHK#powershellahk). 
