Imports System.Net
Imports System.Web.Http
Imports Newtonsoft.Json

Namespace Controllers
    Public Class ClienteController
        Inherits ApiController

        Private db As New ClienteDB()

        ' GET: api/Cliente
        Public Function GetClientes() As IHttpActionResult

            Dim dt = db.GetDataTable()
            Dim result = JsonConvert.SerializeObject(dt)

            Return Ok(result)
        End Function

        ' GET: api/Cliente/5
        Public Function GetCliente(ByVal id As Integer) As IHttpActionResult
            Dim dr = db.GetDataTable(id)
            Dim result = JsonConvert.SerializeObject(dr)

            Return Ok(result)
        End Function

        ' POST: api/Cliente
        Public Function PostCliente(<FromBody()> ByVal Cliente As String) As IHttpActionResult

        End Function

        ' PUT: api/Cliente/5
        Public Function PutCliente(ByVal id As Integer, <FromBody()> ByVal Cliente As String) As IHttpActionResult

        End Function

        ' DELETE: api/Cliente/5
        Public Function DeleteCliente(ByVal id As Integer) As IHttpActionResult

        End Function
    End Class
End Namespace