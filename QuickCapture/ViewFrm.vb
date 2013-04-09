Public Class ViewFrm
    Private bmp As Bitmap = Nothing
    Private savePath As String
    Private format As Integer
    Private ImgFormats() As Drawing.Imaging.ImageFormat = {Drawing.Imaging.ImageFormat.Bmp, Drawing.Imaging.ImageFormat.Jpeg, Drawing.Imaging.ImageFormat.Png, Drawing.Imaging.ImageFormat.Gif}
    Const EW As Integer = 18
    Const SN As Integer = 43
    Private saved As Boolean = False
    Public Sub New(ByVal bmp As Bitmap, ByVal savePath As String, ByVal format As Integer)
        InitializeComponent()
        Me.bmp = bmp
        Me.savePath = savePath
        Me.format = format
        PictureBox1.Image = bmp
        Me.Width = 730
        Me.Height = 580
        Me.Left = 200
        Me.Top = 50
        Panel1.BackgroundImage = My.Resources.back
        Panel1.BackgroundImageLayout = ImageLayout.Tile
        DealWithScrollBars()

    End Sub
    Public Sub changeBmp(ByVal bmp As Bitmap, ByVal savePaht As String, ByVal format As Integer)
        Me.bmp = bmp
        Me.savePath = savePath
        Me.format = format
        PictureBox1.Image = bmp
        Me.Width = 730
        Me.Height = 580
        saved = False
        DealWithScrollBars()

    End Sub

    Private Sub ViewFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        If Not saved Or MsgBox("确定不保存退出？", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
            PictureBox1.Image = Nothing
            Me.Hide()
        End If
    End Sub

    Private Sub DealWithScrollBars()
        If bmp Is Nothing Then
            Exit Sub
        End If
        If Panel1.Width > bmp.Width Then
            HScrollBar1.Visible = False

        Else
            With HScrollBar1
                .Visible = True
                .Minimum = 0
                .Maximum = bmp.Width - Panel1.Width + 12

            End With
        End If
        If Panel1.Height > bmp.Height Then
            VScrollBar1.Visible = False
        Else
            With VScrollBar1
                .Visible = True
                .Minimum = 0
                .Maximum = bmp.Height - Panel1.Height + 12
            End With
        End If

    End Sub

    Private Sub ViewFrm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        PictureBox1.Location = New Point(0, 0)
        DealWithScrollBars()
       
    End Sub

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar1.Scroll
        PictureBox1.Top = -e.NewValue
    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        PictureBox1.Left = -e.NewValue
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            SaveFile()
            saved = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "提示")
        End Try
    End Sub
    Public Sub SaveFile()
        Dim nowstr As String = Now.ToString.Replace("/", "-")
        nowstr = nowstr.Replace(" ", "-")
        nowstr = nowstr.Replace(":", ".")
        If Strings.Right(savePath, 1) = "\" Then
            savePath = Strings.Left(savePath, savePath.Length - 1)
        End If
        Dim hzm As String = Nothing
        Select Case format
            Case 0
                hzm = ".bmp"
            Case 1
                hzm = ".jpg"
            Case 2
                hzm = ".png"
            Case 3
                hzm = ".gif"
        End Select
        Dim filename As String = savePath & "\" & nowstr & hzm
        Try
            bmp.Save(filename, ImgFormats(format))
        Catch ex As Exception
            Throw ex
        End Try
        MsgBox("保存" & vbCrLf & filename & vbCrLf & "成功", MsgBoxStyle.Information, "提示")
    End Sub
    Private Sub MFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MFile.Click

    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        If Not saved Or MsgBox("确定不保存退出？", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
            PictureBox1.Image = Nothing
            Me.Hide()
        End If
    End Sub



    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        My.Computer.Clipboard.SetImage(bmp)
    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        System.Diagnostics.Process.Start("http://weibo.com/abeyuhang")
    End Sub
End Class