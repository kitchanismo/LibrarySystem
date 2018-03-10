Module modCon
    Dim conString = "zueOfEY27C5tJS/Yo6kVrcVxotwgzOpRm8kd3Yghq4oSTX6XNh70rNMCyvfe+xmBWjX5uX5NxlgyYXtE0ELU0UKO6PC2VupmXx2Vzgz9+vA="
   
    Public Sub connected()
        With con
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = _mod.Decrypt(conString)
            .Open()
        End With
    End Sub
End Module