@ModelType IEnumerable(Of MVC.Cliente)
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nombres)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Apellidos)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FechaNacimiento)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DUI)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Direccion)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Nombres)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Apellidos)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.FechaNacimiento)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.DUI)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Direccion)
    </td>
    <td>
        @Html.ActionLink("Edit", "Edit", New With {.id = item.Id}) |
        @Html.ActionLink("Details", "Details", New With {.id = item.Id}) |
        @Html.ActionLink("Delete", "Delete", New With {.id = item.Id})
    </td>
</tr>
Next

</table>
