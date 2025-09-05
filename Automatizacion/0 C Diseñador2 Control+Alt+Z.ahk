Esc::ExitApp  ; Cierra el script por completo

^!z::
    ; Paso 1: Ctrl + #
    Send, ^+3
    Sleep, 400

    ; Paso 2: Flecha abajo
    Send, {Down}
    Sleep, 400

    ; Paso 3: Shift + Tab
    Send, +{Tab}
    Sleep, 400

    ; Paso 4: Shift + Tab
    Send, +{Tab}
    Sleep, 400

    ; Paso 5: Enter
    Send, {Enter}
    Sleep, 400

    ; Paso 6: Ctrl + "
    Send, ^"{}
    Sleep, 400

    ; Paso 7: Flecha abajo
    Send, {Down}
    Sleep, 400

    ; Paso 8: Shift + Tab
    Send, +{Tab}
    Sleep, 400

    ; Paso 9: Shift + Tab
    Send, +{Tab}
    Sleep, 400

    ; Paso 10: Enter
    Send, {Enter}
    Sleep, 400

    ; Paso 11: Ctrl + E
    Send, ^e
    Sleep, 1000 ; Esperar 1 segundo

    ; Paso 12: Click derecho
    Click, left
    Sleep, 400 ; Esperar 1 segundo

    ; Paso 13: Enter
    Send, {Enter}
    Sleep, 5000 ; Esperar 5 segundos

    ; Paso 14: Enter
    Send, {Enter}
    Sleep, 4000 ; Esperar 1 segundo

    ; Paso 15: Ctrl + AvPág
    Send, ^{PgDn}
    Sleep, 1200 ; Esperar 1 segundo

    ; Paso 16: Volver a ejecutar el script
    Goto, ^!z
return
