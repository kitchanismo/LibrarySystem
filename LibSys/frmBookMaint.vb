Public Class frmBookMaint

    Private Sub frmBookMaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillBooks(lv)
        FillCBO(cbocat, "tblbooks", "category")
        FillCBO(cboaut, "tblbooks", "author")
        FillCBO(cboven, "tblbooks", "vendor")
        FillCBO(cbopub, "tblbooks", "publisher")
    End Sub

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

    Private Sub tbtitle_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbtitle.Enter
        lbltitle.GlowState = True
    End Sub

    Private Sub cbocat_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbocat.Enter
        lblcat.GlowState = True
    End Sub

    Private Sub cboaut_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboaut.Enter
        lblaut.GlowState = True
    End Sub

    Private Sub cboven_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboven.Enter
        lblvendor.GlowState = True
    End Sub

    Private Sub dtppub_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtppub.Enter
        lbldate.GlowState = True
    End Sub
    Private Sub cbopub_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbopub.Enter
        lblpublisher.GlowState = True
    End Sub
    Private Sub tbqyt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbavai.Enter, tbis.Enter, tbtot.Enter
        lblqty.GlowState = True
    End Sub

    Private Sub tbavai_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbavai.KeyPress, tbis.KeyPress, tbtot.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Number Only!", 3000)
        End If
    End Sub


    Private Sub tbqty_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbavai.Leave, tbis.Leave, tbtot.Leave
        lblqty.GlowState = False
    End Sub
    Private Sub dtppub_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtppub.Leave
        lbldate.GlowState = False
    End Sub
    Private Sub tbtitle_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbtitle.Leave
        lbltitle.GlowState = False
    End Sub
    Private Sub cbocat_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbocat.Leave
        lblcat.GlowState = False
    End Sub
    Private Sub cboaut_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboaut.Leave
        lblaut.GlowState = False
    End Sub
    Private Sub cboven_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboven.Leave
        lblvendor.GlowState = False
    End Sub
    Private Sub cbopub_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbopub.Leave
        lblpublisher.GlowState = False
    End Sub

    Private Sub lv_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv.MouseClick
        With lv.SelectedItems(0)
            lblid.Text = .SubItems(0).Text
            tbtitle.Text = .SubItems(1).Text
            cbocat.Text = .SubItems(2).Text
            cboaut.Text = .SubItems(3).Text
            cboven.Text = .SubItems(4).Text
            cbopub.Text = .SubItems(5).Text
            dtppub.Text = .SubItems(6).Text
            tbavai.Text = .SubItems(7).Text
            tbis.Text = .SubItems(8).Text
            tbtot.Text = .SubItems(9).Text
        End With
        grupboxenabled(True)
    End Sub

    Dim _return As Boolean = False
    Public Sub _toggle()
        If _return = False Then
            _mod.Forward(btnrefresh, btnrefresh.Location.X, (Me.Width - btnrefresh.Width) - 995)
            _return = True
        Else
            _mod.Back()
            _return = False
        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If btnadd.Text = "Add" Then
            btnadd.Text = "Save"
            btnadd.Color = Color.FromArgb(205, 150, 0)
            btnrefresh.Text = "Cancel"
            btndelete.Visible = False
            btnclear.Visible = False
            btnedit.Visible = False
            grupboxenabled(True)
            cleardata()
            GenIDBook()
            tbtitle.Focus()
            tbtitle.SelectAll()
            _toggle()
        Else
            If tbtitle.Text = "..." Or cbocat.Text = " ..." Or cboaut.Text = "..." Or cboven.Text = " ..." Or tbavai.Text = "" Then
                frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Fill-up all the fields!", 3000)
                Exit Sub
            ElseIf DoesExist(tbtitle.Text, "tblbooks", "booktitle") Then
                frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Book " & tbtitle.Text.ToUpper & " Exist! Please try another one.", 3000)
                Exit Sub
            End If
            connected()
            sql = "INSERT INTO tblBooks VALUES ('" & lblid.Text & "','" & tbtitle.Text.ToLower & "','" & cbocat.Text.ToLower & "','" & cboaut.Text.ToLower & "','" & cboven.Text.ToLower & "','" & cbopub.Text.ToLower & "','" & dtppub.Text & "','" & tbavai.Text & "','" & tbis.Text & "','" & tbtot.Text & "')"
            cmd = New System.Data.OleDb.OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            FillBooks(lv)
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Successfully Saved!", 3000)
            cleardata()
            GenIDBook()
        End If
    End Sub

    Public Sub GenIDBook()
        connected()
        Dim _id As String = ""
        sql = "SELECT " & _mod.Decrypt(_x) & "(ID_book) FROM tblbooks"
        cmd = New System.Data.OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                _id = dr.Item(0).ToString.Substring(3) + 1
            Loop
        End If
        lblid.Text = "BK-" & _id
    End Sub

    Public Sub grupboxenabled(ByVal mode As Boolean)
        groupbook.Enabled = mode
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
       
            If tbtitle.Text = "..." Or cbocat.Text = " ..." Or cboaut.Text = " ..." Or cboven.Text = " ..." Then
                frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Fill-up all the fields!", 3000)
                Exit Sub
            End If
            connected()
            sql = "UPDATE tblbooks SET booktitle = '" & tbtitle.Text.ToLower & "', category = '" & cbocat.Text.ToLower & "' , author = '" & cboaut.Text & "', vendor = '" & cboven.Text & "', pubdate = '" & dtppub.Text & "', avbook = " & tbavai.Text & ", isbook = " & tbis.Text & ", tobook = " & tbtot.Text & ", publisher = '" & cbopub.Text & "'" & _
                " WHERE id_book = '" & lblid.Text & "'"
            cmd = New System.Data.OleDb.OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Successfully Updated!", 3000)
            FillBooks(lv)
    End Sub

    Public Sub cleardata()
        lblid.Text = "..."
        tbtitle.Text = ""
        cbocat.Text = " ..."
        cboaut.Text = " ..."
        cboven.Text = " ..."
        cbopub.Text = " ..."
        tbavai.Text = ""
        tbis.Text = ""
        tbtot.Text = ""
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cleardata()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        connected()
        Dim i As Integer
        sql = "DELETE FROM tblbooks WHERE Id_book = '" & lblid.Text & "'"
        If lblid.Text = "" Then
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Please select from the list!", 3000)
            Exit Sub
        End If
        cmd = New OleDb.OleDbCommand(sql, con)
        i = MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            cmd.ExecuteNonQuery()
            cleardata()
            FillBooks(lv)
            frmMain.FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Successfully Deleted!", 3000)
            grupboxenabled(False)
        End If

    End Sub


    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        If btnrefresh.Text = "Cancel" Then
            btnadd.Text = "Add"
            btnadd.Color = Color.Empty
            btnrefresh.Text = "Refresh"
            btndelete.Visible = True
            btnclear.Visible = True
            btnedit.Visible = True
            grupboxenabled(False)
            cleardata()
            _toggle()
        Else
            FillBooks(lv)
            tbsearch.Text = " Search ..."
        End If
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

    Private Sub btncat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncat.Click
        Me.TopMost = False
        Dim otherM As String = InputBox("Please Input Another Category!", MsgBoxStyle.OkOnly)
        If otherM = "" Then
            Exit Sub
        End If
        cbocat.Items.Add(otherM)
        cbocat.Text = otherM
        Me.TopMost = True
    End Sub

    Private Sub btnaut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaut.Click
        Me.TopMost = False
        Dim otherM As String = InputBox("Please Input Another Author!", MsgBoxStyle.OkOnly)
        If otherM = "" Then
            Exit Sub
        End If
        cboaut.Items.Add(otherM)
        cboaut.Text = otherM
        Me.TopMost = True
    End Sub

    Private Sub btnven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnven.Click
        Me.TopMost = False
        Dim otherM As String = InputBox("Please Input Another Sponsor!", MsgBoxStyle.OkOnly)
        If otherM = "" Then
            Exit Sub
        End If
        cboven.Items.Add(otherM)
        cboven.Text = otherM
        Me.TopMost = True
    End Sub

    Private Sub btnpub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpub.Click
        Me.TopMost = False
        Dim otherM As String = InputBox("Please Input Another Publisher!", MsgBoxStyle.OkOnly)
        If otherM = "" Then
            Exit Sub
        End If
        cbopub.Items.Add(otherM)
        cbopub.Text = otherM
        Me.TopMost = True
    End Sub


    Private Sub SlcClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlcClose1.Click
        _mod.frmfade(Me, 10)
        Me.Close()
    End Sub


  
End Class