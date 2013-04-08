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
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.BtnExit = New DevComponents.DotNetBar.ButtonX()
        Me.BtnBegin = New DevComponents.DotNetBar.ButtonX()
        Me.GPSaveOption = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CBRunHide = New System.Windows.Forms.CheckBox()
        Me.CBAutoRun = New System.Windows.Forms.CheckBox()
        Me.CBHide = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RBCopy = New System.Windows.Forms.RadioButton()
        Me.RBAutoSave = New System.Windows.Forms.RadioButton()
        Me.RBview = New System.Windows.Forms.RadioButton()
        Me.GPKey = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.CrumbBar1 = New DevComponents.DotNetBar.CrumbBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RBUser = New System.Windows.Forms.RadioButton()
        Me.RBDesktop = New System.Windows.Forms.RadioButton()
        Me.GPRegion = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RBtnSelect = New System.Windows.Forms.RadioButton()
        Me.RBtnWinCtl = New System.Windows.Forms.RadioButton()
        Me.RBtnTop = New System.Windows.Forms.RadioButton()
        Me.RBtnDesk = New System.Windows.Forms.RadioButton()
        Me.RBgif = New System.Windows.Forms.RadioButton()
        Me.RBpng = New System.Windows.Forms.RadioButton()
        Me.RBjpg = New System.Windows.Forms.RadioButton()
        Me.RBbmp = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CheckBoxX1 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CheckBoxX2 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX3 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX4 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.GPSaveOption.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GPKey.SuspendLayout()
        Me.GPRegion.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
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
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(123, 98)
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
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.关于ToolStripMenuItem.Text = "关于"
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
        'CBRunHide
        '
        Me.CBRunHide.AutoSize = True
        Me.CBRunHide.Font = New System.Drawing.Font("宋体", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CBRunHide.Location = New System.Drawing.Point(9, 8)
        Me.CBRunHide.Margin = New System.Windows.Forms.Padding(2)
        Me.CBRunHide.Name = "CBRunHide"
        Me.CBRunHide.Size = New System.Drawing.Size(124, 18)
        Me.CBRunHide.TabIndex = 12
        Me.CBRunHide.Text = "启动后隐藏窗口"
        Me.CBRunHide.UseVisualStyleBackColor = True
        '
        'CBAutoRun
        '
        Me.CBAutoRun.AutoSize = True
        Me.CBAutoRun.Font = New System.Drawing.Font("宋体", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CBAutoRun.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CBAutoRun.Location = New System.Drawing.Point(210, 32)
        Me.CBAutoRun.Margin = New System.Windows.Forms.Padding(2)
        Me.CBAutoRun.Name = "CBAutoRun"
        Me.CBAutoRun.Size = New System.Drawing.Size(124, 18)
        Me.CBAutoRun.TabIndex = 11
        Me.CBAutoRun.Text = "  开机自动启动"
        Me.CBAutoRun.UseVisualStyleBackColor = True
        '
        'CBHide
        '
        Me.CBHide.AutoSize = True
        Me.CBHide.Font = New System.Drawing.Font("宋体", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CBHide.Location = New System.Drawing.Point(210, 8)
        Me.CBHide.Margin = New System.Windows.Forms.Padding(2)
        Me.CBHide.Name = "CBHide"
        Me.CBHide.Size = New System.Drawing.Size(124, 18)
        Me.CBHide.TabIndex = 10
        Me.CBHide.Text = "截图时隐藏窗口"
        Me.CBHide.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LabelX2)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(6, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(364, 30)
        Me.Panel2.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RBCopy)
        Me.Panel1.Controls.Add(Me.RBAutoSave)
        Me.Panel1.Controls.Add(Me.RBview)
        Me.Panel1.Location = New System.Drawing.Point(68, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 19)
        Me.Panel1.TabIndex = 8
        '
        'RBCopy
        '
        Me.RBCopy.AutoSize = True
        Me.RBCopy.Location = New System.Drawing.Point(164, 2)
        Me.RBCopy.Margin = New System.Windows.Forms.Padding(2)
        Me.RBCopy.Name = "RBCopy"
        Me.RBCopy.Size = New System.Drawing.Size(95, 16)
        Me.RBCopy.TabIndex = 8
        Me.RBCopy.TabStop = True
        Me.RBCopy.Text = "复制到剪切板"
        Me.RBCopy.UseVisualStyleBackColor = True
        '
        'RBAutoSave
        '
        Me.RBAutoSave.AutoSize = True
        Me.RBAutoSave.Checked = True
        Me.RBAutoSave.Location = New System.Drawing.Point(11, 2)
        Me.RBAutoSave.Margin = New System.Windows.Forms.Padding(2)
        Me.RBAutoSave.Name = "RBAutoSave"
        Me.RBAutoSave.Size = New System.Drawing.Size(71, 16)
        Me.RBAutoSave.TabIndex = 6
        Me.RBAutoSave.TabStop = True
        Me.RBAutoSave.Text = "自动保存"
        Me.RBAutoSave.UseVisualStyleBackColor = True
        '
        'RBview
        '
        Me.RBview.AutoSize = True
        Me.RBview.Location = New System.Drawing.Point(86, 2)
        Me.RBview.Margin = New System.Windows.Forms.Padding(2)
        Me.RBview.Name = "RBview"
        Me.RBview.Size = New System.Drawing.Size(71, 16)
        Me.RBview.TabIndex = 7
        Me.RBview.Text = "预览图片"
        Me.RBview.UseVisualStyleBackColor = True
        '
        'GPKey
        '
        Me.GPKey.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPKey.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPKey.Controls.Add(Me.CheckBoxX4)
        Me.GPKey.Controls.Add(Me.CheckBoxX3)
        Me.GPKey.Controls.Add(Me.CheckBoxX2)
        Me.GPKey.Controls.Add(Me.TextBoxX1)
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
        Me.CrumbBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CrumbBar1.ContainerControlProcessDialogKey = True
        Me.CrumbBar1.Location = New System.Drawing.Point(197, 5)
        Me.CrumbBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.CrumbBar1.Name = "CrumbBar1"
        Me.CrumbBar1.Size = New System.Drawing.Size(130, 20)
        Me.CrumbBar1.TabIndex = 11
        Me.CrumbBar1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(197, 5)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(130, 21)
        Me.TextBox1.TabIndex = 10
        '
        'RBUser
        '
        Me.RBUser.AutoSize = True
        Me.RBUser.Location = New System.Drawing.Point(134, 7)
        Me.RBUser.Margin = New System.Windows.Forms.Padding(2)
        Me.RBUser.Name = "RBUser"
        Me.RBUser.Size = New System.Drawing.Size(65, 16)
        Me.RBUser.TabIndex = 8
        Me.RBUser.TabStop = True
        Me.RBUser.Text = "自定义:"
        Me.RBUser.UseVisualStyleBackColor = True
        '
        'RBDesktop
        '
        Me.RBDesktop.AutoSize = True
        Me.RBDesktop.Location = New System.Drawing.Point(79, 6)
        Me.RBDesktop.Margin = New System.Windows.Forms.Padding(2)
        Me.RBDesktop.Name = "RBDesktop"
        Me.RBDesktop.Size = New System.Drawing.Size(47, 16)
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
        Me.RBtnSelect.AutoSize = True
        Me.RBtnSelect.Location = New System.Drawing.Point(9, 74)
        Me.RBtnSelect.Margin = New System.Windows.Forms.Padding(2)
        Me.RBtnSelect.Name = "RBtnSelect"
        Me.RBtnSelect.Size = New System.Drawing.Size(71, 16)
        Me.RBtnSelect.TabIndex = 3
        Me.RBtnSelect.Text = "选择区域"
        Me.RBtnSelect.UseVisualStyleBackColor = True
        '
        'RBtnWinCtl
        '
        Me.RBtnWinCtl.AutoSize = True
        Me.RBtnWinCtl.Location = New System.Drawing.Point(9, 48)
        Me.RBtnWinCtl.Margin = New System.Windows.Forms.Padding(2)
        Me.RBtnWinCtl.Name = "RBtnWinCtl"
        Me.RBtnWinCtl.Size = New System.Drawing.Size(83, 16)
        Me.RBtnWinCtl.TabIndex = 2
        Me.RBtnWinCtl.Text = "窗体或控件"
        Me.RBtnWinCtl.UseVisualStyleBackColor = True
        '
        'RBtnTop
        '
        Me.RBtnTop.AutoSize = True
        Me.RBtnTop.Location = New System.Drawing.Point(9, 25)
        Me.RBtnTop.Margin = New System.Windows.Forms.Padding(2)
        Me.RBtnTop.Name = "RBtnTop"
        Me.RBtnTop.Size = New System.Drawing.Size(71, 16)
        Me.RBtnTop.TabIndex = 1
        Me.RBtnTop.Text = "活动窗体"
        Me.RBtnTop.UseVisualStyleBackColor = True
        '
        'RBtnDesk
        '
        Me.RBtnDesk.AutoSize = True
        Me.RBtnDesk.Checked = True
        Me.RBtnDesk.Location = New System.Drawing.Point(9, 2)
        Me.RBtnDesk.Margin = New System.Windows.Forms.Padding(2)
        Me.RBtnDesk.Name = "RBtnDesk"
        Me.RBtnDesk.Size = New System.Drawing.Size(71, 16)
        Me.RBtnDesk.TabIndex = 0
        Me.RBtnDesk.TabStop = True
        Me.RBtnDesk.Text = "整个桌面"
        Me.RBtnDesk.UseVisualStyleBackColor = True
        '
        'RBgif
        '
        Me.RBgif.AutoSize = True
        Me.RBgif.Location = New System.Drawing.Point(218, 5)
        Me.RBgif.Margin = New System.Windows.Forms.Padding(2)
        Me.RBgif.Name = "RBgif"
        Me.RBgif.Size = New System.Drawing.Size(41, 16)
        Me.RBgif.TabIndex = 16
        Me.RBgif.TabStop = True
        Me.RBgif.Text = "GIF"
        Me.RBgif.UseVisualStyleBackColor = True
        '
        'RBpng
        '
        Me.RBpng.AutoSize = True
        Me.RBpng.Location = New System.Drawing.Point(144, 5)
        Me.RBpng.Margin = New System.Windows.Forms.Padding(2)
        Me.RBpng.Name = "RBpng"
        Me.RBpng.Size = New System.Drawing.Size(41, 16)
        Me.RBpng.TabIndex = 15
        Me.RBpng.TabStop = True
        Me.RBpng.Text = "PNG"
        Me.RBpng.UseVisualStyleBackColor = True
        '
        'RBjpg
        '
        Me.RBjpg.AutoSize = True
        Me.RBjpg.Location = New System.Drawing.Point(78, 5)
        Me.RBjpg.Margin = New System.Windows.Forms.Padding(2)
        Me.RBjpg.Name = "RBjpg"
        Me.RBjpg.Size = New System.Drawing.Size(41, 16)
        Me.RBjpg.TabIndex = 14
        Me.RBjpg.TabStop = True
        Me.RBjpg.Text = "JPG"
        Me.RBjpg.UseVisualStyleBackColor = True
        '
        'RBbmp
        '
        Me.RBbmp.AutoSize = True
        Me.RBbmp.Location = New System.Drawing.Point(14, 5)
        Me.RBbmp.Margin = New System.Windows.Forms.Padding(2)
        Me.RBbmp.Name = "RBbmp"
        Me.RBbmp.Size = New System.Drawing.Size(41, 16)
        Me.RBbmp.TabIndex = 13
        Me.RBbmp.TabStop = True
        Me.RBbmp.Text = "BMP"
        Me.RBbmp.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.LabelX1)
        Me.Panel3.Location = New System.Drawing.Point(6, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(354, 30)
        Me.Panel3.TabIndex = 17
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.RBbmp)
        Me.Panel4.Controls.Add(Me.RBgif)
        Me.Panel4.Controls.Add(Me.RBjpg)
        Me.Panel4.Controls.Add(Me.RBpng)
        Me.Panel4.Location = New System.Drawing.Point(66, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(284, 24)
        Me.Panel4.TabIndex = 2
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Location = New System.Drawing.Point(59, 31)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(44, 21)
        Me.TextBoxX1.TabIndex = 0
        '
        'CheckBoxX1
        '
        '
        '
        '
        Me.CheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX1.Location = New System.Drawing.Point(9, 26)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(107, 28)
        Me.CheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX1.TabIndex = 2
        Me.CheckBoxX1.Text = "延时截图(秒)："
        '
        'TextBoxX2
        '
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.Location = New System.Drawing.Point(114, 30)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.Size = New System.Drawing.Size(42, 21)
        Me.TextBoxX2.TabIndex = 3
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(219, 16)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(81, 23)
        Me.LabelX4.TabIndex = 13
        Me.LabelX4.Text = "@白羊座小葛"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.CrumbBar1)
        Me.Panel5.Controls.Add(Me.RBDesktop)
        Me.Panel5.Controls.Add(Me.TextBox1)
        Me.Panel5.Controls.Add(Me.RBUser)
        Me.Panel5.Location = New System.Drawing.Point(6, 36)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(364, 31)
        Me.Panel5.TabIndex = 18
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.CBRunHide)
        Me.GroupPanel1.Controls.Add(Me.TextBoxX2)
        Me.GroupPanel1.Controls.Add(Me.CBHide)
        Me.GroupPanel1.Controls.Add(Me.CBAutoRun)
        Me.GroupPanel1.Controls.Add(Me.CheckBoxX1)
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
        'CheckBoxX2
        '
        '
        '
        '
        Me.CheckBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX2.Location = New System.Drawing.Point(9, 4)
        Me.CheckBoxX2.Name = "CheckBoxX2"
        Me.CheckBoxX2.Size = New System.Drawing.Size(100, 23)
        Me.CheckBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX2.TabIndex = 1
        Me.CheckBoxX2.Text = "Ctrl"
        '
        'CheckBoxX3
        '
        '
        '
        '
        Me.CheckBoxX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX3.Location = New System.Drawing.Point(59, 4)
        Me.CheckBoxX3.Name = "CheckBoxX3"
        Me.CheckBoxX3.Size = New System.Drawing.Size(55, 23)
        Me.CheckBoxX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX3.TabIndex = 2
        Me.CheckBoxX3.Text = "Shift"
        '
        'CheckBoxX4
        '
        '
        '
        '
        Me.CheckBoxX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX4.Location = New System.Drawing.Point(9, 30)
        Me.CheckBoxX4.Name = "CheckBoxX4"
        Me.CheckBoxX4.Size = New System.Drawing.Size(42, 23)
        Me.CheckBoxX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX4.TabIndex = 3
        Me.CheckBoxX4.Text = "Alt"
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
        Me.Text = "s"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.GPSaveOption.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GPKey.ResumeLayout(False)
        Me.GPRegion.ResumeLayout(False)
        Me.GPRegion.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QuickCaptureNtf As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GPSaveOption As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RBAutoSave As System.Windows.Forms.RadioButton
    Friend WithEvents RBview As System.Windows.Forms.RadioButton
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
    Friend WithEvents BtnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CBHide As System.Windows.Forms.CheckBox
    Friend WithEvents CBAutoRun As System.Windows.Forms.CheckBox
    Friend WithEvents RBCopy As System.Windows.Forms.RadioButton
    Friend WithEvents CBRunHide As System.Windows.Forms.CheckBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents RBbmp As System.Windows.Forms.RadioButton
    Friend WithEvents RBgif As System.Windows.Forms.RadioButton
    Friend WithEvents RBjpg As System.Windows.Forms.RadioButton
    Friend WithEvents RBpng As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CheckBoxX1 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents CheckBoxX3 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX2 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX4 As DevComponents.DotNetBar.Controls.CheckBoxX

End Class
