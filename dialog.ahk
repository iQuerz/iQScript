#SingleInstance Force

Gui, Font, cBlack
Gui, Add, Text,, New version of script is available. Would you like to update?
Gui, Add, Link,, <a href="https://github.com/iQuerz/MyAHKScript">Read about new version</a>
Gui, Font, cBlack
Gui, Add, Button, Default h33 w100  gClose,  I'll Update myself
Gui, Add, Button,  x+80		h33 w100  gUpdate, Update it for me
Gui, Show, CenterAutosize, Update
Return

Update:
	request := ComObjCreate("WinHttp.WinHttpRequest.5.1")
	request.Open("GET", "https://raw.githubusercontent.com/iQuerz/MyAHKScript/main/script.ahk", true)
	request.Send()
	request.WaitForResponse()
	text := request.ResponseText
	StringLen, length, text
	scriptContent := SubStr(text, 2, length)

	FileAppend, %scriptContent%, temp.txt
	FileMove, temp.txt, script.ahk, true
	Run script.ahk
	FileDelete, temp.txt

Close:
	ExitApp
Return