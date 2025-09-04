^!g::  ; Ctrl + Alt + G
; Abre Git Bash en tu carpeta PROYECTOS
Run, "C:\Program Files\Git\git-bash.exe" --cd="C:\Users\DELL\Desktop\UNIVERSIDAD\PROYECTOS"
Sleep, 3000  ; espera a que Git Bash abra

; Ejecuta los comandos de Git
Send, git add .{Enter}
Sleep, 1500
Send, git commit -m "actualización automática"{Enter}
Sleep, 1500
Send, git push{Enter}
Return









