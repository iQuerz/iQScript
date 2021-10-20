#MaxHotkeysPerInterval 15000
#NoEnv
SendMode Input
SetWorkingDir %A_ScriptDir%

; alt+q for close
!Q::
WinClose A
	SendInput !Tab
return

; alt+w for minimize
!W::
WinMinimize A
	SendInput !Tab
return

;alt+e for my computer
!E::
	Run C:\Windows\explorer.exe
return

; alt+a for notifications
	!A::SendInput #a
return

; alt+s for screenshot
!S::
	Run C:\WINDOWS\system32\SnippingTool.exe /clip
return

; Use windows key for PowerToys Run, but retain the functionality of other shortcuts using Windows key
#If A_PriorKey == "LWin"
	LWin Up::
		SendInput !r
#If

; alt+scroll up to scroll left.
!WheelUp::
	SendInput {WheelLeft}
return

; alt+scroll down to scroll right.
!WheelDown::
	SendInput {WheelRight}
return

; internal joke, you can skip & ignore or delete this part
!C::
	Send ce bude™
return

; Next bit of the code is for simulating arrow keys with I, J, K, L while holding down ';'.
;  Helpful when your hands are at the homerow position

; first, make sure the semicolon works on its own
if (A_PriorHotkey == ";") {
	`;::
		Send `;
}

; and then, return the shift+; for : functionality.
+`;::
	Send :
return

; the star of the show, ladies and gentlemen, the "I'm lazy to move my hands over to the arrow cluster"
#UseHook
`; & I::Up
`; & J::Left
`; & K::Down
`; & L::Right
