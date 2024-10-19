Imports System.Data.SqlClient

Module ModuleDatabase

    Dim Connect As SqlConnection
    Public Function ConnectDatabase(ConnectionString As String)
        Dim Connect As New SqlConnection(ConnectionString)
        If Connect.State = ConnectionState.Open Then Connect.Close()
        Return Connect
    End Function

    Public Sub Disconnect()
        Connect.Close()
        MessageBox.Show("Disconnected")
    End Sub
End Module
