Public Class frmUserLogs
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
    Private Sub cbodatelog_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbodatelog.SelectedIndexChanged
        If cbodatelog.Text = " ..." Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Type something!", 3000)
            Exit Sub
        End If
        SearchUserLog(lv, cbodatelog.Text.ToLower, lblresult)
        frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblresult.Text, 3000)
    End Sub

    Private Sub frmUserLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillUserLog(lv)

        FillCBO(cbodatelog, "tbluserlog", "entry_date")
    End Sub

    Private Sub tbsearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbsearch.KeyPress
       
        SearchUserLog(lv, tbsearch.Text, lblresult)
        frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblresult.Text, 3000)
    End Sub

    
    Private Sub tbsearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbsearch.LostFocus
        tbsearch.Text = " Search ..."
    End Sub

    Private Sub tbsearch_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbsearch.MouseClick
        tbsearch.Focus()
        tbsearch.SelectAll()
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        FillUserLog(lv)

        FillCBO(cbodatelog, "tbluserlog", "entry_date")
    End Sub

    Private Sub SlcClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlcClose1.Click
        _mod.frmfade(Me, 10)
        Me.Close()
    End Sub
End Class