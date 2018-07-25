Public Class ClienteEdit


    Public Sub New(ByVal _Id As Int32)
        InitializeComponent()

        Me.DialogResult = DialogResult.None

        If _Id > 0 Then
            Call Query(_Id)
        End If

    End Sub

    Private Sub Query(ByVal _Id As Int32)
        Dim db As New ClienteDB()

        Dim data = db.GetDataTable(_Id)

        If data.Rows.Count > 0 Then
            Dim row = data.Rows(0)
            Call FillComponents(row)
        Else
            MessageBox.Show("No existen los datos consultados.")
            Me.Dispose()
        End If

    End Sub

    Private Sub FillComponents(ByVal row As DataRow)
        For Each control In PanelControl1.Controls
            If TypeOf control Is DevExpress.XtraEditors.TextEdit Then
                Try
                    control.EditValue = row(control.Name)
                Catch ex As Exception

                End Try
            End If
        Next
    End Sub

    Private Sub Save()
        Dim db As New ClienteDB()

        If ID.EditValue = 0 Then
            db.Insert(Nombres.Text, Apellidos.Text, FechaNacimiento.DateTime, DUI.Text, Direccion.Text)
        Else
            db.Update(ID.EditValue, Nombres.Text, Apellidos.Text, FechaNacimiento.DateTime, DUI.Text, Direccion.Text)
        End If

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Cancel()
        Me.Dispose()
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Call Save()
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        Call Cancel()
    End Sub
End Class