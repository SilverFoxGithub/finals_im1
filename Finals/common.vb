Imports MySql.Data.MySqlClient

Public Class common
    Public Shared myDBConnection As MySqlConnection

    Public Shared Function getDBConnectionX() As MySqlConnection

        myDBConnection = New MySqlConnection(
            "Database=finals;" &
            "Data Source=localhost;" &
            "User id=root;" &
            "Password=password;" &
            "Port=3306;Command Timeout=600;")
        Return myDBConnection
    End Function

    Friend Shared Function GetConnectionString() As String
        Throw New NotImplementedException()
    End Function
End Class
