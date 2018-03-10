Public Class frmChangepword

    Private Sub frmChangepword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GhostButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
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

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If tbnpword.Text <> tbcpword.Text Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Password not match!", 4000)
            lblpword.GlowState = True
            lblpword.GlowColor = Color.Red
            tbpword.Focus()
            tbpword.Text = ""
            tbnpword.Text = ""
            tbcpword.Text = ""
            Exit Sub
        End If
        CheckPass()
    End Sub
    Public Sub CheckPass()
        connected()
        Dim _uid As String = frmAccountSet.lbluid.Text
        Dim _pass As String = tbpword.Text.Trim
        sql = "SELECT * FROM tblUser WHERE id_user = '" & _uid & "' AND Pword = '" & _pass & "' "
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)
        Dim sdr As OleDb.OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            sql = "UPDATE tbluser SET pword = '" & tbnpword.Text.ToLower & "'" & _
                " WHERE id_user = '" & frmAccountSet.lbluid.Text & "'"
            cmd = New System.Data.OleDb.OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Successfully Updated!", 3000)
            tbnpword.Text = ""
            tbcpword.Text = ""
            tbpword.Text = ""
            lblpword.GlowState = False
        Else
            tbnpword.Text = ""
            tbcpword.Text = ""
            tbpword.Text = ""
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Invalid Password!", 4000)
            lblpword.GlowState = True
            lblpword.GlowColor = Color.Red
            tbpword.Focus()

            Exit Sub
        End If
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
    Private Sub tnbpword_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbnpword.Enter
        lblnpword.GlowState = True
    End Sub

    Private Sub tbnpword_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbnpword.Leave
        lblnpword.GlowState = False
    End Sub

    Private Sub SlcClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlcClose1.Click
        _mod.frmfade(Me, 10)
        Me.Close()
    End Sub
End Class