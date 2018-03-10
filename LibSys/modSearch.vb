Module modSearch

    Public Sub SearchBooks(ByVal lv As ListView, ByVal tbsearch As String, ByVal lblresult As Label)
        connected()
        Dim result As String = ""
        Dim cond As String = ""
        Dim key As String = "'%" & tbsearch & "%'"
        cond = "booktitle LIKE " & key & " OR category LIKE " & key & " OR author LIKE " & key & " OR vendor LIKE " & key & " OR id_book LIKE " & key & " OR pubdate LIKE " & key & " OR publisher LIKE " & key & ""
        sql = " SELECT * FROM (tblBooks) WHERE " & cond & " order by id_book"
        ds.Clear()
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Search")
        row = ds.Tables("Search").Rows.Count
        lblresult.Text = row & " Result/s Found"
        cmd = New OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("ID_Book"))
                .SubItems.Add(dr("booktitle"))
                .SubItems.Add(dr("category"))
                .SubItems.Add(dr("author"))
                .SubItems.Add(dr("vendor"))
                .SubItems.Add(dr("publisher"))
                .SubItems.Add(dr("pubdate"))
                .SubItems.Add(dr("avbook"))
                .SubItems.Add(dr("isbook"))
                .SubItems.Add(dr("tobook"))
            End With
        End While
    End Sub

    Public Sub SearchBorrow(ByVal lv As ListView, ByVal tbsearch As String, ByVal lblresult As Label)
        connected()
        Dim result As String = ""
        Dim cond As String = ""
        Dim key As String = "'%" & tbsearch & "%'"
        cond = "btitle LIKE " & key & " OR uname LIKE " & key & "OR ID LIKE " & key & "OR bid LIKE " & key & ""
        sql = " SELECT * FROM (tblBorrow) WHERE " & cond & " order by id"
        ds.Clear()
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Search")
        row = ds.Tables("Search").Rows.Count
        lblresult.Text = row & " Result/s Found"
        cmd = New OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("ID"))
                .SubItems.Add(dr("bid"))
                .SubItems.Add(dr("btitle"))
                .SubItems.Add(dr("uname"))
                .SubItems.Add(dr("isdate"))
                .SubItems.Add(dr("duedate"))
            End With
        End While
    End Sub

    Public Sub SearchMember(ByVal lv As ListView, ByVal tbsearch As String, ByVal lblresult As Label)
        connected()
        Dim result As String = ""
        Dim cond As String = ""
        Dim key As String = "'%" & tbsearch & "%'"
        cond = "uname LIKE " & key & " OR lname LIKE " & key & "OR fname LIKE " & key & "OR id_user LIKE " & key & ""
        sql = " SELECT * FROM (tbluser) WHERE " & cond & " order by id_user"
        ds.Clear()
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Search")
        row = ds.Tables("Search").Rows.Count
        lblresult.Text = row & " Result/s Found"
        cmd = New OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("ID_user"))
                .SubItems.Add(dr("uname"))
                .SubItems.Add(dr("fname"))
                .SubItems.Add(dr("lname"))
            End With
        End While
    End Sub

    Public Sub SearchUser(ByVal lv As ListView, ByVal tbsearch As String, ByVal lblresult As Label)
        connected()
        Dim result As String = ""
        Dim cond As String = ""
        Dim key As String = "'%" & tbsearch & "%'"
        cond = "uname LIKE " & key & " OR fname LIKE " & key & "OR lname LIKE " & key & ""
        sql = " SELECT * FROM (tblUser) WHERE " & cond & " order by id_user"
        ds.Clear()
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Search")
        row = ds.Tables("Search").Rows.Count
        lblresult.Text = row & " Result/s Found"
        cmd = New OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("id_user"))
                .SubItems.Add(dr("uname"))
                .SubItems.Add(dr("fname"))
                .SubItems.Add(dr("lname"))
            End With
        End While
    End Sub
    Public Sub SearchUserLog(ByVal lv As ListView, ByVal str As String, ByVal lblresult As Label)
        connected()
        Dim result As String = ""
        Dim cond As String = ""
        Dim key As String = "'%" & str & "%'"
        cond = "entry_date like " & key & " OR uid like " & key & " OR uname like " & key & " OR id_log like " & key & ""
        sql = " SELECT * FROM (tblUserLog) WHERE " & cond & " order by id_log"
        ds.Clear()
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Search")
        row = ds.Tables("Search").Rows.Count
        lblresult.Text = row & " Result/s Found"
        cmd = New OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("ID_log"))
                .SubItems.Add(dr("uid"))
                .SubItems.Add(dr("uname"))
                .SubItems.Add(dr("stat"))
                .SubItems.Add(dr("entry_date"))
                .SubItems.Add(dr("entry_time"))
                .SubItems.Add(dr("time_exit"))
                .SubItems.Add(dr("bagno"))
            End With
        End While
    End Sub
    Public Sub SearchUserMaint(ByVal lv As ListView, ByVal tbsearch As String, ByVal lblresult As Label)
        connected()
        Dim result As String = ""
        Dim cond As String = ""
        Dim key As String = "'%" & tbsearch & "%'"
        cond = "uname LIKE " & key & " OR fname LIKE " & key & "OR lname LIKE " & key & "OR Id_user LIKE " & key & "OR contactno LIKE " & key & "OR addr LIKE " & key & ""
        sql = " SELECT * FROM (tblUser) WHERE " & cond & " order by id_user"
        ds.Clear()
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Search")
        row = ds.Tables("Search").Rows.Count
        lblresult.Text = row & " Result/s Found"
        cmd = New OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("ID_user"))
                .SubItems.Add(dr("uname"))
                .SubItems.Add(dr("fname"))
                .SubItems.Add(dr("lname"))
                .SubItems.Add(dr("utype"))
                .SubItems.Add(dr("contactno"))
                .SubItems.Add(dr("addr"))
                .SubItems.Add(dr("pword"))
            End With
        End While
    End Sub

    Public Sub SearchAuthor(ByVal lv As ListView, ByVal tbsearch As String, ByVal lblresult As Label)
        connected()
        Dim result As String = ""
        Dim cond As String = ""
        Dim key As String = _mod.Decrypt(_hide) & tbsearch & "%'"
        cond = "booktitle LIKE " & key & " OR authorname LIKE " & key & ""
        sql = " SELECT * FROM (tblauthor) WHERE " & cond & " order by id"
        ds.Clear()
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Search")
        row = ds.Tables("Search").Rows.Count
        lblresult.Text = row & " Result/s Found"
        cmd = New OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("id"))
                .SubItems.Add(dr("booktitle"))
                .SubItems.Add(dr("authorname"))
            End With
        End While
    End Sub

    Public Sub SearchReturn(ByVal lv As ListView, ByVal tbsearch As String, ByVal lblresult As Label)
        connected()
        Dim result As String = ""
        Dim cond As String = ""
        Dim key As String = "'%" & tbsearch & "%'"
        cond = "btitle LIKE " & key & " OR id_return LIKE " & key & " OR id_issuance LIKE " & key & "OR id_member LIKE " & key & ""
        sql = " SELECT * FROM (tblreturn) WHERE " & cond & " order by id_return"
        ds.Clear()
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Search")
        row = ds.Tables("Search").Rows.Count
        lblresult.Text = row & " Result/s Found"
        cmd = New OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("ID_return"))
                .SubItems.Add(dr("id_issuance"))
                .SubItems.Add(dr("btitle"))
                .SubItems.Add(dr("member"))
                .SubItems.Add(dr("remarks"))
                .SubItems.Add(dr("fine"))
                .SubItems.Add(dr("datereturn"))
            End With
        End While
    End Sub
End Module
