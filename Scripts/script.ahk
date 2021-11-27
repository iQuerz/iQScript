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

;1 alt+q for close
!Q:: WinClose A

;2 alt+w for minimize
!W:: WinMinimize A

;3 alt + 8 for delete
!8:: SendInput {Delete}

;4 alt + 9 for home
!9:: SendInput {Home}

;5 alt + 0 for end
!0:: SendInput {End}

;6 alt+e for my computer
!E:: Run C:\Windows\explorer.exe

;7 alt+a for notifications
!A:: SendInput #a

;8 alt+s for screenshot (you have to set screensnip to PrtSc for this to work, Settings->Accessibility->Keyboard->Use PrtSc...)
!S:: SendInput {PrintScreen}

;9 Use windows key for PowerToys Run, but retain the functionality of other shortcuts using Windows key
#If A_PriorKey == "LWin"
	LWin Up::
		SendInput !r
#If

;10 alt+scroll up to scroll left.
!WheelUp:: SendInput {WheelLeft}

;11 alt+scroll down to scroll right.
!WheelDown:: SendInput {WheelRight}


;12 CapsLock floating window
CapsLock::
	SendInput {CapsLock}
	check := GetKeyState("CapsLock", "T")
	if(check == 1){
		Run caps.ahk
	}
return

;13 Ctrl+CapsLock for Homerow NumPad. 'o' represents 0 because ; is used for arrow keys simulation(see below)
numpad = false
^CapsLock::
	numpad := !numpad
	if(numpad == true){
		Run numpad.ahk
	}
	if(numpad == false){
		;Process, Close, numpad.ahk
	}
return

#if numpad == true
	*a::1
	*s::2
	*d::3
	*f::4
	*g::5
	*h::6
	*j::7
	*k::8
	*l::9
	*o::0
#if

;14 Next bit of the code is for simulating arrow keys with I, J, K, L while holding down ';'. Helpful when your hands are at the homerow position
SC0027 & I::Up
SC0027 & J::Left
SC0027 & K::Down
SC0027 & L::Right
+SC0027:::
SC0027::Send `;
