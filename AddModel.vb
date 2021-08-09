Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class AddModel
    Private ReadOnly connection_string As String = ConfigurationManager.ConnectionStrings("tag_quality").ConnectionString
    Private ReadOnly connection As New MySqlConnection(connection_string)







End Class
