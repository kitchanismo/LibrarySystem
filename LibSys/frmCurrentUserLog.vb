Public Class frmCurrentUserLog
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

    Public Sub GenIDLog()
        connected()
        Dim _id As String = Nothing
        sql = "SELECT " & _mod.Decrypt(_x) & "(ID_log) FROM tbluserlog"
        cmd = New System.Data.OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                _id = dr.Item(0).ToString.Substring(4) + 1
            Loop
        End If
        lbllog.Text = "LOG-" & _id
    End Sub

    Private Sub frmUserLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillUser(lv)
        FillCurrentUserLog(lvlog)
        GenIDLog()
        lbledate.Text = Format(Now, "short date")
        Timer1.Start()
    End Sub
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
    End Sub

    Private Sub tbsearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbsearch.KeyPress
        SearchUser(lv, tbsearch.Text.ToLower, lblresult)
        frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblresult.Text, 3000)
    End Sub

    Private Sub tbsearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbsearch.LostFocus
        tbsearch.Text = " Search ..."
    End Sub

    Private Sub tbsearch_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbsearch.MouseClick
        tbsearch.Focus()
        tbsearch.SelectAll()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbletime.Text = TimeOfDay
    End Sub

    Private Sub lv_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv.MouseClick
        With lv.SelectedItems(0)
            lbl2uid.Text = .SubItems(0).Text
            lbluname.Text = .SubItems(1).Text
        End With
    End Sub
    Private Sub lvlog_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvlog.MouseClick
        With lvlog.SelectedItems(0)
            lbl2log.Text = .SubItems(0).Text
            lbl2uid.Text = .SubItems(1).Text
            lbl2uname.Text = .SubItems(2).Text
            lbl2stat.Text = .SubItems(3).Text
            lbl2edate.Text = .SubItems(4).Text
            lbl2etime.Text = .SubItems(5).Text
            lbl2exit.Text = .SubItems(6).Text
            lbl2bag.Text = .SubItems(7).Text
        End With
        If lbl2stat.Text = "IN" Then
            lbl2stat.ForeColor = Color.Green
        Else
            lbl2stat.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If lbl2uid.Text = "..." Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Select from List!", 3000)
            Exit Sub
        ElseIf tbbag.Text = "" Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Enter Baggage No.!", 3000)
            tbbag.Focus()
            GLabel2.GlowState = True
            GLabel2.GlowColor = Color.Red
            Exit Sub
        End If
        Dim stat As String = "IN"
        Dim timeexit As String = "..."
        connected()
        sql = "INSERT INTO tbluserlog (id_log, uid, uname, entry_date, entry_time,  bagno, stat, time_exit) VALUES ('" & lbllog.Text & "','" & lbl2uid.Text.ToLower & "','" & lbluname.Text.ToLower & "','" & lbledate.Text.ToLower & "','" & lbletime.Text.ToLower & "','" & tbbag.Text & "','" & stat & "','" & timeexit & "')"
        cmd = New System.Data.OleDb.OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()
        FillUser(lv)
        frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Successfully Saved!", 3000)
        GenIDLog()
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GhostButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GhostButton2.Click
        FillUser(lv)
        GenIDLog()
    End Sub


    Private Sub GhostButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GhostButton4.Click
        FillCurrentUserLog(lvlog)
        cleardata()
    End Sub

    Public Sub cleardata()
        lbl2log.Text = "..."
        lbl2uid.Text = "..."
        lbl2uname.Text = "..."
        lbl2bag.Text = "..."
        lbl2edate.Text = "..."
        lbl2etime.Text = "..."
        lbl2exit.Text = "..."
        lbl2stat.Text = ""
        tbpword.Text = ""
    End Sub

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        If lbl2stat.Text = "OUT" Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Already Logout!", 3000)
            Exit Sub
        End If
        sql = "SELECT * FROM tblUser WHERE Uname = '" & lbl2uname.Text & "' AND Pword = '" & tbpword.Text & "' "
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)
        Dim sdr As OleDb.OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = False) Then
            tbpword.Text = ""
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Invalid Password!", 4000)
            tbpword.Focus()
            lblpword.GlowState = True
            lblpword.GlowColor = Color.Red
            Exit Sub
        End If
        connected()
        sql = "UPDATE tbluserlog SET stat = 'OUT', time_exit = '" & TimeOfDay & "'" & _
           " WHERE id_log = '" & lbl2log.Text & "'"
        cmd = New System.Data.OleDb.OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()
        FillUserLog(lvlog)
        frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Successfully Logout!", 3000)
        cleardata()
    End Sub


    Private Sub SlcClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlcClose1.Click
        _mod.frmfade(Me, 10)
        Me.Close()
    End Sub

    Private Sub GhostButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GhostButton1.Click
        If tbsearch.Text = "" Or tbsearch.Text = " Search ..." Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Type something!", 3000)
            Exit Sub
        End If
        SearchUser(lv, tbsearch.Text.ToLower, lblresult)
        frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblresult.Text, 3000)
    End Sub
End Class