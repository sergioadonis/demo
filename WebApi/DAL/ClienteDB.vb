Imports System.Data
Imports System.Data.SqlClient

Public Class ClienteDB

    Private Const mttoCommand As String = "sp_mtto_cliente"
    Private Const dataCommand As String = "sp_data_cliente"
    Private Const strConnection As String = "Data Source=localhost; uid=sa; pwd=123456; database=Demo"


    Public Function GetDataTable() As DataTable

        Dim connection As New SqlConnection(strConnection)
        Dim cmd As New SqlCommand(dataCommand, connection)
        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd

        Dim dt As New DataTable("Clientes")
        da.Fill(dt)

        Return dt
    End Function

    Public Function GetDataTable(Id As Integer) As DataTable

        Dim connection As New SqlConnection(strConnection)
        Dim cmd As New SqlCommand(dataCommand, connection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("Id", Id)
        cmd.Parameters.AddWithValue("TipoData", 1)

        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd

        Dim dt As New DataTable("Clientes")
        da.Fill(dt)

        Return dt
    End Function


    Public Function Insert(Id As Integer) As DataRow

        Dim connection As New SqlConnection(strConnection)
        Dim cmd As New SqlCommand(dataCommand, connection)
        cmd.Parameters.AddWithValue("Id", Id)
        cmd.Parameters.AddWithValue("TipoData", 1)

        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd

        Dim dt As New DataTable("Clientes")
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Return dt(0)
        End If

        Return Nothing
    End Function

End Class
