﻿Imports System.Data.OleDb

Module dbconnection

    Public cn As New OleDbConnection
    Public cmd As New OleDbCommand
    Public sql As String
    Public dr As OleDbDataReader

    Public Sub connection()
        cn.Close()
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\POSdb.accdb"
        cn.Open()
    End Sub
End Module
