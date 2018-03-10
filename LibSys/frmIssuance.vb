Public Class frmIssuance
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

    Private Sub dtpdatebor_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpdatebor.Enter
        lbldatebor.GlowState = True
    End Sub


    Private Sub dtpdatebor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpdatebor.Leave
        lbldatebor.GlowState = False
    End Sub

    Private Sub dtpdue_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpdue.Enter
        lblduedate.GlowState = True
    End Sub


    Private Sub dtpdue_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpdue.Leave
        lblduedate.GlowState = False
    End Sub

    Private Sub frmIssuance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillBooks(lv)
        GenIdIssue()
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        FillBooks(lv)
        GenIdIssue()
        tbsearch.Text = " Search ..."
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
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
            lblqty.Text = .SubItems(7).Text
            lblavail.Text = .SubItems(7).Text
            lblissued.Text = .SubItems(8).Text
            lblis.Text = .SubItems(9).Text
        End With
    End Sub

    Private Sub btnborrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrow.Click
        frmSearchBorrower.Show()
    End Sub


    Public Sub GenIdIssue()
        connected()
        Dim _id As String = Nothing
        sql = "SELECT " & _mod.Decrypt(_x) & "(ID) FROM tblborrow"
        cmd = New System.Data.OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                _id = dr.Item(0).ToString.Substring(3) + 1
            Loop
        End If
        lblidissue.Text = "ID-" & _id
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim av, issued As Integer
        If lblid.Text = "..." Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Select Book!", 3000)
            Exit Sub
        ElseIf lblname.Text = "..." Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Select Borrower!", 3000)
            Exit Sub
        ElseIf lblqty.Text = 0 Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, lbltitle.Text.ToUpper & " are not available! Sorry ...", 3000)
            Exit Sub
        End If
        'update availability on books
        connected()
        av = Val(lblqty.Text) - 1
        sql = "UPDATE tblbooks SET avbook = '" & av & "'" & _
               " WHERE id_book = '" & lblid.Text & "'"
        cmd = New System.Data.OleDb.OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()
        'update availability on books
        connected()
        issued = Val(lblissued.Text) + 1
        sql = "UPDATE tblbooks SET isbook = '" & issued & "'" & _
               " WHERE id_book = '" & lblid.Text & "'"
        cmd = New System.Data.OleDb.OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()

        connected()
        'save issue book
        sql = "INSERT INTO tblBorrow (id, bid, btitle,  uname,  isdate, duedate) VALUES ('" & lblidissue.Text & "','" & lblid.Text & "','" & lbltitle.Text.ToLower & "','" & lblname.Text.ToLower & "', '" & dtpdatebor.Text & "','" & dtpdue.Text & "')"
        cmd = New System.Data.OleDb.OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()

        FillBooks(lv)
        GenIdIssue()
        cleardata()
        frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Successfully Saved!", 3000)

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cleardata()
    End Sub
    Public Sub cleardata()
        lblidissue.Text = "..."
        lblid.Text = "..."
        lblname.Text = "..."
        lbltitle.Text = "..."
        lblqty.Text = 0
        lblavail.Text = "..."
        lblissued.Text = "..."
        GenIdIssue()
    End Sub

    Private Sub lv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv.SelectedIndexChanged

    End Sub

    Private Sub SlcClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlcClose1.Click
        _mod.frmfade(Me, 10)
        Me.Close()
    End Sub
End Class