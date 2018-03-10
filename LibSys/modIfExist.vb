Module modIfExist
    Public Function DoesExist(ByVal str As String, ByVal tbl As String, ByVal field As String)
        Call connected()
        Dim q As String = "CagVwj7zrH5P8AwB8kODxg=="
        Dim sql As String = "Select " & _mod.Decrypt(q) & " FROM " & tbl & " WHERE " & field & " = '" & str & "'"

        Dim cmd As New OleDb.OleDbCommand(sql, con)

        Dim rows As Integer = cmd.ExecuteScalar()

        If rows > 0 Then

            Return True
        Else

            Return False
        End If

    End Function
End Module
