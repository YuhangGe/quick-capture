Public Class ScreenCanvas



    Private mode As QuickCaptureCore.CaptureRegionEnum

    Private rtnBmp As Bitmap
    Private startPoint As Point
    Private endPoint As Point

    Private isLBDown As Boolean = False
    Private hasDragged As Boolean = False
    Private hasSelected As Boolean = False
    Private g As Graphics
    Const littleRect As Integer = 4
    Private borderPen As Pen = Pens.Red
    Private beginDrag As Boolean = False
    Private beginResize As Boolean = False
    Private prePoint As Point
    Private resizeIndex As Integer


    Private Sub ScreenCanvas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Close()
        ElseIf e.KeyCode = Keys.Enter And mode = QuickCaptureCore.CaptureRegionEnum.Selection Then
            Me.Hide()
            rtnBmp = New QuickCaptureCore(QuickCaptureCore.CaptureRegionEnum.Selection, New Rectangle(Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y), Math.Max(startPoint.X, endPoint.X), Math.Max(startPoint.Y, endPoint.Y))).Capture
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Close()
        End If
    End Sub
    
    Public Sub New(ByVal mode As QuickCaptureCore.CaptureRegionEnum)
        InitializeComponent()
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.Top = 0
        Me.Left = 0
        Me.mode = mode
        Me.TopMost = True
        init()
    End Sub
    Private Sub init()

      
        Me.BackColor = Color.Black
      
        Me.Opacity = 0.25
        Me.DoubleBuffered = True
    End Sub

    Public Function getBMP() As Bitmap
        Return rtnBmp
    End Function

    Private Sub ScreenCanvas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.Cursor = Cursors.Cross
        g = Me.CreateGraphics
    End Sub

    Private Sub ScreenCanvas_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        If hasSelected Then
            If IsInRect(e.Location) Then
                Me.Hide()
                rtnBmp = New QuickCaptureCore(QuickCaptureCore.CaptureRegionEnum.Selection, New Rectangle(Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y), Math.Max(startPoint.X, endPoint.X), Math.Max(startPoint.Y, endPoint.Y))).Capture
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Close()
            End If
        End If
    End Sub

    Private Sub ScreenCanvas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Not hasSelected Then
                isLBDown = True
                startPoint = e.Location
            Else
                If IsInRect(e.Location) Then
                    resizeIndex = IsOnBorder(e.Location)
                    If resizeIndex <> -1 Then
                        beginResize = True
                        beginDrag = False
                    Else
                        beginDrag = True
                        beginResize = False
                    End If
                    prePoint = e.Location
                End If
            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            g.Clear(Color.Black)
            hasSelected = False
            Me.Cursor = Cursors.Cross
        End If


    End Sub
    Private Function IsOnBorder(ByVal p As Point) As Integer
        If (Math.Abs(p.X - startPoint.X) < littleRect And Math.Abs(p.Y - startPoint.Y) < littleRect) Then
            Return 0 'start
        End If

        If (Math.Abs(p.X - endPoint.X) < littleRect And Math.Abs(p.Y - endPoint.Y) < littleRect) Then
            Return 1 'end
        End If

        If (Math.Abs(p.X - endPoint.X) < littleRect And Math.Abs(p.Y - startPoint.Y) < littleRect) Then
            Return 2
        End If
        If (Math.Abs(p.X - startPoint.X) < littleRect And Math.Abs(p.Y - endPoint.Y) < littleRect) Then
            Return 3
        End If
        If (Math.Abs(p.X - (startPoint.X + endPoint.X) / 2) < littleRect And Math.Abs(p.Y - startPoint.Y) < littleRect) Then
            Return 4
        End If
        If (Math.Abs(p.X - (startPoint.X + endPoint.X) / 2) < littleRect And Math.Abs(p.Y - endPoint.Y) < littleRect) Then
            Return 5
        End If
        If (Math.Abs(p.X - startPoint.X) < littleRect And Math.Abs(p.Y - (startPoint.Y + endPoint.Y) / 2) < littleRect) Then
            Return 6
        End If
        If (Math.Abs(p.X - endPoint.X) < littleRect And Math.Abs(p.Y - (startPoint.Y + endPoint.Y) / 2) < littleRect) Then
            Return 7
        End If
        Return -1
    End Function
    Private Function IsInRect(ByVal curPoint As Point) As Boolean
        Dim left, right, top, bottom As Integer
        If startPoint.X > endPoint.X Then
            left = endPoint.X
            right = startPoint.X
        Else
            right = endPoint.X
            left = startPoint.X
        End If
        If startPoint.Y > endPoint.Y Then
            bottom = startPoint.Y
            top = endPoint.Y

        Else
            top = startPoint.Y
            bottom = endPoint.Y
        End If
        If curPoint.X > left - littleRect And curPoint.X < right + littleRect And curPoint.Y < bottom + littleRect And curPoint.Y > top - littleRect Then
            Return True
        End If
        Return False
    End Function
    Private Sub setSizeCursor(ByVal p As Point)
        Dim minX, maxX, minY, maxY As Integer
        If startPoint.X < endPoint.X Then
            minX = startPoint.X
            maxX = endPoint.X
        Else
            minX = endPoint.X
            maxX = startPoint.X
        End If
        If startPoint.Y < endPoint.Y Then
            minY = startPoint.Y
            maxY = endPoint.Y
        Else
            minY = endPoint.Y
            maxY = startPoint.Y
        End If
       
        If Math.Abs(p.X - maxX) < littleRect Then
            If Math.Abs(p.Y - minY) < littleRect Then
                Me.Cursor = Cursors.SizeNESW
                Exit Sub
            End If
            If Math.Abs(p.Y - maxY) < littleRect Then
                Me.Cursor = Cursors.SizeNWSE
                Exit Sub
            End If
            Me.Cursor = Cursors.SizeWE
            Exit Sub
        End If
        If Math.Abs(p.X - minX) < littleRect Then
            If Math.Abs(p.Y - minY) < littleRect Then
                Me.Cursor = Cursors.SizeNWSE
                Exit Sub
            End If
            If Math.Abs(p.Y - maxY) < littleRect Then
                Me.Cursor = Cursors.SizeNESW
                Exit Sub
            End If
            Me.Cursor = Cursors.SizeWE
            Exit Sub
        End If
        Me.Cursor = Cursors.SizeNS
    End Sub
    Private Sub ScreenCanvas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Not hasSelected Then
            If isLBDown Then
                hasDragged = True
                endPoint = e.Location
                PaintBorder()
            End If
        Else
            If beginDrag Then
                Dim curPoint As Point = e.Location
                Dim left As Integer = Math.Min(startPoint.X, endPoint.X)
                Dim top As Integer = Math.Min(startPoint.Y, endPoint.Y)
                startPoint.X = startPoint.X + curPoint.X - prePoint.X
                startPoint.Y = startPoint.Y + curPoint.Y - prePoint.Y
                endPoint.X = endPoint.X + curPoint.X - prePoint.X
                endPoint.Y = endPoint.Y + curPoint.Y - prePoint.Y
                prePoint = curPoint
                PaintBorder()
                Exit Sub
            End If
            If beginResize Then
                Dim curPoint As Point = e.Location
                Reshape(curPoint.X - prePoint.X, curPoint.Y - prePoint.Y, resizeIndex)
                prePoint = curPoint
                PaintBorder()
                Exit Sub
            End If
            If IsInRect(e.Location) Then
                If IsOnBorder(e.Location) <> -1 Then
                    setSizeCursor(e.Location)
                Else
                    Me.Cursor = Cursors.SizeAll
                End If
            Else
                Me.Cursor = Cursors.Default
            End If
        End If
      
    End Sub
    Private Sub Reshape(ByVal deltaX As Integer, ByVal deltaY As Integer, ByVal resizeIndex As Integer)
        Select Case resizeIndex
            Case 0
                startPoint.X += deltaX
                startPoint.Y += deltaY
            Case 1
                endPoint.X += deltaX
                endPoint.Y += deltaY
            Case 2
                startPoint.Y += deltaY
                endPoint.X += deltaX
            Case 3
                startPoint.X += deltaX
                endPoint.Y += deltaY
            Case 4
                startPoint.Y += deltaY

            Case 5
                endPoint.Y += deltaY
            Case 6
                startPoint.X += deltaX
            Case 7
                endPoint.X += deltaX
        End Select
    End Sub
    Private Sub ScreenCanvas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If hasDragged Then
            hasSelected = True

        End If

        beginDrag = False
        beginResize = False
        isLBDown = False
        hasDragged = False
    End Sub

    Private Sub PaintBorder()
        g.Clear(Color.Black)
        g.DrawRectangle(New Pen(borderPen.Color, 2), Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y), Math.Abs(startPoint.X - endPoint.X), Math.Abs(startPoint.Y - endPoint.Y))
        g.FillRectangle(Brushes.White, Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y), Math.Abs(startPoint.X - endPoint.X), Math.Abs(startPoint.Y - endPoint.Y))
        g.DrawRectangle(borderPen, startPoint.X - littleRect, startPoint.Y - littleRect, 2 * littleRect, 2 * littleRect)
        g.DrawRectangle(borderPen, endPoint.X - littleRect, endPoint.Y - littleRect, 2 * littleRect, 2 * littleRect)
        g.DrawRectangle(borderPen, startPoint.X - littleRect, endPoint.Y - littleRect, 2 * littleRect, 2 * littleRect)
        g.DrawRectangle(borderPen, endPoint.X - littleRect, startPoint.Y - littleRect, 2 * littleRect, 2 * littleRect)

        g.DrawRectangle(borderPen, CInt((startPoint.X + endPoint.X) / 2) - littleRect, startPoint.Y - littleRect, 2 * littleRect, 2 * littleRect)
        g.DrawRectangle(borderPen, CInt((startPoint.X + endPoint.X) / 2) - littleRect, endPoint.Y - littleRect, 2 * littleRect, 2 * littleRect)
        g.DrawRectangle(borderPen, startPoint.X - littleRect, CInt((startPoint.Y + endPoint.Y) / 2) - littleRect, 2 * littleRect, 2 * littleRect)
        g.DrawRectangle(borderPen, endPoint.X - littleRect, CInt((startPoint.Y + endPoint.Y) / 2) - littleRect, 2 * littleRect, 2 * littleRect)
    End Sub


End Class