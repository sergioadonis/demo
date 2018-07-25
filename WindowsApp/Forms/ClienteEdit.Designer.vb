<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClienteEdit))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Direccion = New DevExpress.XtraEditors.TextEdit()
        Me.DUI = New DevExpress.XtraEditors.TextEdit()
        Me.FechaNacimiento = New DevExpress.XtraEditors.DateEdit()
        Me.Apellidos = New DevExpress.XtraEditors.TextEdit()
        Me.Nombres = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ID = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.Direccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DUI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaNacimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaNacimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Apellidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 3
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(800, 141)
        '
        'btnSave
        '
        Me.btnSave.Caption = "Guardar"
        Me.btnSave.Id = 1
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.ImageOptions.LargeImage = CType(resources.GetObject("btnSave.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSave.LargeWidth = 75
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancelar"
        Me.btnCancel.Id = 2
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.ImageOptions.LargeImage = CType(resources.GetObject("btnCancel.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCancel.LargeWidth = 75
        Me.btnCancel.Name = "btnCancel"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Cliente"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Direccion)
        Me.PanelControl1.Controls.Add(Me.DUI)
        Me.PanelControl1.Controls.Add(Me.FechaNacimiento)
        Me.PanelControl1.Controls.Add(Me.Apellidos)
        Me.PanelControl1.Controls.Add(Me.Nombres)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.ID)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 141)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(800, 309)
        Me.PanelControl1.TabIndex = 1
        '
        'Direccion
        '
        Me.Direccion.Location = New System.Drawing.Point(172, 176)
        Me.Direccion.MenuManager = Me.RibbonControl1
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(324, 20)
        Me.Direccion.TabIndex = 11
        '
        'DUI
        '
        Me.DUI.Location = New System.Drawing.Point(396, 140)
        Me.DUI.MenuManager = Me.RibbonControl1
        Me.DUI.Name = "DUI"
        Me.DUI.Size = New System.Drawing.Size(100, 20)
        Me.DUI.TabIndex = 10
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.EditValue = Nothing
        Me.FechaNacimiento.Location = New System.Drawing.Point(172, 140)
        Me.FechaNacimiento.MenuManager = Me.RibbonControl1
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaNacimiento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.FechaNacimiento.TabIndex = 9
        '
        'Apellidos
        '
        Me.Apellidos.Location = New System.Drawing.Point(172, 105)
        Me.Apellidos.MenuManager = Me.RibbonControl1
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.Size = New System.Drawing.Size(324, 20)
        Me.Apellidos.TabIndex = 8
        '
        'Nombres
        '
        Me.Nombres.Location = New System.Drawing.Point(172, 70)
        Me.Nombres.MenuManager = Me.RibbonControl1
        Me.Nombres.Name = "Nombres"
        Me.Nombres.Size = New System.Drawing.Size(324, 20)
        Me.Nombres.TabIndex = 7
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(119, 179)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = "Dirección:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(368, 143)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl5.TabIndex = 5
        Me.LabelControl5.Text = "DUI:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(63, 143)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Fecha de Nacimiento:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(120, 108)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Apellidos:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(120, 73)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Nombres:"
        '
        'ID
        '
        Me.ID.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ID.Location = New System.Drawing.Point(172, 35)
        Me.ID.MenuManager = Me.RibbonControl1
        Me.ID.Name = "ID"
        Me.ID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions1)})
        Me.ID.Properties.ReadOnly = True
        Me.ID.Size = New System.Drawing.Size(100, 20)
        Me.ID.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(152, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(14, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Id:"
        '
        'ClienteEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "ClienteEdit"
        Me.Text = "ClienteEdit"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.Direccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DUI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaNacimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaNacimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Apellidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Direccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DUI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FechaNacimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Apellidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Nombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ID As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
