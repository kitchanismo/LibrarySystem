Imports kitchan

Public Class frmMain
    Private Sub GhostButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub GhostButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub


    Dim returns As Boolean = False
    Dim x As Integer
    Private Sub FlatToggle1_CheckedChanged(ByVal sender As System.Object) Handles FlatToggle1.CheckedChanged
        If FlatToggle1.Checked = False Then
            FlatToggle1.Checked = True
            frmLogin.Show()
            frmLogin.TopMost = True
            frmLogin.tbuname.Focus()
        Else
            FlatToggle1.Checked = False
            Me.TopMost = True
            x = MsgBox("Are you really want to logout?", MsgBoxStyle.YesNo)
            If x = MsgBoxResult.Yes Then
                toggle()
                FlatToggle1.Checked = True
                closeforms()

            End If
            Me.TopMost = False
        End If
    End Sub
    Dim xtype As String
    Dim itype As String = ""

    Public Sub useraccess()
        Dim utype As String = ""
        sql = "select * from tblUser where uname = '" & frmLogin.tbuname.Text & "'"
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)
        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader()
        Do While dr.Read()
            utype = dr(4)
        Loop
        If utype = "Administrator" Then
            xtype = " - " & utype
            MenuEnabled(True, True, True, True, True, True)
            UserToolStripMenuItem.Enabled = True
        ElseIf utype = "Librarian" Then
            xtype = " - " & utype
            MenuEnabled(True, True, False, True, True, True)
            UserToolStripMenuItem.Enabled = False
        Else
            xtype = " - " & utype
            MenuEnabled(False, False, False, True, True, True)
            UserToolStripMenuItem.Enabled = False
        End If

    End Sub

    Public Sub toggle()
        If returns = False Then
            _mod.Forward2(FlatToggle1, FlatToggle1.Location.X, (Me.Width - FlatToggle1.Width) - 3)
            returns = True
            ToolTip1.SetToolTip(FlatToggle1, "Click to Logout")
            useraccess()
            lblutype.Text = frmLogin.tbuname.Text & xtype & " || "
            Timer1.Start()
            Label1.Text = frmLogin.tbuname.Text
            FlatToggle1.Checked = False
            utype.Visible = True
            PictureBox1.Visible = True
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "WELCOME " & frmLogin.tbuname.Text.ToUpper & "!", 3000)

        Else
            _mod.Back2()
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Logging off ...", 3000)
            ToolTip1.SetToolTip(FlatToggle1, "Click to Login")
            MenuEnabled(False, False, False, False, False, False)
            utype.Visible = False
            PictureBox1.Visible = False
            returns = False
            Timer1.Stop()
        End If
    End Sub

    Public Sub MenuEnabled(ByVal maint As Boolean,
                           ByVal trans As Boolean,
                           ByVal rep As Boolean,
                           ByVal sbook As Boolean,
                           ByVal user As Boolean,
                           ByVal acc As Boolean)
        FileMaintenenceToolStripMenuItem.Enabled = maint
        TransactionStripMenuItem.Enabled = trans
        ReportsToolStripMenuItem.Enabled = rep
        SearchBooksToolStripMenuItem.Enabled = sbook
        UserLogToolStripMenuItem.Enabled = user
        AccountSettingsToolStripMenuItem.Enabled = acc
        ' LogUserToolStripMenuItem1.Enabled = log
    End Sub
    Private Sub BooksToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksToolStripMenuItem1.Click
        frmBookMaint.Show()
        frmBookMaint.TopMost = True
    End Sub

    Private Sub AuthorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAuthorMaint.Show()
        frmAuthorMaint.TopMost = True
    End Sub

    Private Sub MemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        frmUserMaint.Show()
        frmUserMaint.TopMost = True
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuEnabled(False, False, False, False, False, False)
    End Sub


    Private Sub SearchBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBooksToolStripMenuItem.Click
        frmBooks.Show()
        frmBooks.TopMost = True
    End Sub



    Private Sub LogUserToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCurrentUserLog.Show()
        frmCurrentUserLog.TopMost = True
    End Sub

    Private Sub FlatToggle1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles FlatToggle1.MouseHover
        _mod.Shake(FlatToggle1, 8, 4, 1)
    End Sub

    Public Sub closeforms()
        frmAuthorMaint.Close()
        frmBookMaint.Close()
        frmBooks.Close()
        frmBorrowBooks.Close()
        frmDueBooks.Close()
        frmIssuance.Close()
        frmLogin.Close()
        frmCurrentUserLog.Close()
        frmReturnBooks.Close()
        frmSearchBorrower.Close()
        frmUserMaint.Close()
        frmDateTimeSet.Close()
        frmAccountSet.Close()
        frmReturnedBooks.Close()
        frmUserLogs.Close()
    End Sub

    Private Sub FlatAlertBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UserLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserLogToolStripMenuItem.Click
        frmCurrentUserLog.Show()
    End Sub

    Private Sub BorrowedBooksToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowedBooksToolStripMenuItem1.Click
        frmBorrowBooks.Show()
        frmBorrowBooks.TopMost = True
    End Sub

    Private Sub ReturnedBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnedBooksToolStripMenuItem.Click
        frmReturnedBooks.Show()
        frmReturnedBooks.TopMost = True
    End Sub

    Private Sub DueBooksToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DueBooksToolStripMenuItem1.Click
        frmDueBooks.Show()
        frmDueBooks.TopMost = True
    End Sub

    Private Sub IssuanceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssuanceToolStripMenuItem1.Click
        frmIssuance.Show()
        frmIssuance.TopMost = True
    End Sub

    Private Sub ReturnBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnBookToolStripMenuItem.Click
        frmReturnBooks.Show()
        frmReturnBooks.TopMost = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        utype.Text = lblutype.Text & Format(Now, "short date") & " - " & TimeOfDay
    End Sub

    Private Sub FlatToggle1_CheckedChanged_1(ByVal sender As System.Object)

    End Sub

    Private Sub lblsetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDateTimeSet.Show()
        frmDateTimeSet.TopMost = True
    End Sub


    Private Sub AccountSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountSettingsToolStripMenuItem.Click
        frmAccountSet.Show()
        frmAccountSet.TopMost = True
    End Sub

    Private Sub UserLogsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserLogsToolStripMenuItem.Click
        frmUserLogs.Show()
        frmUserLogs.TopMost = True
    End Sub



    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        FlatToggle1.Checked = False
        Dim x As Integer
        Me.TopMost = True
        x = MsgBox("Are you really want to logout?", MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            FlatToggle1.Checked = True
            closeforms()
            toggle()
            Me.TopMost = False
        End If
        Me.TopMost = False
    End Sub

    Private Sub SlcMin1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlcMin1.Click
        _mod.frmfade(Me, 30)
        Me.WindowState = FormWindowState.Minimized
        Me.Opacity = 100
    End Sub

    Private Sub SlcClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlcClose1.Click
        Dim x As Integer
        Me.TopMost = True
        x = MsgBox("Are you really want to exit?", MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Shutting down ...", 4000)
            Timer2.Start()
        End If
    End Sub
    Dim ctr As Integer
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ctr += 1
        If ctr = 40 Then
            _mod.frmfade(Me, 30)
            End
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
