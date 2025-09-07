^+z::  ; Ctrl + Shift + Z
    FileSelectFile, filePath, 3, C:\Users\DELL\Desktop\VLA ACADEMY\, Selecciona un archivo, Text Files (*.txt)
    if (filePath = "")  ; Si no se selecciona nada, salir
        return

    FileRead, urls, %filePath%
    Loop, Parse, urls, `n, `r
    {
        if (A_LoopField != "")
            Run, chrome.exe %A_LoopField%
    }
return
