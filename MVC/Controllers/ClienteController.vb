Imports System.Web.Mvc
Imports RestSharp
Imports Newtonsoft.Json

Namespace Controllers
    Public Class ClienteController
        Inherits Controller

        Private api As String = "http://localhost:50014/api"
        Private resourceName As String = "Cliente"

        ' GET: Cliente
        Function Index() As ActionResult
            Dim list As New List(Of Cliente)

            Dim client As New RestClient(api)
            Dim request As New RestRequest(resourceName, Method.GET)
            Dim result = client.ExecuteDynamic(request)


            If result.StatusCode = Net.HttpStatusCode.OK Then
                Try
                    Dim json = result.Data
                    list = JsonConvert.DeserializeObject(Of List(Of Cliente))(json)

                Catch ex As Exception

                End Try
            End If

            Return View(list)
        End Function

        ' GET: Cliente/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Dim item As New Cliente

            Dim client As New RestClient(api)
            Dim request As New RestRequest(resourceName + "/{Id}", Method.GET)
            request.AddUrlSegment("Id", id)
            Dim result = client.ExecuteDynamic(request)


            If result.StatusCode = Net.HttpStatusCode.OK Then
                Try
                    Dim json = result.Data
                    Dim list = JsonConvert.DeserializeObject(Of List(Of Cliente))(json)

                    item = list.FirstOrDefault()

                Catch ex As Exception

                End Try
            End If

            Return View(item)
        End Function

        ' GET: Cliente/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Cliente/Create
        <HttpPost()>
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Cliente/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Cliente/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Cliente/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Cliente/Delete/5
        <HttpPost()>
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace