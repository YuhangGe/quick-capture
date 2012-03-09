Module APIDeclare
#Region "API Declare"
    Public Enum RasterOps
        R2_BLACK = 1
        R2_NOTMERGEPEN
        R2_MASKNOTPEN
        R2_NOTCOPYPEN
        R2_MASKPENNOT
        R2_NOT
        R2_XORPEN
        R2_NOTMASKPEN
        R2_MASKPEN
        R2_NOTXORPEN
        R2_NOP
        R2_MERGENOTPEN
        R2_COPYPEN
        R2_MERGEPENNOT
        R2_MERGEPEN
        R2_WHITE
        R2_LAST
    End Enum


    Public Enum BrushStyles
        BS_SOLID = 0
        BS_NULL = 1
        BS_HATCHED = 2
        BS_PATTERN = 3
        BS_INDEXED = 4
        BS_DIBPATTERN = 5
        BS_DIBPATTERNPT = 6
        BS_PATTERN8X8 = 7
        BS_MONOPATTERN = 9
    End Enum


    Public Enum PenStyles
        PS_SOLID = 0
        PS_DASH = 1
        PS_DOT = 2
        PS_DASHDOT = 3
        PS_DASHDOTDOT = 4
    End Enum
    Public Enum DwFlags
        LWA_ALPHA = &H2
        LWA_COLORKEY = &H1
    End Enum
    Public Const MF_SEPARATOR = &H800&
    Public Const MF_BYCOMMAND = &H0&
    Public Const WM_COMMAND = &H111
    Public Const WM_USER = &H400
    Public Const WF_STRING = &H0
    Public Const WM_KEYUP = &H101

    Public Const WM_SYSCOMMAND = &H112
    Public Const HWND_BROADCAST = &HFFFF&
    '鼠标样式
    Public Const OCR_APPSTARTING = 32650
    Public Const OCR_CROSS = 32515
    Public Const OCR_HAND = 32649
    Public Const OCR_IBEAM = 32513
    Public Const OCR_SIZEALL = 32646
    Public Const OCR_UP = 32516
    Public Const OCR_NORMAL = 32512
    Public Const WS_EX_LAYERED = &H80000
    Public Const GWL_EXSTYLE = (-20)

    '虚拟键值
    Public Const VK_CONTROL = &H11
    Public Const VK_SHIFT = &H10
    Public Const VK_MENU = &H12

    Public Declare Auto Function Rectangle Lib "gdi32" Alias "Rectangle" (ByVal hdc As IntPtr, ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
    Public Declare Auto Function SetROP2 Lib "gdi32" Alias "SetROP2" (ByVal hdc As IntPtr, ByVal nDrawMode As Integer) As Integer
    Public Declare Auto Function SelectObject Lib "gdi32" Alias "SelectObject" (ByVal hdc As IntPtr, ByVal hObject As Integer) As Integer
    Public Declare Function DeleteObject Lib "gdi32" Alias "DeleteObject" (ByVal hObject As IntPtr) As Integer
    Public Declare Function CreatePen Lib "gdi32" Alias "CreatePen" (ByVal nPenStyle As PenStyles, ByVal nWidth As Integer, ByVal crColor As Integer) As Integer
    Public Declare Function GetWindowDC Lib "user32" Alias "GetWindowDC" (ByVal hwnd As IntPtr) As Integer
    Public Declare Function ReleaseDC Lib "user32" Alias "ReleaseDC" (ByVal hwnd As IntPtr, ByVal hdc As IntPtr) As Integer

    Public Declare Ansi Function WindowFromPoint Lib "user32.dll" (ByVal winPoint As Point) As IntPtr
    Public Declare Ansi Function GetCursorPos Lib "user32.dll" (ByRef lpPoint As Point) As Boolean

    Public Declare Auto Function SetSystemCursor Lib "user32" Alias "SetSystemCursor" (ByVal hcur As IntPtr, ByVal id As Integer) As Integer
    Public Declare Auto Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByRef lpvParam As Integer, ByVal fuWinIni As Integer) As Integer
    Public Declare Auto Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr
    Public Declare Auto Function SetCursorPos Lib "user32" Alias "SetCursorPos" (ByVal x As Integer, ByVal y As Integer) As Integer

    Public Declare Auto Function BitBlt Lib "gdi32" Alias "BitBlt" (ByVal hDestDC As IntPtr, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hSrcDC As IntPtr, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal dwRop As Integer) As Integer
    Public Declare Auto Function GetWindowRect Lib "user32" (ByVal hwnd As IntPtr, ByRef lpRect As Rectangle) As Integer
    Public Declare Auto Function SetLayeredWindowAttributes Lib "user32.Dll" (ByVal hWnd As IntPtr, ByVal crKey As Integer, ByVal Alpha As Byte, ByVal dwFlags As Integer) As Boolean
    Public Declare Auto Function SetWindowLong Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As IntPtr) As Integer
    Public Declare Auto Function GetWindowLong Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
    Public Declare Auto Function GetKeyState Lib "user32" Alias "GetKeyState" (ByVal nVirtKey As Integer) As Short
    Public Declare Auto Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Public Declare Auto Function InvalidateRect Lib "user32" Alias "InvalidateRect" (ByVal hwnd As IntPtr, ByVal lpRect As Rectangle, ByVal bErase As Integer) As Integer
    Public Declare Auto Function PostMessage Lib "user32" Alias "PostMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
#End Region
End Module
