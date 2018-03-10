Public Class frmUserMaint

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


    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If tbsearch.Text = "" Or tbsearch.Text = " Search ..." Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Type something!", 3000)
            Exit Sub
        End If
        SearchUserMaint(lv, tbsearch.Text.ToLower, lblresult)
        frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblresult.Text, 3000)
    End Sub

    Private Sub tbsearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbsearch.KeyPress
        SearchUserMaint(lv, tbsearch.Text.ToLower, lblresult)
        frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblresult.Text, 3000)
    End Sub

    Private Sub tbsearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbsearch.LostFocus
        tbsearch.Text = " Search ..."
    End Sub

    Private Sub tbsearch_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbsearch.MouseClick
        tbsearch.Focus()
        tbsearch.SelectAll()
    End Sub

    Private Sub frmUserMaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillUserMaint(lv)
        FillCBO(cboutype, "tbluser", "utype")
    End Sub

    Dim returns As Boolean = False
    Public Sub _toggle()
        If returns = False Then
            _mod.Forward(btnrefresh, btnrefresh.Location.X, (Me.Width - btnrefresh.Width) - 980)
            returns = True
        Else
            _mod.Back()
            returns = False
        End If
    End Sub
    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        If btnrefresh.Text = "Cancel" Then
            btnadd.Color = Color.Empty
            btnadd.Text = "Add"
            btnrefresh.Text = "Refresh"
            btndelete.Visible = True
            btnclear.Visible = True
            btnedit.Visible = True
            lblcpword.Visible = False
            tbcpword.Visible = False
            grupboxenabled(False)
            cleardata()
            _toggle()
        Else

            FillUserMaint(lv)
        End If
    End Sub

    Private Sub lv_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv.MouseClick
        With lv.SelectedItems(0)
            lbluid.Text = .SubItems(0).Text
            tbuname.Text = .SubItems(1).Text
            tbfname.Text = .SubItems(2).Text
            tblname.Text = .SubItems(3).Text
            cboutype.Text = .SubItems(4).Text
            tbcont.Text = .SubItems(5).Text
            tbaddr.Text = .SubItems(6).Text
            lblpwordx.Text = .SubItems(7).Text
        End With
        grupboxenabled(True)
    End Sub
    Public Sub grupboxenabled(ByVal mode As Boolean)
        groupbook.Enabled = mode
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If btnadd.Text = "Add" Then
            btnadd.Text = "Save"
            btnadd.Color = Color.FromArgb(205, 150, 0)
            btnrefresh.Text = "Cancel"
            btndelete.Visible = False
            btnclear.Visible = False
            btnedit.Visible = False
            lblcpword.Visible = True
            tbcpword.Visible = True
            grupboxenabled(True)
            cleardata()
            GenUserId()
            tbuname.Focus()
            tbuname.SelectAll()
            _toggle()
        Else
            If tbuname.Text = "" Or tbfname.Text = "" Or tblname.Text = "" Or tbcont.Text = "" Or cboutype.Text = " ..." Or tbaddr.Text = "" Or tbpword.Text = "" Then
                frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Fill-up all the fields!", 3000)
                Exit Sub
            ElseIf tbpword.Text <> tbcpword.Text Then
                frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Password not match!", 3000)
                Exit Sub
            ElseIf DoesExist(tbuname.Text, "tbluser", "uname") Then
                frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Username " & tbuname.Text.ToUpper & " Exist! Please try another one.", 3000)
                Exit Sub
            End If
       
        connected()
        sql = "INSERT INTO tbluser VALUES ('" & lbluid.Text & "','" & tbfname.Text.ToLower & "','" & tblname.Text.ToLower & "','" & tbuname.Text.ToLower & "','" & cboutype.Text.ToLower & "','" & tbcont.Text.ToLower & "','" & tbaddr.Text & "','" & tbpword.Text & "')"
        cmd = New System.Data.OleDb.OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()
        FillUserMaint(lv)
        frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Successfully Saved!", 3000)
            cleardata()
            GenUserId()
        End If

    End Sub

    Public Sub cleardata()
        lbluid.Text = "..."
        tbuname.Text = ""
        tbfname.Text = ""
        tblname.Text = ""
        tbcont.Text = ""
        cboutype.Text = " ..."
        tbaddr.Text = ""
        tbpword.Text = ""
        tbcpword.Text = ""
    End Sub

    Public Sub GenUserId()
        connected()
        Dim _id As String = ""
        sql = "SELECT " & _mod.Decrypt(_x) & "(ID_user) FROM tbluser"
        cmd = New System.Data.OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                _id = dr.Item(0).ToString.Substring(10) + 1
            Loop
        End If
        lbluid.Text = "USER-" & Now().ToString("yyyy") & "-" & _id
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
       
            If lbluid.Text = "..." Then
                frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Select from List!", 3000)
                Exit Sub
            ElseIf tbuname.Text = "" Or tbfname.Text = "" Or tblname.Text = "" Or tbcont.Text = "" Or cboutype.Text = " ..." Or tbaddr.Text = "" Or tbpword.Text = "" Then
                frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Fill-up all the fields!", 3000)
                Exit Sub
        ElseIf tbpword.Text <> lblpwordx.Text Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Password not match!", 3000)
            Exit Sub
            End If
            connected()
            sql = "UPDATE tbluser SET uname = '" & tbuname.Text.ToLower & "', fname = '" & tbfname.Text & "' , lname = '" & tblname.Text & "', contactno = '" & tbcont.Text & "', utype = '" & cboutype.Text & "', addr = '" & tbaddr.Text & "', pword = '" & tbpword.Text & "'" & _
                " WHERE id_user = '" & lbluid.Text & "'"
            cmd = New System.Data.OleDb.OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Successfully Updated!", 3000)
            FillUserMaint(lv)

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        connected()
        Dim i As Integer
        sql = "DELETE FROM tbluser WHERE Id_user = '" & lbluid.Text & "'"
        If lbluid.Text = "..." Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Please select from the list!", 3000)
            Exit Sub
        End If
        cmd = New OleDb.OleDbCommand(sql, con)
        i = MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            cmd.ExecuteNonQuery()
            cleardata()
            FillUserMaint(lv)
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Successfully Deleted!", 3000)
            grupboxenabled(False)
        End If
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cleardata()
    End Sub


    Private Sub tbuname_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbuname.Enter
        lbluname.GlowState = True
    End Sub


    Private Sub tbuname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbuname.Leave
        lbluname.GlowState = False
    End Sub

    Private Sub tbfname_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbfname.Enter
        lblfname.GlowState = True
    End Sub


    Private Sub tbfname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbfname.Leave
        lblfname.GlowState = False
    End Sub

    Private Sub tblname_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tblname.Enter
        lbllname.GlowState = True
    End Sub


    Private Sub tblname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tblname.Leave
        lbllname.GlowState = False
    End Sub
    Private Sub tbcont_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcont.Enter
        lblcont.GlowState = True
    End Sub


    Private Sub tbcont_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcont.Leave
        lblcont.GlowState = False
    End Sub
    Private Sub cboutype_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboutype.Enter
        lblutype.GlowState = True
    End Sub


    Private Sub cboutype_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboutype.Leave
        lblutype.GlowState = False
    End Sub
    Private Sub tbaddr_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbaddr.Enter
        lbladdr.GlowState = True
    End Sub


    Private Sub tbaddr_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbaddr.Leave
        lbladdr.GlowState = False
    End Sub

    Private Sub tbpword_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbpword.Enter
        lblpword.GlowState = True
    End Sub


    Private Sub tbpword_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbpword.Leave
        lblpword.GlowState = False
    End Sub
    Private Sub tbcpword_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcpword.Enter
        lblcpword.GlowState = True
    End Sub


    Private Sub tbcpword_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcpword.Leave
        lblcpword.GlowState = False
    End Sub



    Private Sub btntype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntype.Click
        Me.TopMost = False
        Dim otherM As String = InputBox("Please Input Another User Type!", MsgBoxStyle.OkOnly, "LibSys")
        If otherM = "" Then
            Exit Sub
        End If
        cboutype.Items.Add(otherM)
        cboutype.Text = otherM
        Me.TopMost = True
    End Sub

    Private Sub tbcont_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbcont.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Number Only!", 3000)
        End If
    End Sub

    Private Sub SlcClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlcClose1.Click
        _mod.frmfade(Me, 10)
        Me.Close()
    End Sub

    Private Sub groupbook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
