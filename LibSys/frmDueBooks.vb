Public Class frmDueBooks
    Private Sub GhostButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _mod.frmfade(Me, 10)
        Me.Close()
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnheader.MouseDown, Label1.MouseDown
        xpos = Cursor.Position.X - Me.Location.X
        ypos = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnheader.MouseMove, Label1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            pos = MousePosition
            pos.X = pos.X - xpos
            pos.Y = pos.Y - ypos
            Me.Location = pos
        End If
    End Sub

    Private Sub frmDueBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillDueBooks(lv)
    End Sub

    Private Sub SlcClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlcClose1.Click
        _mod.frmfade(Me, 10)
        Me.Close()
    End Sub
End Class