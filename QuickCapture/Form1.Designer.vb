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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.QuickCaptureNtf = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.开始捕获ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.显示设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.BtnExit = New DevComponents.DotNetBar.ButtonX
        Me.GPFormat = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.RBgif = New System.Windows.Forms.RadioButton
        Me.RBpng = New System.Windows.Forms.RadioButton
        Me.RBjpg = New System.Windows.Forms.RadioButton
        Me.RBbmp = New System.Windows.Forms.RadioButton
        Me.BtnBegin = New DevComponents.DotNetBar.ButtonX
        Me.GPSaveOption = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.CBRunHide = New System.Windows.Forms.CheckBox
        Me.CBAutoRun = New System.Windows.Forms.CheckBox
        Me.CBHide = New System.Windows.Forms.CheckBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RBCopy = New System.Windows.Forms.RadioButton
        Me.RBAutoSave = New System.Windows.Forms.RadioButton
        Me.RBview = New System.Windows.Forms.RadioButton
        Me.GPKey = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.CmbKeys = New System.Windows.Forms.ComboBox
        Me.CBshift = New System.Windows.Forms.CheckBox
        Me.CBalt = New System.Windows.Forms.CheckBox
        Me.CBctrl = New System.Windows.Forms.CheckBox
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.GPSavePath = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.CrumbBar1 = New DevComponents.DotNetBar.CrumbBar
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.RBUser = New System.Windows.Forms.RadioButton
        Me.RBDesktop = New System.Windows.Forms.RadioButton
        Me.GPRegion = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.RBtnSelect = New System.Windows.Forms.RadioButton
        Me.RBtnWinCtl = New System.Windows.Forms.RadioButton
        Me.RBtnTop = New System.Windows.Forms.RadioButton
        Me.RBtnDesk = New System.Windows.Forms.RadioButton
        Me.ContextMenuStrip1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.GPFormat.SuspendLayout()
        Me.GPSaveOption.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GPKey.SuspendLayout()
        Me.GPSavePath.SuspendLayout()
        Me.GPRegion.SuspendLayout()
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
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.开始捕获ToolStripMenuItem, Me.显示设置ToolStripMenuItem, Me.关于ToolStripMenuItem, Me.ToolStripMenuItem1, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(139, 106)
        '
        '开始捕获ToolStripMenuItem
        '
        Me.开始捕获ToolStripMenuItem.Name = "开始捕获ToolStripMenuItem"
        Me.开始捕获ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.开始捕获ToolStripMenuItem.Text = "开始捕获"
        '
        '显示设置ToolStripMenuItem
        '
        Me.显示设置ToolStripMenuItem.Name = "显示设置ToolStripMenuItem"
        Me.显示设置ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.显示设置ToolStripMenuItem.Text = "显示设置"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(135, 6)
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.BtnExit)
        Me.PanelEx1.Controls.Add(Me.GPFormat)
        Me.PanelEx1.Controls.Add(Me.BtnBegin)
        Me.PanelEx1.Controls.Add(Me.GPSaveOption)
        Me.PanelEx1.Controls.Add(Me.GPKey)
        Me.PanelEx1.Controls.Add(Me.ReflectionLabel1)
        Me.PanelEx1.Controls.Add(Me.GPSavePath)
        Me.PanelEx1.Controls.Add(Me.GPRegion)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(637, 315)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'BtnExit
        '
        Me.BtnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnExit.Location = New System.Drawing.Point(521, 14)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(83, 36)
        Me.BtnExit.TabIndex = 12
        Me.BtnExit.Text = "<b>退出程序</b>"
        '
        'GPFormat
        '
        Me.GPFormat.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPFormat.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPFormat.Controls.Add(Me.RBgif)
        Me.GPFormat.Controls.Add(Me.RBpng)
        Me.GPFormat.Controls.Add(Me.RBjpg)
        Me.GPFormat.Controls.Add(Me.RBbmp)
        Me.GPFormat.Location = New System.Drawing.Point(12, 191)
        Me.GPFormat.Name = "GPFormat"
        Me.GPFormat.Size = New System.Drawing.Size(137, 116)
        '
        '
        '
        Me.GPFormat.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GPFormat.Style.BackColorGradientAngle = 90
        Me.GPFormat.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GPFormat.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPFormat.Style.BorderBottomWidth = 1
        Me.GPFormat.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GPFormat.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPFormat.Style.BorderLeftWidth = 1
        Me.GPFormat.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPFormat.Style.BorderRightWidth = 1
        Me.GPFormat.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPFormat.Style.BorderTopWidth = 1
        Me.GPFormat.Style.CornerDiameter = 4
        Me.GPFormat.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GPFormat.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GPFormat.TabIndex = 11
        Me.GPFormat.Text = "图片格式"
        '
        'RBgif
        '
        Me.RBgif.AutoSize = True
        Me.RBgif.Location = New System.Drawing.Point(73, 52)
        Me.RBgif.Name = "RBgif"
        Me.RBgif.Size = New System.Drawing.Size(52, 19)
        Me.RBgif.TabIndex = 3
        Me.RBgif.TabStop = True
        Me.RBgif.Text = "GIF"
        Me.RBgif.UseVisualStyleBackColor = True
        '
        'RBpng
        '
        Me.RBpng.AutoSize = True
        Me.RBpng.Location = New System.Drawing.Point(3, 52)
        Me.RBpng.Name = "RBpng"
        Me.RBpng.Size = New System.Drawing.Size(52, 19)
        Me.RBpng.TabIndex = 2
        Me.RBpng.TabStop = True
        Me.RBpng.Text = "PNG"
        Me.RBpng.UseVisualStyleBackColor = True
        '
        'RBjpg
        '
        Me.RBjpg.AutoSize = True
        Me.RBjpg.Location = New System.Drawing.Point(73, 17)
        Me.RBjpg.Name = "RBjpg"
        Me.RBjpg.Size = New System.Drawing.Size(52, 19)
        Me.RBjpg.TabIndex = 1
        Me.RBjpg.TabStop = True
        Me.RBjpg.Text = "JPG"
        Me.RBjpg.UseVisualStyleBackColor = True
        '
        'RBbmp
        '
        Me.RBbmp.AutoSize = True
        Me.RBbmp.Location = New System.Drawing.Point(3, 17)
        Me.RBbmp.Name = "RBbmp"
        Me.RBbmp.Size = New System.Drawing.Size(52, 19)
        Me.RBbmp.TabIndex = 0
        Me.RBbmp.TabStop = True
        Me.RBbmp.Text = "BMP"
        Me.RBbmp.UseVisualStyleBackColor = True
        '
        'BtnBegin
        '
        Me.BtnBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnBegin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnBegin.Location = New System.Drawing.Point(400, 13)
        Me.BtnBegin.Name = "BtnBegin"
        Me.BtnBegin.Size = New System.Drawing.Size(93, 37)
        Me.BtnBegin.TabIndex = 9
        Me.BtnBegin.Text = "<b>开始捕获</b>"
        '
        'GPSaveOption
        '
        Me.GPSaveOption.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPSaveOption.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.GPSaveOption.Controls.Add(Me.CBRunHide)
        Me.GPSaveOption.Controls.Add(Me.CBAutoRun)
        Me.GPSaveOption.Controls.Add(Me.CBHide)
        Me.GPSaveOption.Controls.Add(Me.Panel2)
        Me.GPSaveOption.Location = New System.Drawing.Point(155, 191)
        Me.GPSaveOption.Name = "GPSaveOption"
        Me.GPSaveOption.Size = New System.Drawing.Size(470, 116)
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
        Me.GPSaveOption.TabIndex = 0
        Me.GPSaveOption.Text = "保存选项"
        '
        'CBRunHide
        '
        Me.CBRunHide.AutoSize = True
        Me.CBRunHide.Font = New System.Drawing.Font("宋体", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CBRunHide.Location = New System.Drawing.Point(30, 52)
        Me.CBRunHide.Name = "CBRunHide"
        Me.CBRunHide.Size = New System.Drawing.Size(115, 21)
        Me.CBRunHide.TabIndex = 12
        Me.CBRunHide.Text = "启动后隐藏"
        Me.CBRunHide.UseVisualStyleBackColor = True
        '
        'CBAutoRun
        '
        Me.CBAutoRun.AutoSize = True
        Me.CBAutoRun.Font = New System.Drawing.Font("宋体", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CBAutoRun.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CBAutoRun.Location = New System.Drawing.Point(296, 52)
        Me.CBAutoRun.Name = "CBAutoRun"
        Me.CBAutoRun.Size = New System.Drawing.Size(150, 21)
        Me.CBAutoRun.TabIndex = 11
        Me.CBAutoRun.Text = "  开机自动启动"
        Me.CBAutoRun.UseVisualStyleBackColor = True
        '
        'CBHide
        '
        Me.CBHide.AutoSize = True
        Me.CBHide.Font = New System.Drawing.Font("宋体", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CBHide.Location = New System.Drawing.Point(167, 52)
        Me.CBHide.Name = "CBHide"
        Me.CBHide.Size = New System.Drawing.Size(115, 21)
        Me.CBHide.TabIndex = 10
        Me.CBHide.Text = "截图时隐藏"
        Me.CBHide.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(443, 33)
        Me.Panel2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "截图后："
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RBCopy)
        Me.Panel1.Controls.Add(Me.RBAutoSave)
        Me.Panel1.Controls.Add(Me.RBview)
        Me.Panel1.Location = New System.Drawing.Point(82, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 24)
        Me.Panel1.TabIndex = 8
        '
        'RBCopy
        '
        Me.RBCopy.AutoSize = True
        Me.RBCopy.Location = New System.Drawing.Point(237, 2)
        Me.RBCopy.Name = "RBCopy"
        Me.RBCopy.Size = New System.Drawing.Size(118, 19)
        Me.RBCopy.TabIndex = 8
        Me.RBCopy.TabStop = True
        Me.RBCopy.Text = "复制到剪切板"
        Me.RBCopy.UseVisualStyleBackColor = True
        '
        'RBAutoSave
        '
        Me.RBAutoSave.AutoSize = True
        Me.RBAutoSave.Checked = True
        Me.RBAutoSave.Location = New System.Drawing.Point(15, 3)
        Me.RBAutoSave.Name = "RBAutoSave"
        Me.RBAutoSave.Size = New System.Drawing.Size(88, 19)
        Me.RBAutoSave.TabIndex = 6
        Me.RBAutoSave.TabStop = True
        Me.RBAutoSave.Text = "自动保存"
        Me.RBAutoSave.UseVisualStyleBackColor = True
        '
        'RBview
        '
        Me.RBview.AutoSize = True
        Me.RBview.Location = New System.Drawing.Point(125, 2)
        Me.RBview.Name = "RBview"
        Me.RBview.Size = New System.Drawing.Size(88, 19)
        Me.RBview.TabIndex = 7
        Me.RBview.Text = "预览图片"
        Me.RBview.UseVisualStyleBackColor = True
        '
        'GPKey
        '
        Me.GPKey.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPKey.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPKey.Controls.Add(Me.CmbKeys)
        Me.GPKey.Controls.Add(Me.CBshift)
        Me.GPKey.Controls.Add(Me.CBalt)
        Me.GPKey.Controls.Add(Me.CBctrl)
        Me.GPKey.Location = New System.Drawing.Point(435, 59)
        Me.GPKey.Name = "GPKey"
        Me.GPKey.Size = New System.Drawing.Size(190, 126)
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
        Me.GPKey.TabIndex = 2
        Me.GPKey.Text = "快捷键"
        '
        'CmbKeys
        '
        Me.CmbKeys.FormattingEnabled = True
        Me.CmbKeys.Location = New System.Drawing.Point(67, 48)
        Me.CmbKeys.MaxDropDownItems = 5
        Me.CmbKeys.Name = "CmbKeys"
        Me.CmbKeys.Size = New System.Drawing.Size(120, 23)
        Me.CmbKeys.TabIndex = 6
        '
        'CBshift
        '
        Me.CBshift.AutoSize = True
        Me.CBshift.Location = New System.Drawing.Point(96, 18)
        Me.CBshift.Name = "CBshift"
        Me.CBshift.Size = New System.Drawing.Size(85, 19)
        Me.CBshift.TabIndex = 5
        Me.CBshift.Text = "Shift +"
        Me.CBshift.UseVisualStyleBackColor = True
        '
        'CBalt
        '
        Me.CBalt.AutoSize = True
        Me.CBalt.Location = New System.Drawing.Point(0, 52)
        Me.CBalt.Name = "CBalt"
        Me.CBalt.Size = New System.Drawing.Size(69, 19)
        Me.CBalt.TabIndex = 4
        Me.CBalt.Text = "Alt +"
        Me.CBalt.UseVisualStyleBackColor = True
        '
        'CBctrl
        '
        Me.CBctrl.AutoSize = True
        Me.CBctrl.Location = New System.Drawing.Point(0, 18)
        Me.CBctrl.Name = "CBctrl"
        Me.CBctrl.Size = New System.Drawing.Size(85, 19)
        Me.CBctrl.TabIndex = 3
        Me.CBctrl.Text = "Ctrl  +"
        Me.CBctrl.UseVisualStyleBackColor = True
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.Font = New System.Drawing.Font("宋体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(12, 3)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(198, 49)
        Me.ReflectionLabel1.TabIndex = 8
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>Quick</i><font color=""#B02B2C"">Capture</font></font></b>"
        '
        'GPSavePath
        '
        Me.GPSavePath.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPSavePath.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.GPSavePath.Controls.Add(Me.CrumbBar1)
        Me.GPSavePath.Controls.Add(Me.TextBox1)
        Me.GPSavePath.Controls.Add(Me.RBUser)
        Me.GPSavePath.Controls.Add(Me.RBDesktop)
        Me.GPSavePath.Location = New System.Drawing.Point(155, 59)
        Me.GPSavePath.Name = "GPSavePath"
        Me.GPSavePath.Size = New System.Drawing.Size(274, 126)
        '
        '
        '
        Me.GPSavePath.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GPSavePath.Style.BackColorGradientAngle = 90
        Me.GPSavePath.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GPSavePath.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPSavePath.Style.BorderBottomWidth = 1
        Me.GPSavePath.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GPSavePath.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPSavePath.Style.BorderLeftWidth = 1
        Me.GPSavePath.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPSavePath.Style.BorderRightWidth = 1
        Me.GPSavePath.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPSavePath.Style.BorderTopWidth = 1
        Me.GPSavePath.Style.CornerDiameter = 4
        Me.GPSavePath.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GPSavePath.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GPSavePath.TabIndex = 7
        Me.GPSavePath.Text = "保存到："
        '
        'CrumbBar1
        '
        '
        '
        '
        Me.CrumbBar1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CrumbBar1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.CrumbBar1.BackgroundStyle.BorderBottomWidth = 1
        Me.CrumbBar1.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CrumbBar1.BackgroundStyle.BorderColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.CrumbBar1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.CrumbBar1.BackgroundStyle.BorderLeftWidth = 1
        Me.CrumbBar1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.CrumbBar1.BackgroundStyle.BorderRightWidth = 1
        Me.CrumbBar1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.CrumbBar1.BackgroundStyle.BorderTopWidth = 1
        Me.CrumbBar1.Location = New System.Drawing.Point(3, 67)
        Me.CrumbBar1.Name = "CrumbBar1"
        Me.CrumbBar1.Size = New System.Drawing.Size(256, 25)
        Me.CrumbBar1.TabIndex = 11
        Me.CrumbBar1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(256, 25)
        Me.TextBox1.TabIndex = 10
        '
        'RBUser
        '
        Me.RBUser.AutoSize = True
        Me.RBUser.Location = New System.Drawing.Point(3, 42)
        Me.RBUser.Name = "RBUser"
        Me.RBUser.Size = New System.Drawing.Size(111, 19)
        Me.RBUser.TabIndex = 8
        Me.RBUser.TabStop = True
        Me.RBUser.Text = "自定义目录:"
        Me.RBUser.UseVisualStyleBackColor = True
        '
        'RBDesktop
        '
        Me.RBDesktop.AutoSize = True
        Me.RBDesktop.Location = New System.Drawing.Point(3, 17)
        Me.RBDesktop.Name = "RBDesktop"
        Me.RBDesktop.Size = New System.Drawing.Size(58, 19)
        Me.RBDesktop.TabIndex = 7
        Me.RBDesktop.TabStop = True
        Me.RBDesktop.Text = "桌面"
        Me.RBDesktop.UseVisualStyleBackColor = True
        '
        'GPRegion
        '
        Me.GPRegion.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPRegion.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPRegion.Controls.Add(Me.RBtnSelect)
        Me.GPRegion.Controls.Add(Me.RBtnWinCtl)
        Me.GPRegion.Controls.Add(Me.RBtnTop)
        Me.GPRegion.Controls.Add(Me.RBtnDesk)
        Me.GPRegion.Location = New System.Drawing.Point(12, 58)
        Me.GPRegion.Name = "GPRegion"
        Me.GPRegion.Size = New System.Drawing.Size(137, 127)
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
        Me.GPRegion.TabIndex = 1
        Me.GPRegion.Text = "截取"
        '
        'RBtnSelect
        '
        Me.RBtnSelect.AutoSize = True
        Me.RBtnSelect.Location = New System.Drawing.Point(22, 74)
        Me.RBtnSelect.Name = "RBtnSelect"
        Me.RBtnSelect.Size = New System.Drawing.Size(88, 19)
        Me.RBtnSelect.TabIndex = 3
        Me.RBtnSelect.Text = "选择区域"
        Me.RBtnSelect.UseVisualStyleBackColor = True
        '
        'RBtnWinCtl
        '
        Me.RBtnWinCtl.AutoSize = True
        Me.RBtnWinCtl.Location = New System.Drawing.Point(22, 52)
        Me.RBtnWinCtl.Name = "RBtnWinCtl"
        Me.RBtnWinCtl.Size = New System.Drawing.Size(103, 19)
        Me.RBtnWinCtl.TabIndex = 2
        Me.RBtnWinCtl.Text = "窗体或控件"
        Me.RBtnWinCtl.UseVisualStyleBackColor = True
        '
        'RBtnTop
        '
        Me.RBtnTop.AutoSize = True
        Me.RBtnTop.Location = New System.Drawing.Point(22, 28)
        Me.RBtnTop.Name = "RBtnTop"
        Me.RBtnTop.Size = New System.Drawing.Size(88, 19)
        Me.RBtnTop.TabIndex = 1
        Me.RBtnTop.Text = "活动窗体"
        Me.RBtnTop.UseVisualStyleBackColor = True
        '
        'RBtnDesk
        '
        Me.RBtnDesk.AutoSize = True
        Me.RBtnDesk.Checked = True
        Me.RBtnDesk.Location = New System.Drawing.Point(22, 3)
        Me.RBtnDesk.Name = "RBtnDesk"
        Me.RBtnDesk.Size = New System.Drawing.Size(88, 19)
        Me.RBtnDesk.TabIndex = 0
        Me.RBtnDesk.TabStop = True
        Me.RBtnDesk.Text = "整个桌面"
        Me.RBtnDesk.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 315)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuickCapture"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.GPFormat.ResumeLayout(False)
        Me.GPFormat.PerformLayout()
        Me.GPSaveOption.ResumeLayout(False)
        Me.GPSaveOption.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GPKey.ResumeLayout(False)
        Me.GPKey.PerformLayout()
        Me.GPSavePath.ResumeLayout(False)
        Me.GPSavePath.PerformLayout()
        Me.GPRegion.ResumeLayout(False)
        Me.GPRegion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QuickCaptureNtf As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GPSaveOption As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RBAutoSave As System.Windows.Forms.RadioButton
    Friend WithEvents RBview As System.Windows.Forms.RadioButton
    Friend WithEvents GPSavePath As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GPRegion As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RBtnSelect As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnWinCtl As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnTop As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnDesk As System.Windows.Forms.RadioButton
    Friend WithEvents RBUser As System.Windows.Forms.RadioButton
    Friend WithEvents RBDesktop As System.Windows.Forms.RadioButton
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents GPKey As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BtnBegin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents 关于ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 开始捕获ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 显示设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CrumbBar1 As DevComponents.DotNetBar.CrumbBar
    Friend WithEvents GPFormat As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BtnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RBgif As System.Windows.Forms.RadioButton
    Friend WithEvents RBpng As System.Windows.Forms.RadioButton
    Friend WithEvents RBjpg As System.Windows.Forms.RadioButton
    Friend WithEvents RBbmp As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CBHide As System.Windows.Forms.CheckBox
    Friend WithEvents CBAutoRun As System.Windows.Forms.CheckBox
    Friend WithEvents RBCopy As System.Windows.Forms.RadioButton
    Friend WithEvents CBRunHide As System.Windows.Forms.CheckBox
    Friend WithEvents CmbKeys As System.Windows.Forms.ComboBox
    Friend WithEvents CBshift As System.Windows.Forms.CheckBox
    Friend WithEvents CBalt As System.Windows.Forms.CheckBox
    Friend WithEvents CBctrl As System.Windows.Forms.CheckBox

End Class
