Imports MySql.Data.MySqlClient
Module DBConnection
    Public Function strstconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;userid=root;password=;database=dbclinic")
    End Function

    Public strcon As MySqlConnection = strstconnection()

End Module
