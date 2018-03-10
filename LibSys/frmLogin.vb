Public Class frmLogin
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

    Private Sub GhostButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _mod.frmfade(Me, 20)
        Me.Close()
    End Sub

    Private Sub tbuname_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbuname.Enter
        lbluname.GlowState = True
        lbluname.GlowColor = Color.DarkOrange
    End Sub

    Private Sub tbpword_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbpword.Enter
        lblpword.GlowState = True
        lblpword.GlowColor = Color.DarkOrange
    End Sub

    Private Sub tbpword_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbpword.Leave
        lblpword.GlowState = False
    End Sub

    Private Sub tbuname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbuname.KeyDown, tbpword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            validateLogin()
        End If
    End Sub

    Private Sub tbuname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbuname.Leave
        lbluname.GlowState = False
    End Sub

    Private Sub GhostButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GhostButton2.Click
        validateLogin()
    End Sub

    Public Sub validateLogin()
        If tbuname.Text = "" Then
            lbluname.GlowState = True
            lbluname.GlowColor = Color.Red
            Exit Sub
        End If
        If tbpword.Text = "" Then
            lblpword.GlowState = True
            lblpword.GlowColor = Color.Red
            Exit Sub
        End If

        If _trial = 0 Then
            MsgBox("Administrator Blocked!", MsgBoxStyle.Critical)
            End
            Exit Sub
        End If
        CheckUser()
    End Sub

    Dim _trial As Integer = 4
    Public Sub CheckUser()
        connected()
        Dim _user As String = tbuname.Text.Trim
        Dim _pass As String = tbpword.Text.Trim
        sql = "SELECT * FROM tblUser WHERE Uname = '" & _user & "' AND Pword = '" & _pass & "' "
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)
        Dim sdr As OleDb.OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            _mod.frmfade(Me, 10)
            frmMain.toggle()
            Me.Close()
        Else
            tbpword.Text = ""
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Invalid Username/Password! You Have " & _trial & " Left/s ", 4000)
            _trial -= 1
            Exit Sub
        End If
    End Sub

    Public Sub appendUser()
        Dim dt As New DataTable
        connected()
        ds.Tables.Add(dt)
        Dim sql As String = "select uname from tbluser"
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        tbuname.AutoCompleteCustomSource.Clear()
        For Each r In dt.Rows
            tbuname.AutoCompleteCustomSource.Add(r.Item(0))
        Next

    End Sub


    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        appendUser()
        _mod.SetWindowShadow(Me.Handle)
    End Sub

  

    Private Sub SlcClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlcClose1.Click
        _mod.frmfade(Me, 10)
        Me.Close()
    End Sub
End Class