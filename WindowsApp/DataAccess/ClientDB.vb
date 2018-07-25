Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ClienteDB

    Private Const mttoCommand As String = "sp_mtto_cliente"
    Private Const dataCommand As String = "sp_data_cliente"
    Private strConnection As String '= "Data Source=localhost; uid=sa; pwd=123456; database=Demo"

    Public Sub New()
        strConnection = ConfigurationManager.ConnectionStrings("Demo").ConnectionString
    End Sub

    Public Function GetDataTable() As DataTable

        Dim connection As New SqlConnection(strConnection)
        Dim cmd As New SqlCommand(dataCommand, connection)
        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd

        Dim dt As New DataTable("Clientes")
        da.Fill(dt)

        connection.Close()

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

        connection.Close()

        Return dt
    End Function


    Public Function Insert(Nombres As String, Apellidos As String, FechaNacimiento As Date, DUI As String, Direccion As String) As Integer

        Dim connection As New SqlConnection(strConnection)

        Dim cmd As New SqlCommand(mttoCommand, connection)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlParameter() With {
            .ParameterName = "Id",
            .DbType = DbType.Int32,
            .Value = 0,
            .Direction = ParameterDirection.InputOutput
        })

        With cmd.Parameters
            .Add(New SqlParameter() With {.ParameterName = "Nombres", .Value = Nombres, .DbType = DbType.String})
            .Add(New SqlParameter() With {.ParameterName = "Apellidos", .Value = Apellidos, .DbType = DbType.String})
            .Add(New SqlParameter() With {.ParameterName = "FechaNacimiento", .Value = FechaNacimiento, .DbType = DbType.Date})
            .Add(New SqlParameter() With {.ParameterName = "DUI", .Value = DUI, .DbType = DbType.String})
            .Add(New SqlParameter() With {.ParameterName = "Direccion", .Value = Direccion, .DbType = DbType.String})


        End With

        ' For INSERT
        cmd.Parameters.Add(New SqlParameter() With {.ParameterName = "TipoMtto", .Value = 1, .DbType = DbType.Int32})

        Dim Id As Int32 = cmd.Parameters("Id").Value

        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

        Return Id
    End Function

    Public Function Update(Id As Integer, Nombres As String, Apellidos As String, FechaNacimiento As Date, DUI As String, Direccion As String) As Integer

        Dim connection As New SqlConnection(strConnection)

        Dim cmd As New SqlCommand(mttoCommand, connection)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlParameter() With {
            .ParameterName = "Id",
            .DbType = DbType.Int32,
            .Value = Id,
            .Direction = ParameterDirection.InputOutput
        })

        With cmd.Parameters
            .Add(New SqlParameter() With {.ParameterName = "Nombres", .Value = Nombres, .DbType = DbType.String})
            .Add(New SqlParameter() With {.ParameterName = "Apellidos", .Value = Apellidos, .DbType = DbType.String})
            .Add(New SqlParameter() With {.ParameterName = "FechaNacimiento", .Value = FechaNacimiento, .DbType = DbType.Date})
            .Add(New SqlParameter() With {.ParameterName = "DUI", .Value = DUI, .DbType = DbType.String})
            .Add(New SqlParameter() With {.ParameterName = "Direccion", .Value = Direccion, .DbType = DbType.String})


        End With

        ' For UPDATE
        cmd.Parameters.Add(New SqlParameter() With {.ParameterName = "TipoMtto", .Value = 2, .DbType = DbType.Int32})

        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

        Return Id
    End Function

    Public Function Delete(Id As Integer) As Integer

        Dim connection As New SqlConnection(strConnection)

        Dim cmd As New SqlCommand(mttoCommand, connection)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlParameter() With {
            .ParameterName = "Id",
            .DbType = DbType.Int32,
            .Value = Id,
            .Direction = ParameterDirection.InputOutput
        })


        ' For DELETE
        cmd.Parameters.Add(New SqlParameter() With {.ParameterName = "TipoMtto", .Value = 3, .DbType = DbType.Int32})

        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

        Return Id
    End Function

End Class
