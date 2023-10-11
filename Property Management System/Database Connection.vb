Imports MySql.Data.MySqlClient

Module DatabaseConnection
    Public Con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public table As New DataTable

    Sub OpenCon()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        ElseIf Con.State = ConnectionState.Closed Then
            Con.ConnectionString = "server=192.168.100.100;username=root;password=qweE001!;database=db_pms"
            Con.Open()
        End If
    End Sub
End Module
