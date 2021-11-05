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
;-------------------------------------------------------------
; Lexicos says: "WinHttpRequest does not use TLS 1.1 or 1.2 by default on Windows 7 and older".
; So he uses Msxml2.XMLHTTP here: https://github.com/Lexikos/AutoHotkey-Release/commit/4622287857dbbb2f23dfc91615c5b3b6650241ac
; And we will use it.
; Frankly speaking, I get strange encoding in var text while using your WinHttpRequest code. With Msxml2.XMLHTTP everything is ok.
;-------------------------------------------------------------
	request := ComObjCreate("Msxml2.XMLHTTP")
	request.Open("GET", "https://raw.githubusercontent.com/iQuerz/MyAHKScript/main/script.ahk", true)
	request.Send()
	while (request.readyState != 4 && A_Index <= 50)    ; We will wait for response 5 seconds at maximum (50*100 ms = 5000 ms).
		sleep 100
	if request.readyState != 4 {
		MsgBox, Connection to the server failed, try to update later.
		if request.readyState != 4  ; We could  get the response while user was reading msgbox's text.
			ExitApp
		else MsgBox, A miracle has just happened, we've got the update!
	}
  	text := request.ResponseText
	;-------------------------------------------------------------
	; What were you doing here? You've just made "urrentVersion = 1.6" instead of "currentVersion = 1.6"
	;StringLen, length, text
	;scriptContent := SubStr(text, 2, length)
	;FileAppend, %scriptContent%, temp.txt
	;-------------------------------------------------------------
	; If you want to overwrite a file, just delete it before FileAppend.
	; We don't need this "temporary file" things:
	;FileAppend, %text%, temp.txt
	;FileMove, temp.txt, script.ahk, true
	;-------------------------------------------------------------
	FileDelete, script.ahk
	FileAppend, % text, script.ahk
	Run script.ahk
	;FileDelete, temp.txt  ; We don't need this line too.

GuiClose:   ; If user closes the gui window you should terminate dialog.ahk. Look at GuiClose in the documentation.
Close:
	ExitApp
