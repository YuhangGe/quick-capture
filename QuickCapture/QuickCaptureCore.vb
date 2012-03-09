Imports System.Drawing
Public Class QuickCaptureCore
   
    Public Enum CaptureRegionEnum
        Desktop
        WinOrCtl
        Selection
    End Enum
    Private cr As CaptureRegionEnum
    Private rtnBmp As Bitmap
    Private hwnd As IntPtr
    Private rect As Rectangle
    Public Sub New()
        cr = CaptureRegionEnum.Desktop
        hwnd = 0
    End Sub

    Public Sub New(ByVal cr As CaptureRegionEnum, ByVal hwnd As IntPtr)
        Me.cr = cr
        Me.hwnd = hwnd
    End Sub
    Public Sub New(ByVal cr As CaptureRegionEnum, ByVal rect As Rectangle)
        Me.cr = cr
        Me.rect = rect
        hwnd = 0
    End Sub
    Public ReadOnly Property CaptureRegion() As CaptureRegionEnum
        Get
            Return cr
        End Get
    End Property
    Public Function Capture() As Bitmap
        doCapture()
        Return rtnBmp
    End Function
    Private Sub doCapture()
        rtnBmp = Nothing
        Dim g1 As Graphics = Graphics.FromHwnd(0)
        Select Case cr
            Case CaptureRegionEnum.Desktop
                rect = New Rectangle(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
            Case CaptureRegionEnum.WinOrCtl
                GetWindowRect(hwnd, rect)
        End Select
        rtnBmp = New Bitmap(rect.Width - rect.X, rect.Height - rect.Y)
        rtnBmp.SetResolution(1280, 800)
        Dim g2 As Graphics = Graphics.FromImage(rtnBmp)
        Dim d1 As IntPtr = g1.GetHdc
        Dim d2 As IntPtr = g2.GetHdc
        BitBlt(d2, 0, 0, rect.Width - rect.X, rect.Height - rect.Y, d1, rect.X, rect.Y, &HCC0020)
        g1.ReleaseHdc(d1)
        g2.ReleaseHdc(d2)
        g2 = Nothing
        g1 = Nothing
    End Sub
End Class
