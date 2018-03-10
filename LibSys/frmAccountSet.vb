Public Class frmAccountSet


    Private Sub GhostButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        
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
    Public Sub Populated()
        connected()
        'Dim x As String = "admin"
        sql = "SELECT * FROM tbluser WHERE Uname = '" & frmMain.Label1.Text & "'"
        ds.Clear()
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "MyProfile")
        row = ds.Tables("MyProfile").Rows.Count
        lbluid.Text = ds.Tables("MyProfile").Rows(0).Item(0)
        tbfname.Text = ds.Tables("MyProfile").Rows(0).Item(1)
        tblname.Text = ds.Tables("MyProfile").Rows(0).Item(2)
        tbuname.Text = ds.Tables("MyProfile").Rows(0).Item(3)
        cboutype.Text = ds.Tables("MyProfile").Rows(0).Item(4)
        tbcont.Text = ds.Tables("MyProfile").Rows(0).Item(5)
        tbaddr.Text = ds.Tables("MyProfile").Rows(0).Item(6)
    End Sub

    Private Sub frmAccountSet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Populated()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If tbuname.Text = "" Or tbfname.Text = "" Or tblname.Text = "" Or tbcont.Text = "" Or cboutype.Text = " ..." Or tbaddr.Text = "" Or tbpword.Text = "" Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Fill-up all the fields!", 3000)
            Exit Sub
        End If
        CheckPass()
    End Sub

    Public Sub CheckPass()
        connected()
        Dim _uid As String = lbluid.Text
        Dim _pass As String = tbpword.Text.Trim
        sql = "SELECT * FROM tblUser WHERE id_user = '" & _uid & "' AND Pword = '" & _pass & "' "
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)
        Dim sdr As OleDb.OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            sql = "UPDATE tbluser SET uname = '" & tbuname.Text.ToLower & "', fname = '" & tbfname.Text & "' , lname = '" & tblname.Text & "', contactno = '" & tbcont.Text & "', utype = '" & cboutype.Text & "', addr = '" & tbaddr.Text & "', pword = '" & tbpword.Text & "'" & _
              " WHERE id_user = '" & lbluid.Text & "'"
            cmd = New System.Data.OleDb.OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Successfully Updated!", 3000)
            tbpword.Text = ""

        Else
            tbpword.Text = ""
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Invalid Password!", 4000)
            lblpword.GlowState = True
            lblpword.GlowColor = Color.Red
            tbpword.Focus()
            tbpword.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub GhostButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GhostButton2.Click
        frmChangepword.Show()
        frmChangepword.TopMost = True
    End Sub

    Private Sub btntype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TopMost = False
        Dim otherM As String = InputBox("Please Input Another User Type!", MsgBoxStyle.OkOnly)
        If otherM = "" Then
            Exit Sub
        End If
        cboutype.Items.Add(otherM)
        cboutype.Text = otherM
        Me.TopMost = True
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

    Private Sub SlcClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlcClose1.Click
        _mod.frmfade(Me, 10)
        Me.Close()
    End Sub
End Class