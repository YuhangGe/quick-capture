<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.QuickCaptureNtf = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.开始捕获ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.显示设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GPRegion = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RBtnSelect = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.RBtnWinCtl = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.RBtnTop = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.RBtnDesk = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelAutoRunImage = New System.Windows.Forms.Panel()
        Me.CBAutoRun = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CBHide = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CBRunHide = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.DelayNumTxt = New DevComponents.Editors.IntegerInput()
        Me.CBdelay = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.BtnExit = New DevComponents.DotNetBar.ButtonX()
        Me.BtnBegin = New DevComponents.DotNetBar.ButtonX()
        Me.GPSaveOption = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.SavePathTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.RBUser = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.RBDesktop = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RBpng = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.RBgif = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.RBjpg = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.RBbmp = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RBCopy = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.RBview = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.RBAutoSave = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GPKey = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CmbKeys = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CBalt = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CBshift = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CBctrl = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.GPRegion.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DelayNumTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPSaveOption.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GPKey.SuspendLayout()
        Me.SuspendLayout()
        '
        'QuickCaptureNtf
        '
        Me.QuickCaptureNtf.ContextMenuStrip = Me.ContextMenuStrip1
        Me.QuickCaptureNtf.Icon = CType(resources.GetObject("QuickCaptureNtf.Icon"), System.Drawing.Icon)
        Me.QuickCaptureNtf.Text = "QuickCapture"
        Me.QuickCaptureNtf.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.开始捕获ToolStripMenuItem, Me.显示设置ToolStripMenuItem, Me.ToolStripMenuItem1, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(123, 76)
        '
        '开始捕获ToolStripMenuItem
        '
        Me.开始捕获ToolStripMenuItem.Name = "开始捕获ToolStripMenuItem"
        Me.开始捕获ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.开始捕获ToolStripMenuItem.Text = "开始捕获"
        '
        '显示设置ToolStripMenuItem
        '
        Me.显示设置ToolStripMenuItem.Name = "显示设置ToolStripMenuItem"
        Me.显示设置ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.显示设置ToolStripMenuItem.Text = "显示设置"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(119, 6)
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.GPRegion)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.BtnExit)
        Me.PanelEx1.Controls.Add(Me.BtnBegin)
        Me.PanelEx1.Controls.Add(Me.GPSaveOption)
        Me.PanelEx1.Controls.Add(Me.GPKey)
        Me.PanelEx1.Controls.Add(Me.ReflectionLabel1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(502, 280)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'GPRegion
        '
        Me.GPRegion.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPRegion.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPRegion.Controls.Add(Me.RBtnSelect)
        Me.GPRegion.Controls.Add(Me.RBtnWinCtl)
        Me.GPRegion.Controls.Add(Me.RBtnTop)
        Me.GPRegion.Controls.Add(Me.RBtnDesk)
        Me.GPRegion.Location = New System.Drawing.Point(9, 147)
        Me.GPRegion.Margin = New System.Windows.Forms.Padding(2)
        Me.GPRegion.Name = "GPRegion"
        Me.GPRegion.Size = New System.Drawing.Size(121, 123)
        '
        '
        '
        Me.GPRegion.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GPRegion.Style.BackColorGradientAngle = 90
        Me.GPRegion.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GPRegion.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPRegion.Style.BorderBottomWidth = 1
        Me.GPRegion.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GPRegion.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPRegion.Style.BorderLeftWidth = 1
        Me.GPRegion.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPRegion.Style.BorderRightWidth = 1
        Me.GPRegion.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPRegion.Style.BorderTopWidth = 1
        Me.GPRegion.Style.CornerDiameter = 4
        Me.GPRegion.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GPRegion.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GPRegion.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GPRegion.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GPRegion.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GPRegion.TabIndex = 1
        Me.GPRegion.Text = "截取"
        '
        'RBtnSelect
        '
        '
        '
        '
        Me.RBtnSelect.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBtnSelect.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBtnSelect.Location = New System.Drawing.Point(9, 68)
        Me.RBtnSelect.Name = "RBtnSelect"
        Me.RBtnSelect.Size = New System.Drawing.Size(100, 23)
        Me.RBtnSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RBtnSelect.TabIndex = 7
        Me.RBtnSelect.Text = "任意区域"
        '
        'RBtnWinCtl
        '
        '
        '
        '
        Me.RBtnWinCtl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBtnWinCtl.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBtnWinCtl.Location = New System.Drawing.Point(9, 44)
        Me.RBtnWinCtl.Name = "RBtnWinCtl"
        Me.RBtnWinCtl.Size = New System.Drawing.Size(100, 23)
        Me.RBtnWinCtl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RBtnWinCtl.TabIndex = 6
        Me.RBtnWinCtl.Text = "应用程序"
        '
        'RBtnTop
        '
        '
        '
        '
        Me.RBtnTop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBtnTop.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBtnTop.Location = New System.Drawing.Point(9, 20)
        Me.RBtnTop.Name = "RBtnTop"
        Me.RBtnTop.Size = New System.Drawing.Size(100, 23)
        Me.RBtnTop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RBtnTop.TabIndex = 5
        Me.RBtnTop.Text = "活动窗体"
        '
        'RBtnDesk
        '
        '
        '
        '
        Me.RBtnDesk.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBtnDesk.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBtnDesk.Location = New System.Drawing.Point(9, 1)
        Me.RBtnDesk.Name = "RBtnDesk"
        Me.RBtnDesk.Size = New System.Drawing.Size(100, 18)
        Me.RBtnDesk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RBtnDesk.TabIndex = 4
        Me.RBtnDesk.Text = "整个桌面"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.PanelAutoRunImage)
        Me.GroupPanel1.Controls.Add(Me.CBAutoRun)
        Me.GroupPanel1.Controls.Add(Me.CBHide)
        Me.GroupPanel1.Controls.Add(Me.CBRunHide)
        Me.GroupPanel1.Controls.Add(Me.DelayNumTxt)
        Me.GroupPanel1.Controls.Add(Me.CBdelay)
        Me.GroupPanel1.Location = New System.Drawing.Point(135, 52)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(355, 82)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 14
        Me.GroupPanel1.Text = "程序选项"
        '
        'PanelAutoRunImage
        '
        Me.PanelAutoRunImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelAutoRunImage.Location = New System.Drawing.Point(24, 32)
        Me.PanelAutoRunImage.Name = "PanelAutoRunImage"
        Me.PanelAutoRunImage.Size = New System.Drawing.Size(21, 21)
        Me.PanelAutoRunImage.TabIndex = 16
        '
        'CBAutoRun
        '
        '
        '
        '
        Me.CBAutoRun.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CBAutoRun.Location = New System.Drawing.Point(8, 31)
        Me.CBAutoRun.Name = "CBAutoRun"
        Me.CBAutoRun.Size = New System.Drawing.Size(127, 24)
        Me.CBAutoRun.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CBAutoRun.TabIndex = 15
        Me.CBAutoRun.Text = "    开机自动启动"
        '
        'CBHide
        '
        '
        '
        '
        Me.CBHide.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CBHide.Location = New System.Drawing.Point(210, 8)
        Me.CBHide.Name = "CBHide"
        Me.CBHide.Size = New System.Drawing.Size(121, 19)
        Me.CBHide.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CBHide.TabIndex = 15
        Me.CBHide.Text = "截图时隐藏窗口"
        '
        'CBRunHide
        '
        '
        '
        '
        Me.CBRunHide.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CBRunHide.Location = New System.Drawing.Point(210, 29)
        Me.CBRunHide.Name = "CBRunHide"
        Me.CBRunHide.Size = New System.Drawing.Size(162, 24)
        Me.CBRunHide.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CBRunHide.TabIndex = 15
        Me.CBRunHide.Text = "启动后隐藏窗口"
        '
        'DelayNumTxt
        '
        '
        '
        '
        Me.DelayNumTxt.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DelayNumTxt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DelayNumTxt.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DelayNumTxt.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center
        Me.DelayNumTxt.Location = New System.Drawing.Point(110, 6)
        Me.DelayNumTxt.MaxValue = 300
        Me.DelayNumTxt.MinValue = 1
        Me.DelayNumTxt.Name = "DelayNumTxt"
        Me.DelayNumTxt.ShowUpDown = True
        Me.DelayNumTxt.Size = New System.Drawing.Size(61, 21)
        Me.DelayNumTxt.TabIndex = 13
        Me.DelayNumTxt.Value = 5
        '
        'CBdelay
        '
        '
        '
        '
        Me.CBdelay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CBdelay.Location = New System.Drawing.Point(8, 3)
        Me.CBdelay.Name = "CBdelay"
        Me.CBdelay.Size = New System.Drawing.Size(176, 28)
        Me.CBdelay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CBdelay.TabIndex = 2
        Me.CBdelay.Text = "延时截图(秒)："
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelX4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(219, 16)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(81, 23)
        Me.LabelX4.TabIndex = 13
        Me.LabelX4.Text = "@白羊座小葛"
        '
        'BtnExit
        '
        Me.BtnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnExit.Location = New System.Drawing.Point(428, 12)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(62, 29)
        Me.BtnExit.TabIndex = 12
        Me.BtnExit.Text = "<b>退出程序</b>"
        '
        'BtnBegin
        '
        Me.BtnBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnBegin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnBegin.Location = New System.Drawing.Point(348, 12)
        Me.BtnBegin.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBegin.Name = "BtnBegin"
        Me.BtnBegin.Size = New System.Drawing.Size(70, 30)
        Me.BtnBegin.TabIndex = 9
        Me.BtnBegin.Text = "<b>开始捕获</b>"
        '
        'GPSaveOption
        '
        Me.GPSaveOption.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPSaveOption.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.GPSaveOption.Controls.Add(Me.Panel5)
        Me.GPSaveOption.Controls.Add(Me.Panel3)
        Me.GPSaveOption.Controls.Add(Me.Panel2)
        Me.GPSaveOption.Location = New System.Drawing.Point(135, 146)
        Me.GPSaveOption.Margin = New System.Windows.Forms.Padding(2)
        Me.GPSaveOption.Name = "GPSaveOption"
        Me.GPSaveOption.Size = New System.Drawing.Size(355, 124)
        '
        '
        '
        Me.GPSaveOption.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GPSaveOption.Style.BackColorGradientAngle = 90
        Me.GPSaveOption.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GPSaveOption.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPSaveOption.Style.BorderBottomWidth = 1
        Me.GPSaveOption.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GPSaveOption.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPSaveOption.Style.BorderLeftWidth = 1
        Me.GPSaveOption.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPSaveOption.Style.BorderRightWidth = 1
        Me.GPSaveOption.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPSaveOption.Style.BorderTopWidth = 1
        Me.GPSaveOption.Style.CornerDiameter = 4
        Me.GPSaveOption.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GPSaveOption.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        '
        '
        '
        Me.GPSaveOption.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GPSaveOption.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GPSaveOption.TabIndex = 0
        Me.GPSaveOption.Text = "保存选项"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.SavePathTxt)
        Me.Panel5.Controls.Add(Me.RBUser)
        Me.Panel5.Controls.Add(Me.RBDesktop)
        Me.Panel5.Controls.Add(Me.LabelX3)
        Me.Panel5.Location = New System.Drawing.Point(6, 36)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(364, 31)
        Me.Panel5.TabIndex = 18
        '
        'SavePathTxt
        '
        '
        '
        '
        Me.SavePathTxt.Border.Class = "TextBoxBorder"
        Me.SavePathTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SavePathTxt.Location = New System.Drawing.Point(199, 4)
        Me.SavePathTxt.Name = "SavePathTxt"
        Me.SavePathTxt.Size = New System.Drawing.Size(132, 21)
        Me.SavePathTxt.TabIndex = 15
        '
        'RBUser
        '
        '
        '
        '
        Me.RBUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBUser.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBUser.Location = New System.Drawing.Point(134, 3)
        Me.RBUser.Name = "RBUser"
        Me.RBUser.Size = New System.Drawing.Size(204, 23)
        Me.RBUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RBUser.TabIndex = 14
        Me.RBUser.Text = "自定义："
        '
        'RBDesktop
        '
        '
        '
        '
        Me.RBDesktop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBDesktop.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBDesktop.Location = New System.Drawing.Point(75, 3)
        Me.RBDesktop.Name = "RBDesktop"
        Me.RBDesktop.Size = New System.Drawing.Size(53, 23)
        Me.RBDesktop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RBDesktop.TabIndex = 13
        Me.RBDesktop.Text = "桌面"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(4, 5)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 12
        Me.LabelX3.Text = "保存路径："
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RBpng)
        Me.Panel3.Controls.Add(Me.RBgif)
        Me.Panel3.Controls.Add(Me.RBjpg)
        Me.Panel3.Controls.Add(Me.RBbmp)
        Me.Panel3.Controls.Add(Me.LabelX1)
        Me.Panel3.Location = New System.Drawing.Point(6, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(354, 30)
        Me.Panel3.TabIndex = 17
        '
        'RBpng
        '
        '
        '
        '
        Me.RBpng.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBpng.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBpng.Location = New System.Drawing.Point(204, 4)
        Me.RBpng.Name = "RBpng"
        Me.RBpng.Size = New System.Drawing.Size(55, 23)
        Me.RBpng.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RBpng.TabIndex = 5
        Me.RBpng.Text = "PNG"
        '
        'RBgif
        '
        '
        '
        '
        Me.RBgif.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBgif.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBgif.Location = New System.Drawing.Point(276, 4)
        Me.RBgif.Name = "RBgif"
        Me.RBgif.Size = New System.Drawing.Size(55, 23)
        Me.RBgif.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RBgif.TabIndex = 4
        Me.RBgif.Text = "GIF"
        '
        'RBjpg
        '
        '
        '
        '
        Me.RBjpg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBjpg.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBjpg.Location = New System.Drawing.Point(136, 4)
        Me.RBjpg.Name = "RBjpg"
        Me.RBjpg.Size = New System.Drawing.Size(55, 23)
        Me.RBjpg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RBjpg.TabIndex = 3
        Me.RBjpg.Text = "JPG"
        '
        'RBbmp
        '
        '
        '
        '
        Me.RBbmp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBbmp.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBbmp.Location = New System.Drawing.Point(75, 4)
        Me.RBbmp.Name = "RBbmp"
        Me.RBbmp.Size = New System.Drawing.Size(55, 23)
        Me.RBbmp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RBbmp.TabIndex = 2
        Me.RBbmp.Text = "BMP"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(2, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(76, 19)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "保存格式："
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RBCopy)
        Me.Panel2.Controls.Add(Me.RBview)
        Me.Panel2.Controls.Add(Me.RBAutoSave)
        Me.Panel2.Controls.Add(Me.LabelX2)
        Me.Panel2.Location = New System.Drawing.Point(6, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(364, 30)
        Me.Panel2.TabIndex = 9
        '
        'RBCopy
        '
        '
        '
        '
        Me.RBCopy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBCopy.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBCopy.Location = New System.Drawing.Point(225, 3)
        Me.RBCopy.Name = "RBCopy"
        Me.RBCopy.Size = New System.Drawing.Size(106, 23)
        Me.RBCopy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RBCopy.TabIndex = 12
        Me.RBCopy.Text = "复制到剪贴板"
        '
        'RBview
        '
        '
        '
        '
        Me.RBview.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBview.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBview.Location = New System.Drawing.Point(75, 3)
        Me.RBview.Name = "RBview"
        Me.RBview.Size = New System.Drawing.Size(54, 23)
        Me.RBview.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RBview.TabIndex = 11
        Me.RBview.Text = "预览"
        '
        'RBAutoSave
        '
        '
        '
        '
        Me.RBAutoSave.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RBAutoSave.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RBAutoSave.Location = New System.Drawing.Point(134, 4)
        Me.RBAutoSave.Name = "RBAutoSave"
        Me.RBAutoSave.Size = New System.Drawing.Size(91, 23)
        Me.RBAutoSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RBAutoSave.TabIndex = 10
        Me.RBAutoSave.Text = "自动保存"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(4, 6)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(72, 21)
        Me.LabelX2.TabIndex = 9
        Me.LabelX2.Text = "截图完成："
        '
        'GPKey
        '
        Me.GPKey.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPKey.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPKey.Controls.Add(Me.CmbKeys)
        Me.GPKey.Controls.Add(Me.CBalt)
        Me.GPKey.Controls.Add(Me.CBshift)
        Me.GPKey.Controls.Add(Me.CBctrl)
        Me.GPKey.Location = New System.Drawing.Point(9, 52)
        Me.GPKey.Margin = New System.Windows.Forms.Padding(2)
        Me.GPKey.Name = "GPKey"
        Me.GPKey.Size = New System.Drawing.Size(121, 82)
        '
        '
        '
        Me.GPKey.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GPKey.Style.BackColorGradientAngle = 90
        Me.GPKey.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GPKey.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPKey.Style.BorderBottomWidth = 1
        Me.GPKey.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GPKey.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPKey.Style.BorderLeftWidth = 1
        Me.GPKey.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPKey.Style.BorderRightWidth = 1
        Me.GPKey.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPKey.Style.BorderTopWidth = 1
        Me.GPKey.Style.CornerDiameter = 4
        Me.GPKey.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GPKey.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        '
        '
        '
        Me.GPKey.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GPKey.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GPKey.TabIndex = 2
        Me.GPKey.Text = "快捷键"
        '
        'CmbKeys
        '
        Me.CmbKeys.DisplayMember = "Text"
        Me.CmbKeys.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbKeys.FormattingEnabled = True
        Me.CmbKeys.ItemHeight = 15
        Me.CmbKeys.Location = New System.Drawing.Point(54, 30)
        Me.CmbKeys.Name = "CmbKeys"
        Me.CmbKeys.Size = New System.Drawing.Size(60, 21)
        Me.CmbKeys.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmbKeys.TabIndex = 4
        '
        'CBalt
        '
        '
        '
        '
        Me.CBalt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CBalt.Location = New System.Drawing.Point(9, 30)
        Me.CBalt.Name = "CBalt"
        Me.CBalt.Size = New System.Drawing.Size(44, 23)
        Me.CBalt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CBalt.TabIndex = 3
        Me.CBalt.Text = "Alt"
        '
        'CBshift
        '
        '
        '
        '
        Me.CBshift.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CBshift.Location = New System.Drawing.Point(58, 4)
        Me.CBshift.Name = "CBshift"
        Me.CBshift.Size = New System.Drawing.Size(53, 23)
        Me.CBshift.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CBshift.TabIndex = 2
        Me.CBshift.Text = "Shift"
        '
        'CBctrl
        '
        '
        '
        '
        Me.CBctrl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CBctrl.Location = New System.Drawing.Point(9, 4)
        Me.CBctrl.Name = "CBctrl"
        Me.CBctrl.Size = New System.Drawing.Size(49, 23)
        Me.CBctrl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CBctrl.TabIndex = 1
        Me.CBctrl.Text = "Ctrl"
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("宋体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(9, 2)
        Me.ReflectionLabel1.Margin = New System.Windows.Forms.Padding(2)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(148, 39)
        Me.ReflectionLabel1.TabIndex = 8
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>Quick</i><font color=""#B02B2C"">Capture</font></font></b>"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 280)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuickCapture"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.GPRegion.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.DelayNumTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPSaveOption.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GPKey.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QuickCaptureNtf As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GPSaveOption As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GPRegion As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents GPKey As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BtnBegin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 开始捕获ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 显示设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CBdelay As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents CBshift As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CBctrl As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CBalt As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents DelayNumTxt As DevComponents.Editors.IntegerInput
    Friend WithEvents CBAutoRun As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CBHide As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CBRunHide As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RBtnSelect As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RBtnWinCtl As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RBtnTop As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RBtnDesk As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RBDesktop As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents RBCopy As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RBview As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RBAutoSave As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RBUser As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents SavePathTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents RBbmp As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RBpng As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RBgif As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RBjpg As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PanelAutoRunImage As System.Windows.Forms.Panel
    Friend WithEvents CmbKeys As DevComponents.DotNetBar.Controls.ComboBoxEx

End Class
