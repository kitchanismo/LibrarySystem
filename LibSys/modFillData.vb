Module modFillData


    Public Sub FillBorrowBooks(ByVal Listview1 As ListView)
        connected()
        With Listview1
            .Items.Clear()
            sql = " SELECT * FROM tblBorrow order by id"
            cmd = New OleDb.OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            While (dr.Read())
                With Listview1.Items.Add(dr("ID"))
                    .SubItems.Add(dr("bid"))
                    .SubItems.Add(dr("btitle"))
                    .SubItems.Add(dr("uname"))
                    .SubItems.Add(dr("isdate"))
                    .SubItems.Add(dr("duedate"))
                End With
            End While
        End With
    End Sub

    Public Sub FillDueBooks(ByVal Listview1 As ListView)
        connected()
        With Listview1
            .Items.Clear()
            sql = " SELECT * FROM tblBorrow where ((duedate)<=Date()) order by id"
            cmd = New OleDb.OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            While (dr.Read())
                With Listview1.Items.Add(dr("ID"))
                    .SubItems.Add(dr("bid"))
                    .SubItems.Add(dr("btitle"))
                    .SubItems.Add(dr("uname"))
                    .SubItems.Add(dr("isdate"))
                    .SubItems.Add(dr("duedate"))
                End With
            End While
        End With
    End Sub

    Public Sub FillBooks(ByVal Listview1 As ListView)
        connected()
        With Listview1
            .Items.Clear()
            sql = " SELECT * FROM tblBooks order by id_book"
            cmd = New OleDb.OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            While (dr.Read())
                With Listview1.Items.Add(dr("ID_Book"))
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
        End With
    End Sub


    Public Sub FillMembers(ByVal Listview1 As ListView)
        connected()
        With Listview1
            .Items.Clear()
            sql = " SELECT * FROM tblUser order by id_user"
            cmd = New OleDb.OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            While (dr.Read())
                With Listview1.Items.Add(dr("ID_user"))
                    .SubItems.Add(dr("uname"))
                    .SubItems.Add(dr("fname"))
                    .SubItems.Add(dr("lname"))
                End With
            End While
        End With
    End Sub

    Public Sub FillAuthor(ByVal Listview1 As ListView)
        connected()
        With Listview1
            .Items.Clear()
            sql = " SELECT * FROM tblAuthor order by id"
            cmd = New OleDb.OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            While (dr.Read())
                With Listview1.Items.Add(dr("ID"))
                    .SubItems.Add(dr("booktitle"))
                    .SubItems.Add(dr("authorname"))
                End With
            End While
        End With
    End Sub

    Public Sub FillUserMaint(ByVal Listview1 As ListView)
        connected()
        With Listview1
            .Items.Clear()
            sql = " SELECT * FROM tblUser order by id_user"
            cmd = New OleDb.OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            While (dr.Read())
                With Listview1.Items.Add(dr("ID_user"))
                    .SubItems.Add(dr("uname"))
                    .SubItems.Add(dr("fname"))
                    .SubItems.Add(dr("lname"))
                    .SubItems.Add(dr("utype"))
                    .SubItems.Add(dr("contactno"))
                    .SubItems.Add(dr("addr"))
                    .SubItems.Add(dr("pword"))
                End With
            End While
        End With
    End Sub
    Public Sub FillUser(ByVal Listview1 As ListView)
        connected()
        With Listview1
            .Items.Clear()
            sql = " SELECT * FROM tblUser order by id_user"
            cmd = New OleDb.OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            While (dr.Read())
                With Listview1.Items.Add(dr("ID_user"))
                    .SubItems.Add(dr("uname"))
                    .SubItems.Add(dr("fname"))
                    .SubItems.Add(dr("lname"))
                End With
            End While
        End With
    End Sub
    Public Sub FillUserLog(ByVal Listview1 As ListView)
        connected()
        With Listview1
            .Items.Clear()
            sql = " SELECT * FROM tblUserlog order by id_log"
            cmd = New OleDb.OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            While (dr.Read())
                With Listview1.Items.Add(dr("ID_log"))
                    .SubItems.Add(dr("uid"))
                    .SubItems.Add(dr("uname"))
                    .SubItems.Add(dr("stat"))
                    .SubItems.Add(dr("entry_date"))
                    .SubItems.Add(dr("entry_time"))
                    .SubItems.Add(dr("time_exit"))
                    .SubItems.Add(dr("bagno"))
                End With
            End While
        End With
    End Sub
    Public Sub FillCurrentUserLog(ByVal Listview1 As ListView)
        connected()
        With Listview1
            .Items.Clear()
            sql = " SELECT * FROM tblUserlog where entry_date = date() order by id_log"
            cmd = New OleDb.OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            While (dr.Read())
                With Listview1.Items.Add(dr("ID_log"))
                    .SubItems.Add(dr("uid"))
                    .SubItems.Add(dr("uname"))
                    .SubItems.Add(dr("stat"))
                    .SubItems.Add(dr("entry_date"))
                    .SubItems.Add(dr("entry_time"))
                    .SubItems.Add(dr("time_exit"))
                    .SubItems.Add(dr("bagno"))
                End With
            End While
        End With
    End Sub

    Public Sub FillReturnedBooks(ByVal Listview1 As ListView)
        connected()
        With Listview1
            .Items.Clear()
            sql = " SELECT * FROM tblreturn order by id_return"
            cmd = New OleDb.OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            While (dr.Read())
                With Listview1.Items.Add(dr("ID_return"))
                    .SubItems.Add(dr("id_issuance"))
                    .SubItems.Add(dr("btitle"))
                    .SubItems.Add(dr("member"))
                    .SubItems.Add(dr("remarks"))
                    .SubItems.Add(dr("fine"))
                    .SubItems.Add(dr("datereturn"))
                End With
            End While
        End With
    End Sub
   

    'Populate the CBO's
    Public Sub FillCBO(ByVal cbo As ComboBox, ByVal tbl As String, ByVal col As String)
        connected()
        Dim _hide As String = "eGjPbbct658VXU3pceFFvXJd3SmCw+lajKANidMTWX0="
        sql = _mod.Decrypt(_hide) & col & " FROM " & tbl & " "
        cmd = New OleDb.OleDbCommand(sql, con)
        cbo.Items.Clear()
        dr = cmd.ExecuteReader()
        While (dr.Read())
            With cbo.Items.Add(dr(col))
            End With
        End While
    End Sub


End Module

