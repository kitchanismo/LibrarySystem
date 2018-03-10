
Public Class frmSplash
    Dim _ctr As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        _ctr += 1
        If _ctr = 5 Then
            Me.TopMost = True
            CheckDb()
            frmLogin.Show()
            frmMain.Show()
            frmLogin.tbuname.Focus()
            frmMain.PictureBox2.Visible = False
        ElseIf _ctr = 10 Then
            _mod.frmfade(Me, 70)
            frmLogin.TopMost = True
            frmMain.PictureBox2.Visible = True
            Me.Hide()
            _ctr = 0
            Timer1.Stop()
        End If
    End Sub
    Public Sub CheckDb()
        Dim x As String = Application.StartupPath & "\LibDB.mdb"
        If IO.File.Exists(x) = False Then
            MsgBox("Database is missing!", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class