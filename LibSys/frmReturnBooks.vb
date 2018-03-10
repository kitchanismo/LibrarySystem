Public Class frmReturnBooks
    Private Sub GhostButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
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

    Public Sub cleardata()
        lblisid.Text = "..."
        lblidbook.Text = "..."
        lbltitle.Text = "..."
        lblmember.Text = "..."
        lbldatebor.Text = "..."
        lbldueborrow.Text = "..."
        lblrem.Text = ""
        cbofine.Text = " ..."
        lblid.Text = "..."
        GenIDReturn()
    End Sub
    Private Sub lv_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv.MouseClick
        With lv.SelectedItems(0)
            lblisid.Text = .SubItems(0).Text
            lblidbook.Text = .SubItems(1).Text
            lbltitle.Text = .SubItems(2).Text
            lblmember.Text = .SubItems(3).Text
            lbldatebor.Text = .SubItems(4).Text
            lbldueborrow.Text = .SubItems(5).Text
        End With
        If FormatDateTime(lbldueborrow.Text) <= Date.Today Then
            GLabel6.GlowState = True
            GLabel6.GlowColor = Color.Red
            GLabel6.Pulse = True
        Else
            GLabel6.GlowState = True
            GLabel6.GlowColor = Color.Green
            GLabel6.Pulse = False
        End If
    End Sub

    Private Sub frmReturnBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillBorrowBooks(lv)
        GenIDReturn()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If tbsearch.Text = "" Or tbsearch.Text = " Search ..." Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Type something!", 3000)
            Exit Sub
        End If
        SearchBorrow(lv, tbsearch.Text.ToLower, lblresult)
        frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblresult.Text, 3000)
    End Sub

    Private Sub tbsearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbsearch.KeyPress
        SearchBorrow(lv, tbsearch.Text.ToLower, lblresult)
        frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblresult.Text, 3000)
    End Sub

    Private Sub tbsearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbsearch.LostFocus
        tbsearch.Text = " Search ..."
    End Sub

    Private Sub tbsearch_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbsearch.MouseClick
        tbsearch.Focus()
        tbsearch.SelectAll()
    End Sub

    Public Sub GenIDReturn()
        connected()
        Dim _id As String = Nothing
        sql = "SELECT Max(ID_return) FROM tblreturn"
        cmd = New System.Data.OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                _id = dr.Item(0).ToString.Substring(3) + 1
            Loop
        End If
        lblid.Text = "RT-" & _id
    End Sub

    Private Sub btnreturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturn.Click
        Dim ctr, ctr2 As Integer
        Dim qty, issued As Integer
        If lblid.Text = "..." Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Select From List!", 3000)
            Exit Sub
        ElseIf tbrem.Text = "" Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Empty Remarks!", 3000)
            Exit Sub
        ElseIf cbofine.Text = " ..." Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Select Fine!", 3000)
            Exit Sub
        End If
        'get the qty of book
        connected()
        sql = " SELECT * FROM tblbooks where id_book = '" & lblidbook.Text & "'"
        cmd = New OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            qty = dr.Item(7).ToString
            issued = dr.Item(8).ToString
        End While
        'update qty on books by incrementing
        ctr = qty + 1
        sql = "UPDATE tblbooks SET avbook = " & ctr & "" & _
           " WHERE id_book = '" & lblidbook.Text & "'"
        cmd = New System.Data.OleDb.OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()
        'update qty on books by derementing
        ctr2 = issued - 1
        sql = "UPDATE tblbooks SET isbook = " & ctr2 & "" & _
           " WHERE id_book = '" & lblidbook.Text & "'"
        cmd = New System.Data.OleDb.OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()
        'save return books
        sql = "INSERT INTO tblreturn VALUES ('" & lblid.Text & "','" & lblisid.Text & "','" & lbltitle.Text.ToLower & "','" & lblmember.Text.ToLower & "','" & tbrem.Text & "','" & cbofine.Text & "','" & dtpdate.Text & "')"
        cmd = New System.Data.OleDb.OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()
        'delete
        connected()
        sql = "DELETE FROM tblborrow WHERE id = '" & lblisid.Text & "'"
        cmd = New OleDb.OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()
        cleardata()
        frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Successfully Saved!", 3000)
        GenIDReturn()
        FillBorrowBooks(lv)
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cleardata()
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        FillBorrowBooks(lv)
    End Sub

    Private Sub SlcClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlcClose1.Click
        _mod.frmfade(Me, 10)
        Me.Close()
    End Sub
End Class