Public Class frmBooks
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

    Private Sub frmBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillBooks(lv)
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If tbsearch.Text = "" Or tbsearch.Text = " Search ..." Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Type something!", 3000)
            Exit Sub
        End If
        SearchBooks(lv, tbsearch.Text.ToLower, lblresult)
        frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblresult.Text, 3000)
    End Sub

    Private Sub tbsearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbsearch.KeyPress
        SearchBooks(lv, tbsearch.Text.ToLower, lblresult)
        frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblresult.Text, 3000)
    End Sub

    Private Sub tbsearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbsearch.LostFocus
        tbsearch.Text = " Search ..."
    End Sub

    Private Sub tbsearch_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbsearch.MouseClick
        tbsearch.Focus()
        tbsearch.SelectAll()
    End Sub
    Private Sub lv_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv.MouseClick
        With lv.SelectedItems(0)
            lblid.Text = .SubItems(0).Text
            lbltitle.Text = .SubItems(1).Text
            lblcat.Text = .SubItems(2).Text
            lblaut.Text = .SubItems(3).Text
            lblven.Text = .SubItems(4).Text
            lblpublisher.Text = .SubItems(5).Text
            lblpub.Text = .SubItems(6).Text
            lblqty.Text = .SubItems(7).Text
            lblis.Text = .SubItems(8).Text
            lbltot.Text = .SubItems(9).Text
        End With
    End Sub

   
    Private Sub GhostButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GhostButton2.Click
        FillBooks(lv)
        lblid.Text = "..."
        lbltitle.Text = "..."
        lblcat.Text = "..."
        lblaut.Text = "..."
        lblven.Text = "..."
        lblpublisher.Text = "..."
        lblpub.Text = "..."
        lblqty.Text = "..."
    End Sub

    Private Sub groupbook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblpublisher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SlcClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlcClose1.Click
        _mod.frmfade(Me, 10)
        Me.Close()
    End Sub
End Class