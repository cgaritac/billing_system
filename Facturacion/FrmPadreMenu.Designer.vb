<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPadreMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFacturas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNuevaFactura = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVentanas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCascada = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMHorinzontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOIconos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFacturas, Me.mnuVentanas, Me.mnuSalir})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.mnuVentanas
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1282, 28)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "Facturas"
        '
        'mnuFacturas
        '
        Me.mnuFacturas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNuevaFactura})
        Me.mnuFacturas.Name = "mnuFacturas"
        Me.mnuFacturas.Size = New System.Drawing.Size(74, 24)
        Me.mnuFacturas.Text = "Facturas"
        '
        'mnuNuevaFactura
        '
        Me.mnuNuevaFactura.Name = "mnuNuevaFactura"
        Me.mnuNuevaFactura.Size = New System.Drawing.Size(176, 26)
        Me.mnuNuevaFactura.Text = "Nueva factura"
        '
        'mnuVentanas
        '
        Me.mnuVentanas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCascada, Me.mnuMVertical, Me.mnuMHorinzontal, Me.mnuOIconos})
        Me.mnuVentanas.Name = "mnuVentanas"
        Me.mnuVentanas.Size = New System.Drawing.Size(80, 24)
        Me.mnuVentanas.Text = "&Ventanas"
        '
        'mnuCascada
        '
        Me.mnuCascada.Name = "mnuCascada"
        Me.mnuCascada.Size = New System.Drawing.Size(211, 26)
        Me.mnuCascada.Text = "&Cascada"
        '
        'mnuMVertical
        '
        Me.mnuMVertical.Name = "mnuMVertical"
        Me.mnuMVertical.Size = New System.Drawing.Size(211, 26)
        Me.mnuMVertical.Text = "Mosaico &vertical"
        '
        'mnuMHorinzontal
        '
        Me.mnuMHorinzontal.Name = "mnuMHorinzontal"
        Me.mnuMHorinzontal.Size = New System.Drawing.Size(211, 26)
        Me.mnuMHorinzontal.Text = "Mosaico &horizontal"
        '
        'mnuOIconos
        '
        Me.mnuOIconos.Name = "mnuOIconos"
        Me.mnuOIconos.Size = New System.Drawing.Size(211, 26)
        Me.mnuOIconos.Text = "&Organizar iconos"
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(50, 24)
        Me.mnuSalir.Text = "Salir"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 878)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1282, 25)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'FrmPadreMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1282, 903)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPadreMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventana principal"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuOIconos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVentanas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCascada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMHorinzontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFacturas As ToolStripMenuItem
    Friend WithEvents mnuNuevaFactura As ToolStripMenuItem
    Friend WithEvents mnuSalir As ToolStripMenuItem
End Class
