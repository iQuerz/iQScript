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

;alt+e for my computer
!E::
Run C:\Windows\explorer.exe
return

;alt+a for notifications
!A::SendInput #a
return

;alt+s for screenshot
!S::
Run C:\WINDOWS\system32\SnippingTool.exe /clip
return

;Use windows key for PowerToys Run, but retain the functionality of other shortcuts using Windows key
#If A_PriorLey == "LWin"
LWin Up::Send ^{Space}
#If

; alt+scroll up to scroll left.
!WheelUp::SendInput {WheelLeft}
return

; alt+scroll down to scroll right.
!WheelDown::SendInput {WheelRight}
return
