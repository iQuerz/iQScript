#MaxHotkeysPerInterval 15000
#NoEnv
SendMode Input
SetWorkingDir %A_ScriptDir%

; alt+q for close
!Q::WinClose A
SendInput {Alt Down}{Tab}{Alt Up}
return

; alt+w for minimize
!W::WinMinimize A
SendInput {Alt Down}{Tab}{Alt Up}
return

; alt+a for notifications
!A::SendInput #a
return

;alt+s for screenshot
!S::
Run C:\WINDOWS\system32\SnippingTool.exe /clip
return

;alt+e for my computer
!E::SendInput {Lwin}E
return

;remap Lwin button to run "powertoys run"(mine is set to ctrl+space)
LWin::SendInput ^{Space}
return

;aaand use alt+win for actual win button, if you ever need it
!LWin::SendInput {Lwin}
return

; win+scroll up to scroll left.
!WheelUp::SendInput {WheelLeft}
return

; alt+scroll down to scroll right.
!WheelDown::SendInput {WheelRight}
return
