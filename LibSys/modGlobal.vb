Imports kitchan
Public Module modGlobal
    Public con As New OleDb.OleDbConnection
    Public ds As New DataSet
    Public da As New OleDb.OleDbDataAdapter
    Public sql As String
    Public row As Integer
    Public dr As OleDb.OleDbDataReader
    Public cmd As New OleDb.OleDbCommand
    Public inc As Integer
    Public xpos As New Integer
    Public ypos As New Integer
    Public pos As New Point
    Public _mod As New vampiping
    Public _hide As String = "5XVjnnRvnoWU2Qrk/1VL/g=="
    Public _x As String = "mdDSxAUtOt2we10BmSoCVg=="
    Public utype As String = ""
End Module
