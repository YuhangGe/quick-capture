Public Class FrmAbout
    Private prePoint As Point = Point.Empty
    Private isLBDown As Boolean
   
    Private Sub LabelX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelX4.Click
        System.Diagnostics.Process.Start("mailto:abraham1@163.com")
    End Sub

    Private Sub LabelX4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelX4.MouseEnter
        LabelX4.ForeColor = Color.Red
        LabelX4.Text = " <u><b>联系开发者:Abraham1@163.com</b></u>"
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub LabelX4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelX4.MouseLeave
        LabelX4.ForeColor = Color.Blue
        LabelX4.Text = "<u>联系开发者:Abraham1@163.com</u>"
        Me.Cursor = Cursors.Default
    End Sub

End Class