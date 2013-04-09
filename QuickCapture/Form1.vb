Imports System.Security.Principal
Imports DevComponents.DotNetBar.Controls

Public Class FrmMain


#Region "DrawRect variables"
    Dim winHwnd As IntPtr
    Dim winPoint As Point
    Dim len As Integer
    Dim preHwnd As IntPtr
    Dim p As Integer
    Dim winText As System.Text.StringBuilder = New System.Text.StringBuilder()
    Dim g As Graphics
    Dim pen As New Pen(Color.Black, 4)
    Dim rect As New Rectangle()

    Dim deskHdc As IntPtr
    Dim preHdc As IntPtr
    Dim newHdc As IntPtr
    Dim oldrop As Integer
    Dim newpen As IntPtr
    Dim oldpen As IntPtr
    Dim preRect As Rectangle

#End Region
    Dim acthook As HookCore
    Dim Capturing As Boolean = False
    Dim Cancel As Boolean = False
    Dim qcc As QuickCaptureCore = Nothing




    Dim reg As Microsoft.Win32.RegistryKey
    Private captureRegion As Integer
    Private savepath As String
    Private saveoption As Integer
    Private key As Integer
    Private ImgFormat As Integer
    Private viewForm As ViewFrm = Nothing
    Private screenDlg As ScreenCanvas = Nothing

    Private first As Boolean
    
   
    Private isCtrl, isAlt, isShift As Boolean
    Private hideAfterRun, hideWhenCapture As Boolean
    Private autoRun As Boolean
    Private isInAdmin As Boolean
    Private delayNum As Integer
    Private drawRthread As Threading.Thread
    Public Sub New()

        ' 此调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        If Not isAdmin() Then
            isInAdmin = False

            Dim icon1 As New Icon(System.Drawing.SystemIcons.Shield, 24, 24)
            CBAutoRun.Text = "    开机自动启动"
            PanelAutoRunImage.Visible = True
            PanelAutoRunImage.BackgroundImage = icon1.ToBitmap
        Else
            CBAutoRun.Text = "开机自动启动"
            PanelAutoRunImage.Visible = False
            isInAdmin = True
        End If
    End Sub
    Private Function isAdmin()
        Return New WindowsPrincipal(WindowsIdentity.GetCurrent).IsInRole(WindowsBuiltInRole.Administrator)
    End Function
    Private Sub FrmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        e.Cancel = True
    End Sub

    
    Private Sub initCmbKeys()
        CmbKeys.Items.Add("PrintScreen")
        Dim i As Integer
        For i = 48 To 57
            CmbKeys.Items.Add(Chr(i))
        Next
        For i = 65 To 90
            CmbKeys.Items.Add(Chr(i))
        Next
        CmbKeys.SelectedIndex = 0

    End Sub
    Private Sub saveReg()
        reg.SetValue("captureRegion", captureRegion)
        reg.SetValue("savepath", savepath)
        reg.SetValue("saveoption", saveoption)
        reg.SetValue("key", key)
        reg.SetValue("format", ImgFormat)
        reg.SetValue("ctrl", isCtrl)
        reg.SetValue("alt", isAlt)
        reg.SetValue("shift", isShift)
        reg.SetValue("hideafterrun", hideAfterRun)
        reg.SetValue("autorun", autoRun)
        reg.SetValue("delayNum", delayNum)

    End Sub
    Public Sub init()
        initCmbKeys()
        Dim first As Boolean = False
        reg = My.Computer.Registry.CurrentUser
        reg = reg.OpenSubKey("Software\QuickCapture", True)
        If reg Is Nothing Then
            reg = My.Computer.Registry.CurrentUser
            reg = reg.CreateSubKey("Software\QuickCapture")
            first = True

            captureRegion = 3
            savepath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            saveoption = 1
            key = 44
            ImgFormat = 0
            isCtrl = True
            isAlt = True
            isShift = True
            hideAfterRun = True
            hideWhenCapture = False
            autoRun = False
            delayNum = 0

            saveReg()
            reg.Close()
        Else
            captureRegion = reg.GetValue("captureRegion")
            savepath = reg.GetValue("savepath")
            saveoption = reg.GetValue("saveoption")
            key = reg.GetValue("key")
            ImgFormat = reg.GetValue("format")
            isCtrl = reg.GetValue("ctrl")
            isAlt = reg.GetValue("alt")
            isShift = reg.GetValue("shift")
            hideAfterRun = reg.GetValue("hideafterrun")
            hideWhenCapture = reg.GetValue("hidewhencapture")
            autoRun = reg.GetValue("autorun")
            delayNum = reg.GetValue("delayNum")
            reg.Close()


        End If
        CType(GPRegion.Controls(captureRegion), CheckBoxX).Checked = True

        If savepath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) Then
            RBDesktop.Checked = True
        Else
            RBUser.Checked = True
        End If
        If key = 44 Then
            CmbKeys.SelectedIndex = 0
        Else
            CmbKeys.SelectedIndex = key
        End If
        If isCtrl Then
            CBctrl.Checked = True
        End If
        If isAlt Then
            CBalt.Checked = True
        End If
        If isShift Then
            CBshift.Checked = True
        End If
        If autoRun = True Then
            CBAutoRun.Checked = True
        End If
        If delayNum > 0 Then
            CBdelay.CheckValue = True
            DelayNumTxt.Value = delayNum
            DelayNumTxt.Enabled = True
        Else
            CBdelay.CheckValue = False
            DelayNumTxt.Value = 0
            DelayNumTxt.Enabled = False
        End If
        Select Case ImgFormat
            Case 0
                RBbmp.Checked = True
            Case 1
                RBjpg.Checked = True
            Case 2
                RBpng.Checked = True
            Case 3
                RBgif.Checked = True
        End Select
        If saveoption = 1 Then
            RBAutoSave.Checked = True
        ElseIf saveoption = 0 Then
            RBview.Checked = True
        Else
            RBCopy.Checked = True
        End If
        If hideAfterRun Then
            CBRunHide.Checked = True
        End If
        If hideWhenCapture Then
            CBHide.Checked = True
        End If
        If hideAfterRun Then
            QuickCaptureNtf.ShowBalloonTip(10, "QuickCapture", "QuickCaputre已启动……", ToolTipIcon.Info)
        Else
            Me.Show()
        End If

     
        'set hook
        acthook = New HookCore
        AddHandler acthook.MouseMove, New MouseEventHandler(AddressOf MyMouseMove)
        AddHandler acthook.KeyDown, New KeyEventHandler(AddressOf MyKeyDown)
        AddHandler acthook.MouseDown, New MouseEventHandler(AddressOf MyMouseDown)
        'end set hook
        'acthook.Start()
        Capturing = False
        acthook.isCapturing = False
    End Sub

    Private Sub exitApp()
        reg = My.Computer.Registry.CurrentUser
        reg = reg.OpenSubKey("Software\QuickCapture", True)
        If reg Is Nothing Then
            reg = My.Computer.Registry.CurrentUser
            reg = reg.CreateSubKey("Software\QuickCapture")
        End If
        saveReg()
        reg.Close()
        acthook.Stops()
        If viewForm IsNot Nothing Then
            viewForm.Dispose()
        End If
        If screenDlg IsNot Nothing Then
            screenDlg.Dispose()
        End If
        Me.Dispose()
        End
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        exitApp()
    End Sub

    Private Sub BtnBegin_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBegin.Click


        doCapture()
    End Sub

    Private Sub beginCapture()
        Capturing = True
        SetSystemCursor(Cursors.Hand.Handle, OCR_NORMAL)
        SetSystemCursor(Cursors.Hand.Handle, OCR_APPSTARTING)
        SetSystemCursor(Cursors.Hand.Handle, OCR_CROSS)
        SetSystemCursor(Cursors.Hand.Handle, OCR_IBEAM)
        SetSystemCursor(Cursors.Hand.Handle, OCR_SIZEALL)
        SetSystemCursor(Cursors.Hand.Handle, OCR_UP)
        SetSystemCursor(Cursors.Hand.Handle, OCR_SIZEALL)

        acthook.isCapturing = True

        deskHdc = GetWindowDC(0)
        preHdc = deskHdc
        oldrop = SetROP2(deskHdc, RasterOps.R2_NOTXORPEN)
        newpen = CreatePen(PenStyles.PS_SOLID, 3, &HFF)
        oldpen = SelectObject(deskHdc, newpen)
        drawRthread = New Threading.Thread(AddressOf drawRECT)
        drawRthread.Start()
    End Sub
    Private Sub drawRECT()
        While (Capturing)
            Rectangle(deskHdc, rect.X, rect.Y, rect.Width, rect.Height)
            Threading.Thread.Sleep(500)
        End While
        InvalidateRect(0, Nothing, 0)
    End Sub
    Private Sub doCapture()
        If hideWhenCapture Then
            Me.Hide()
        End If
        Dim bmp As Bitmap = Nothing
        Select Case captureRegion
            Case 3
                qcc = New QuickCaptureCore()
                bmp = qcc.Capture
            Case 2
                qcc = New QuickCaptureCore(QuickCaptureCore.CaptureRegionEnum.WinOrCtl, GetForegroundWindow())
                bmp = qcc.Capture
            Case 1

                beginCapture()
                Exit Sub
            Case 0
                screenDlg = New ScreenCanvas(QuickCaptureCore.CaptureRegionEnum.Selection)
                screenDlg.ShowDialog()
                If screenDlg.DialogResult = Windows.Forms.DialogResult.OK Then
                    bmp = screenDlg.getBMP
                Else
                    QuickCaptureNtf.ShowBalloonTip(1, String.Empty, "截图操作已取消", ToolTipIcon.Info)
                    Exit Sub
                End If
        End Select
        If bmp Is Nothing Then
            QuickCaptureNtf.ShowBalloonTip(1, String.Empty, "出现预期外错误,截图操作失败", ToolTipIcon.Warning)

            Exit Sub
        End If
        If viewForm Is Nothing Then
            viewForm = New ViewFrm(bmp, savepath, ImgFormat)
        Else
            viewForm.changeBmp(bmp, savepath, ImgFormat)
        End If
        If saveoption = 1 Then
            viewForm.Show()
            viewForm.TopMost = True
        ElseIf saveoption = 0 Then
            Try
                viewForm.SaveFile()
            Catch ex As Exception
                MsgBox("保存失败！" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "提示")
            End Try
        ElseIf saveoption = 2 Then
            My.Computer.Clipboard.SetImage(bmp)
            QuickCaptureNtf.ShowBalloonTip(1, String.Empty, "图片已复制到剪切板", ToolTipIcon.Info)
        End If

        screenDlg = Nothing
    End Sub
    Public Sub MyMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        If Not Capturing Then
            Exit Sub
        End If
        If captureRegion = 1 Then
            SetCursorPos(e.X, e.Y)

            winPoint = New Point
            GetCursorPos(winPoint)

            winHwnd = WindowFromPoint(winPoint)

            If preHwnd <> winHwnd Then
                InvalidateRect(0, Nothing, 0)
                preRect = rect
                GetWindowRect(winHwnd, rect)
                ' Rectangle(deskHdc, preRect.X, preRect.Y, preRect.Width, preRect.Height)
                ' Rectangle(deskHdc, rect.X, rect.Y, rect.Width, rect.Height)
                preHwnd = winHwnd
            End If
        ElseIf captureRegion = 0 Then
            SetCursorPos(e.X, e.Y)
        End If

    End Sub

    Public Sub MyMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        If Not Capturing Then
            Exit Sub
        End If
        If captureRegion = 1 Then
            '   Rectangle(deskHdc, rect.X, rect.Y, rect.Width, rect.Height)

            If e.Button = Windows.Forms.MouseButtons.Left Then
                Cancel = False
            Else
                Cancel = True
            End If
            FinishCapture()
        End If

    End Sub
    Public Sub MyKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)

        If Not Capturing Then
            If isCtrl Or isAlt Or isShift Then
                If isCtrl Then
                    If GetKeyState(VK_CONTROL) >= 0 Then
                        Exit Sub
                    End If
                End If
                If isAlt Then
                    If GetKeyState(VK_MENU) >= 0 Then
                        Exit Sub
                    End If
                End If
                If isShift Then
                    If GetKeyState(VK_SHIFT) >= 0 Then
                        Exit Sub
                    End If
                End If
            End If
            Dim keyValue As Integer
            If key <> 44 Then
                keyValue = Asc(CStr(CmbKeys.Items(key)))
            End If
            If e.KeyCode = keyValue Or e.KeyCode = Keys.PrintScreen Then
                doCapture()
            End If
            Exit Sub
        End If
        If captureRegion = 1 Then
            If e.KeyCode = Keys.Escape Then
                Cancel = True
                FinishCapture()
            End If
        End If
    End Sub
    Private Sub FinishCapture()
        If Capturing Then
            '  Rectangle(deskHdc, rect.X, rect.Y, rect.Width, rect.Height)
            DeleteObject(newpen)
            ReleaseDC(0, deskHdc)
            Capturing = False

            SystemParametersInfo(87, 0, 0, 2)
            acthook.isCapturing = False

            InvalidateRect(0, Nothing, 0)
            Threading.Thread.Sleep(5)
            If isCtrl Then
                PostMessage(HWND_BROADCAST, WM_KEYUP, VK_CONTROL, 0)
            End If
            If isAlt Then
                PostMessage(HWND_BROADCAST, WM_KEYUP, VK_MENU, 0)
            End If
            If isShift Then
                PostMessage(HWND_BROADCAST, WM_KEYUP, VK_SHIFT, 0)
            End If

            If Cancel Or winHwnd = IntPtr.Zero Then

                Me.Show()
            Else
                '   MsgBox(winHwnd)
                qcc = New QuickCaptureCore(QuickCaptureCore.CaptureRegionEnum.WinOrCtl, winHwnd)
                Dim bmp As Bitmap = qcc.Capture
                If viewForm Is Nothing Then
                    viewForm = New ViewFrm(bmp, savepath, ImgFormat)
                Else
                    viewForm.changeBmp(bmp, savepath, ImgFormat)
                End If
                If saveoption = 1 Then
                    viewForm.Show()
                    viewForm.TopMost = True
                ElseIf saveoption = 0 Then
                    Try
                        viewForm.SaveFile()
                    Catch ex As Exception
                        MsgBox("保存失败！" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "提示")
                    End Try
                ElseIf saveoption = 2 Then
                    My.Computer.Clipboard.SetImage(bmp)
                    QuickCaptureNtf.ShowBalloonTip(1, String.Empty, "图片已复制到剪切板", ToolTipIcon.Info)
                End If
            End If
        End If
    End Sub


    Private Sub BtnBegin_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBegin.MouseEnter
        BtnBegin.ForeColor = Color.Red
    End Sub

    Private Sub BtnBegin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBegin.MouseLeave
        BtnBegin.ForeColor = Color.DarkBlue
    End Sub

    Private Sub RBtnTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnTop.CheckedChanged
        captureRegion = 2 '当前活动窗体
    End Sub




    Private Sub RBtnWinCtl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnWinCtl.CheckedChanged
        captureRegion = 1 '选择窗体或控件
    End Sub

    Private Sub RBtnDesk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnDesk.CheckedChanged
        captureRegion = 3 '全部桌面
    End Sub


    Private Sub RBtnSelect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnSelect.CheckedChanged
        captureRegion = 0 '选择区域
    End Sub

    Private Sub 开始捕获ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 开始捕获ToolStripMenuItem.Click
        doCapture()
    End Sub

    Private Sub 显示设置ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 显示设置ToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub RBDesktop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBDesktop.CheckedChanged
        savepath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)

    End Sub

    Private Sub RBUser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBUser.CheckedChanged
        SavePathTxt.Enabled = True
        SavePathTxt.Text = savepath
    End Sub

    

 


    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        reg = My.Computer.Registry.CurrentUser
        reg = reg.OpenSubKey("Software\QuickCapture", True)
        If reg Is Nothing Then
            reg = My.Computer.Registry.CurrentUser
            reg = reg.CreateSubKey("Software\QuickCapture")
        End If
        saveReg()
        reg.Close()
        MsgBox("保存成功!", MsgBoxStyle.Information, "提示")
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        exitApp()
    End Sub

    Private Sub BtnExit_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnExit.MouseEnter
        BtnExit.ForeColor = Color.Red
    End Sub

    Private Sub BtnExit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnExit.MouseLeave
        BtnExit.ForeColor = Color.DarkBlue
    End Sub

    Private Sub RBpng_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBpng.CheckedChanged
        ImgFormat = 2
    End Sub

    Private Sub RBjpg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBjpg.CheckedChanged
        ImgFormat = 1
    End Sub

    Private Sub RBgif_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBgif.CheckedChanged
        ImgFormat = 3
    End Sub

    Private Sub RBbmp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBbmp.CheckedChanged
        ImgFormat = 0
    End Sub

    Private Sub RBview_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBview.CheckedChanged
        saveoption = 0
    End Sub

    Private Sub RBAutoSave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBAutoSave.CheckedChanged
        saveoption = 1
    End Sub

    Private Sub QuickCaptureNtf_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles QuickCaptureNtf.MouseDoubleClick
        Me.Show()
    End Sub

   
    Private Sub RBCopy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBCopy.CheckedChanged
        saveoption = 2
    End Sub


    Private Sub CmbKeys_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CmbKeys.SelectedIndex = 0 Then
            key = 44
        Else
            key = CmbKeys.SelectedIndex
        End If
    End Sub


    Private Sub CBctrl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBctrl.CheckedChanged
        If CBctrl.Checked = True Then
            isCtrl = True
        Else
            isCtrl = False
        End If

    End Sub

    Private Sub CBshift_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBshift.CheckedChanged

        If CBshift.Checked = True Then
            isShift = True
        Else
            isShift = False
        End If

    End Sub

    Private Sub CBalt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBalt.CheckedChanged
        If CBalt.Checked = True Then
            isAlt = True
        Else
            isAlt = False
        End If

    End Sub

    Private Sub CBRunHide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBRunHide.CheckedChanged
        If CBRunHide.Checked = True Then
            hideAfterRun = True
        Else
            hideAfterRun = False
        End If
    End Sub

    Private Sub CBHide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBHide.CheckedChanged
        If CBHide.Checked = True Then
            hideWhenCapture = True
        Else
            hideWhenCapture = False
        End If
    End Sub

 

    Private Sub CBAutoRun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBAutoRun.CheckedChanged
        If isInAdmin Then
            Dim reg As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser

            reg = reg.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
            Try
                If CBAutoRun.Checked = True Then
                    reg.SetValue("QuickCapture", Application.ExecutablePath)
                    autoRun = True
                Else
                    reg.DeleteValue("QuickCapture")
                    autoRun = False
                End If
            Catch ex As Exception
                MsgBox("操作失败，可能被安全软件阻止！" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "QuickCapture")
                If CBAutoRun.Checked = True Then
                    CBAutoRun.Checked = False
                Else
                    CBAutoRun.Checked = True
                End If
            End Try
        Else
            MsgBox("本操作需要管理员权限，" & vbCrLf & "请在接下来的WindowsUAC对话框中选同意，并在安全软件的注册表修改提示中选同意", MsgBoxStyle.Information, "QuickCapture")
            Dim start As ProcessStartInfo = New ProcessStartInfo
            start.WorkingDirectory = Environment.CurrentDirectory
            start.FileName = My.Application.Info.AssemblyName & ".exe"
            start.Verb = "runas"
            Try
                Dim p As Process = Process.Start(start)
                exitApp()
            Catch ex As System.ComponentModel.Win32Exception
                MsgBox("用户拒绝提供权限，操作失败!", MsgBoxStyle.Information, "QuickCapture")
                If CBAutoRun.Checked = True Then
                    CBAutoRun.Checked = False
                Else
                    CBAutoRun.Checked = True
                End If
            End Try
        End If
    End Sub

  

    Private Sub LabelX4_Click(sender As Object, e As EventArgs) Handles LabelX4.Click
        System.Diagnostics.Process.Start("http://weibo.com/abeyuhang")
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub CBdelay_CheckedChanged(sender As Object, e As EventArgs) Handles CBdelay.CheckedChanged
        If CBdelay.Checked Then
            If delayNum = 0 Then
                delayNum = 1
            End If
            DelayNumTxt.Value = delayNum
            DelayNumTxt.Enabled = True
        Else
            delayNum = 0
            DelayNumTxt.Value = 0
            DelayNumTxt.Enabled = False
        End If
    End Sub

    Private Sub DelayNumTxt_ValueChanged(sender As Object, e As EventArgs) Handles DelayNumTxt.ValueChanged
        delayNum = DelayNumTxt.Value
    End Sub
End Class
