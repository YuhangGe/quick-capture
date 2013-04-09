<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewFrm
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
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.MFile = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnSave = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnSaveAs = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MFile, Me.ButtonItem2})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Margin = New System.Windows.Forms.Padding(2)
        Me.Bar1.MenuBar = True
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(534, 25)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.Bar1.TabIndex = 2
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'MFile
        '
        Me.MFile.Name = "MFile"
        Me.MFile.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.MFile.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BtnSave, Me.BtnSaveAs, Me.ButtonItem3, Me.ButtonItem1})
        Me.MFile.Text = "文件"
        '
        'BtnSave
        '
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.BtnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.BtnSave.Text = "保存"
        '
        'BtnSaveAs
        '
        Me.BtnSaveAs.Name = "BtnSaveAs"
        Me.BtnSaveAs.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlT)
        Me.BtnSaveAs.Text = "另存为..."
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.ButtonItem3.Text = "复制"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.ButtonItem1.Text = "退出"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonItem2.FontUnderline = True
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem2.Text = "@白羊座小葛"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HScrollBar1.Location = New System.Drawing.Point(0, 412)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(534, 18)
        Me.HScrollBar1.TabIndex = 7
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(516, 25)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(18, 387)
        Me.VScrollBar1.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 387)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(381, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ViewFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 430)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.Bar1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ViewFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "图片预览"
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents MFile As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnSave As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnSaveAs As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
End Class
