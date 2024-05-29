Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class DatabaseConnection
    Private connString As String = "server=localhost;userid=root;password=;database=datapasien"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connString)
    End Function
End Class

