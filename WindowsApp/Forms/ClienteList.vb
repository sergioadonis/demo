﻿Public Class ClienteList
    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill a SqlDataSource

        Call Query()
    End Sub

    Private Sub Query()
        Dim db As New ClienteDB()

        GridControl1.DataSource = db.GetDataTable()
    End Sub

    Private Sub btnQuery_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuery.ItemClick
        Call Query()
    End Sub

    Private Sub Edit()
        If Not GridView1.IsFilterRow(GridView1.FocusedRowHandle) Then
            Dim _id = GridView1.GetFocusedRowCellValue("Id")

            Dim clientEdit As New ClienteEdit(_id)

            If clientEdit.ShowDialog(Me) = DialogResult.OK Then
                Call Query()
            End If
        End If
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Call Edit()
    End Sub

    Private Sub Add()

        Dim clientEdit As New ClienteEdit(0)

        If clientEdit.ShowDialog(Me) = DialogResult.OK Then
            Call Query()
        End If

    End Sub

    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Call Add()
    End Sub

    Private Sub Delete()

    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        If Not GridView1.IsFilterRow(GridView1.FocusedRowHandle) Then

            If MessageBox.Show(Me, "Desea realmente eliminar el cliente seleccionado?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim _id = GridView1.GetFocusedRowCellValue("Id")

                Dim db As New ClienteDB
                db.Delete(_id)

                Call Query()
            End If

        End If
    End Sub

    Private Sub ShowPrintPreview()
        Dim report As New ClienteReport()
        Dim data = New ClienteDB().GetDataTable()
        report.DataSource = data


        Dim viewer As New ReportViewer()
        viewer.DocumentViewer1.DocumentSource = report

        viewer.ShowDialog(Me)
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Call ShowPrintPreview()
    End Sub
End Class
