currentVersion = 1.7

request := ComObjCreate("Msxml2.XMLHTTP")
	request.Open("GET", "https://raw.githubusercontent.com/iQuerz/MyAHKScript/main/ver.txt", true)
	request.Send()
	while (request.readyState != 4 && A_Index <= 50)    ; Wait for response 5s max (50*100 = 5000ms).
		sleep 100
	if request.readyState != 4 {
		Goto Continue
	}
  	version := request.ResponseText

If(currentVersion != version){
	Run dialog.ahk
}

Continue:	; Continues to the script if update check fails

#MaxHotkeysPerInterval 15000
#NoEnv
#SingleInstance, Force
#UseHook
SetWorkingDir %A_ScriptDir%

; alt+q for close
!Q:: WinClose A

; alt+w for minimize
!W:: WinMinimize A

; alt + 8 for delete
!8:: SendInput {Delete}

; alt + 9 for home
!9:: SendInput {Home}

; alt + 0 for end
!0:: SendInput {End}

; alt+e for my computer
!E:: Run C:\Windows\explorer.exe

; alt+a for notifications
!A:: SendInput #a

; alt+s for screenshot
!S:: Run C:\WINDOWS\system32\SnippingTool.exe /clip

; Use windows key for PowerToys Run, but retain the functionality of other shortcuts using Windows key
#If A_PriorKey == "LWin"
	LWin Up::
		SendInput !r
#If

; alt+scroll up to scroll left.
!WheelUp:: SendInput {WheelLeft}

; alt+scroll down to scroll right.
!WheelDown:: SendInput {WheelRight}

; Next bit of the code is for simulating arrow keys with I, J, K, L while holding down ';'.
;  Helpful when your hands are at the homerow position
SC0027 & I::Up
SC0027 & J::Left
SC0027 & K::Down
SC0027 & L::Right
+SC0027:::
SC0027::Send `;
