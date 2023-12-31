<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFactura
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
        Me.lblFactAgregar = New System.Windows.Forms.Label()
        Me.lblFactProveedor = New System.Windows.Forms.Label()
        Me.lblFactFechaFact = New System.Windows.Forms.Label()
        Me.lblFactDiasCred = New System.Windows.Forms.Label()
        Me.lblFactFact = New System.Windows.Forms.Label()
        Me.lblFactMonto = New System.Windows.Forms.Label()
        Me.lblFactFormaPag = New System.Windows.Forms.Label()
        Me.lblFactBancoDef = New System.Windows.Forms.Label()
        Me.btnFactAgregar = New System.Windows.Forms.Button()
        Me.lblFactSolicitar = New System.Windows.Forms.Label()
        Me.txtFactFact = New System.Windows.Forms.TextBox()
        Me.txtFactMonto = New System.Windows.Forms.TextBox()
        Me.txtFactReferencia = New System.Windows.Forms.TextBox()
        Me.lblFactReferencia = New System.Windows.Forms.Label()
        Me.txtFactObservacion = New System.Windows.Forms.TextBox()
        Me.txtFactPagar = New System.Windows.Forms.TextBox()
        Me.btnFactRealizar = New System.Windows.Forms.Button()
        Me.btnFactAgregarCuent = New System.Windows.Forms.Button()
        Me.btnFactPagar = New System.Windows.Forms.Button()
        Me.lbxCuentas = New System.Windows.Forms.ListBox()
        Me.cbFactProveedor = New System.Windows.Forms.ComboBox()
        Me.dtpFact = New System.Windows.Forms.DateTimePicker()
        Me.gbFactTerminos = New System.Windows.Forms.GroupBox()
        Me.chkFactContado = New System.Windows.Forms.CheckBox()
        Me.chkFactCredito = New System.Windows.Forms.CheckBox()
        Me.nudFactDiasCred = New System.Windows.Forms.NumericUpDown()
        Me.dgvFactDatos = New System.Windows.Forms.DataGridView()
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TerminosPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbFactAccion = New System.Windows.Forms.GroupBox()
        Me.rbFactPagar = New System.Windows.Forms.RadioButton()
        Me.rbFactEliminar = New System.Windows.Forms.RadioButton()
        Me.gbFactPagar = New System.Windows.Forms.GroupBox()
        Me.btnFactEliminarCuent = New System.Windows.Forms.Button()
        Me.ptbFactPagar = New System.Windows.Forms.PictureBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cbFactBanco = New System.Windows.Forms.ComboBox()
        Me.clbFactFormaPag = New System.Windows.Forms.CheckedListBox()
        Me.lblFactFecha = New System.Windows.Forms.Label()
        Me.gbFactTerminos.SuspendLayout()
        CType(Me.nudFactDiasCred, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFactDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFactAccion.SuspendLayout()
        Me.gbFactPagar.SuspendLayout()
        CType(Me.ptbFactPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactAgregar
        '
        Me.lblFactAgregar.AutoSize = True
        Me.lblFactAgregar.BackColor = System.Drawing.Color.AliceBlue
        Me.lblFactAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactAgregar.ForeColor = System.Drawing.Color.Blue
        Me.lblFactAgregar.Location = New System.Drawing.Point(130, 32)
        Me.lblFactAgregar.Name = "lblFactAgregar"
        Me.lblFactAgregar.Size = New System.Drawing.Size(225, 31)
        Me.lblFactAgregar.TabIndex = 0
        Me.lblFactAgregar.Text = "Agregar Factura"
        '
        'lblFactProveedor
        '
        Me.lblFactProveedor.AutoSize = True
        Me.lblFactProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactProveedor.Location = New System.Drawing.Point(43, 88)
        Me.lblFactProveedor.Name = "lblFactProveedor"
        Me.lblFactProveedor.Size = New System.Drawing.Size(74, 17)
        Me.lblFactProveedor.TabIndex = 1
        Me.lblFactProveedor.Text = "Proveedor"
        '
        'lblFactFechaFact
        '
        Me.lblFactFechaFact.AutoSize = True
        Me.lblFactFechaFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactFechaFact.Location = New System.Drawing.Point(42, 166)
        Me.lblFactFechaFact.Name = "lblFactFechaFact"
        Me.lblFactFechaFact.Size = New System.Drawing.Size(115, 17)
        Me.lblFactFechaFact.TabIndex = 2
        Me.lblFactFechaFact.Text = "Fecha de factura"
        '
        'lblFactDiasCred
        '
        Me.lblFactDiasCred.AutoSize = True
        Me.lblFactDiasCred.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactDiasCred.Location = New System.Drawing.Point(42, 362)
        Me.lblFactDiasCred.Name = "lblFactDiasCred"
        Me.lblFactDiasCred.Size = New System.Drawing.Size(83, 17)
        Me.lblFactDiasCred.TabIndex = 4
        Me.lblFactDiasCred.Text = "Días crédito"
        '
        'lblFactFact
        '
        Me.lblFactFact.AutoSize = True
        Me.lblFactFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactFact.Location = New System.Drawing.Point(42, 412)
        Me.lblFactFact.Name = "lblFactFact"
        Me.lblFactFact.Size = New System.Drawing.Size(56, 17)
        Me.lblFactFact.TabIndex = 5
        Me.lblFactFact.Text = "Factura"
        '
        'lblFactMonto
        '
        Me.lblFactMonto.AutoSize = True
        Me.lblFactMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactMonto.Location = New System.Drawing.Point(42, 458)
        Me.lblFactMonto.Name = "lblFactMonto"
        Me.lblFactMonto.Size = New System.Drawing.Size(47, 17)
        Me.lblFactMonto.TabIndex = 6
        Me.lblFactMonto.Text = "Monto"
        '
        'lblFactFormaPag
        '
        Me.lblFactFormaPag.AutoSize = True
        Me.lblFactFormaPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactFormaPag.Location = New System.Drawing.Point(42, 495)
        Me.lblFactFormaPag.Name = "lblFactFormaPag"
        Me.lblFactFormaPag.Size = New System.Drawing.Size(105, 17)
        Me.lblFactFormaPag.TabIndex = 7
        Me.lblFactFormaPag.Text = "Forma de Pago"
        '
        'lblFactBancoDef
        '
        Me.lblFactBancoDef.AutoSize = True
        Me.lblFactBancoDef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactBancoDef.Location = New System.Drawing.Point(42, 622)
        Me.lblFactBancoDef.Name = "lblFactBancoDef"
        Me.lblFactBancoDef.Size = New System.Drawing.Size(103, 17)
        Me.lblFactBancoDef.TabIndex = 8
        Me.lblFactBancoDef.Text = "Banco(Default)"
        '
        'btnFactAgregar
        '
        Me.btnFactAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactAgregar.Location = New System.Drawing.Point(156, 669)
        Me.btnFactAgregar.Name = "btnFactAgregar"
        Me.btnFactAgregar.Size = New System.Drawing.Size(108, 25)
        Me.btnFactAgregar.TabIndex = 9
        Me.btnFactAgregar.Text = "Agregar"
        Me.btnFactAgregar.UseVisualStyleBackColor = True
        '
        'lblFactSolicitar
        '
        Me.lblFactSolicitar.AutoSize = True
        Me.lblFactSolicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactSolicitar.ForeColor = System.Drawing.Color.Blue
        Me.lblFactSolicitar.Location = New System.Drawing.Point(276, 32)
        Me.lblFactSolicitar.Name = "lblFactSolicitar"
        Me.lblFactSolicitar.Size = New System.Drawing.Size(195, 31)
        Me.lblFactSolicitar.TabIndex = 10
        Me.lblFactSolicitar.Text = "Solicitar Pago"
        '
        'txtFactFact
        '
        Me.txtFactFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactFact.Location = New System.Drawing.Point(156, 409)
        Me.txtFactFact.Name = "txtFactFact"
        Me.txtFactFact.Size = New System.Drawing.Size(155, 23)
        Me.txtFactFact.TabIndex = 11
        '
        'txtFactMonto
        '
        Me.txtFactMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactMonto.Location = New System.Drawing.Point(156, 455)
        Me.txtFactMonto.Name = "txtFactMonto"
        Me.txtFactMonto.Size = New System.Drawing.Size(155, 23)
        Me.txtFactMonto.TabIndex = 12
        '
        'txtFactReferencia
        '
        Me.txtFactReferencia.Location = New System.Drawing.Point(21, 52)
        Me.txtFactReferencia.Name = "txtFactReferencia"
        Me.txtFactReferencia.Size = New System.Drawing.Size(269, 23)
        Me.txtFactReferencia.TabIndex = 15
        '
        'lblFactReferencia
        '
        Me.lblFactReferencia.AutoSize = True
        Me.lblFactReferencia.Location = New System.Drawing.Point(18, 32)
        Me.lblFactReferencia.Name = "lblFactReferencia"
        Me.lblFactReferencia.Size = New System.Drawing.Size(77, 17)
        Me.lblFactReferencia.TabIndex = 16
        Me.lblFactReferencia.Text = "Referencia"
        '
        'txtFactObservacion
        '
        Me.txtFactObservacion.Enabled = False
        Me.txtFactObservacion.Location = New System.Drawing.Point(44, 238)
        Me.txtFactObservacion.Multiline = True
        Me.txtFactObservacion.Name = "txtFactObservacion"
        Me.txtFactObservacion.Size = New System.Drawing.Size(551, 71)
        Me.txtFactObservacion.TabIndex = 18
        '
        'txtFactPagar
        '
        Me.txtFactPagar.Enabled = False
        Me.txtFactPagar.Location = New System.Drawing.Point(21, 381)
        Me.txtFactPagar.Name = "txtFactPagar"
        Me.txtFactPagar.Size = New System.Drawing.Size(574, 23)
        Me.txtFactPagar.TabIndex = 19
        '
        'btnFactRealizar
        '
        Me.btnFactRealizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactRealizar.Location = New System.Drawing.Point(442, 273)
        Me.btnFactRealizar.Name = "btnFactRealizar"
        Me.btnFactRealizar.Size = New System.Drawing.Size(118, 26)
        Me.btnFactRealizar.TabIndex = 20
        Me.btnFactRealizar.Text = "Realizar"
        Me.btnFactRealizar.UseVisualStyleBackColor = True
        '
        'btnFactAgregarCuent
        '
        Me.btnFactAgregarCuent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactAgregarCuent.Location = New System.Drawing.Point(21, 193)
        Me.btnFactAgregarCuent.Name = "btnFactAgregarCuent"
        Me.btnFactAgregarCuent.Size = New System.Drawing.Size(135, 29)
        Me.btnFactAgregarCuent.TabIndex = 21
        Me.btnFactAgregarCuent.Text = "Agregar cuenta"
        Me.btnFactAgregarCuent.UseVisualStyleBackColor = True
        '
        'btnFactPagar
        '
        Me.btnFactPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactPagar.Location = New System.Drawing.Point(21, 337)
        Me.btnFactPagar.Name = "btnFactPagar"
        Me.btnFactPagar.Size = New System.Drawing.Size(92, 29)
        Me.btnFactPagar.TabIndex = 22
        Me.btnFactPagar.Text = "Pagar"
        Me.btnFactPagar.UseVisualStyleBackColor = True
        '
        'lbxCuentas
        '
        Me.lbxCuentas.FormattingEnabled = True
        Me.lbxCuentas.ItemHeight = 16
        Me.lbxCuentas.Items.AddRange(New Object() {"  --Cuentas"})
        Me.lbxCuentas.Location = New System.Drawing.Point(21, 93)
        Me.lbxCuentas.Name = "lbxCuentas"
        Me.lbxCuentas.Size = New System.Drawing.Size(269, 84)
        Me.lbxCuentas.TabIndex = 23
        '
        'cbFactProveedor
        '
        Me.cbFactProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFactProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFactProveedor.FormattingEnabled = True
        Me.cbFactProveedor.Items.AddRange(New Object() {"CRASOC", "CRCARGO", "CRAIMILO", "CRCONGLIG", "CRDHL", "CRTAEROP", "CRANGPO"})
        Me.cbFactProveedor.Location = New System.Drawing.Point(45, 119)
        Me.cbFactProveedor.Name = "cbFactProveedor"
        Me.cbFactProveedor.Size = New System.Drawing.Size(186, 24)
        Me.cbFactProveedor.TabIndex = 24
        '
        'dtpFact
        '
        Me.dtpFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFact.Location = New System.Drawing.Point(45, 196)
        Me.dtpFact.Name = "dtpFact"
        Me.dtpFact.Size = New System.Drawing.Size(266, 23)
        Me.dtpFact.TabIndex = 25
        '
        'gbFactTerminos
        '
        Me.gbFactTerminos.Controls.Add(Me.chkFactContado)
        Me.gbFactTerminos.Controls.Add(Me.chkFactCredito)
        Me.gbFactTerminos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFactTerminos.Location = New System.Drawing.Point(45, 246)
        Me.gbFactTerminos.Name = "gbFactTerminos"
        Me.gbFactTerminos.Size = New System.Drawing.Size(200, 93)
        Me.gbFactTerminos.TabIndex = 26
        Me.gbFactTerminos.TabStop = False
        Me.gbFactTerminos.Text = "Términos de Pago"
        '
        'chkFactContado
        '
        Me.chkFactContado.AutoSize = True
        Me.chkFactContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFactContado.Location = New System.Drawing.Point(21, 60)
        Me.chkFactContado.Name = "chkFactContado"
        Me.chkFactContado.Size = New System.Drawing.Size(83, 21)
        Me.chkFactContado.TabIndex = 28
        Me.chkFactContado.Text = "Contado"
        Me.chkFactContado.UseVisualStyleBackColor = True
        '
        'chkFactCredito
        '
        Me.chkFactCredito.AutoSize = True
        Me.chkFactCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFactCredito.Location = New System.Drawing.Point(21, 29)
        Me.chkFactCredito.Name = "chkFactCredito"
        Me.chkFactCredito.Size = New System.Drawing.Size(75, 21)
        Me.chkFactCredito.TabIndex = 27
        Me.chkFactCredito.Text = "Crédito"
        Me.chkFactCredito.UseVisualStyleBackColor = True
        '
        'nudFactDiasCred
        '
        Me.nudFactDiasCred.Enabled = False
        Me.nudFactDiasCred.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudFactDiasCred.Location = New System.Drawing.Point(156, 362)
        Me.nudFactDiasCred.Name = "nudFactDiasCred"
        Me.nudFactDiasCred.Size = New System.Drawing.Size(155, 23)
        Me.nudFactDiasCred.TabIndex = 27
        '
        'dgvFactDatos
        '
        Me.dgvFactDatos.AllowUserToAddRows = False
        Me.dgvFactDatos.AllowUserToDeleteRows = False
        Me.dgvFactDatos.AllowUserToResizeColumns = False
        Me.dgvFactDatos.AllowUserToResizeRows = False
        Me.dgvFactDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvFactDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFactDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Factura, Me.Fecha, Me.Monto, Me.Proveedor, Me.TerminosPago, Me.DiasCredito, Me.FormaPago, Me.Banco})
        Me.dgvFactDatos.Location = New System.Drawing.Point(46, 90)
        Me.dgvFactDatos.Name = "dgvFactDatos"
        Me.dgvFactDatos.RowHeadersVisible = False
        Me.dgvFactDatos.RowTemplate.Height = 24
        Me.dgvFactDatos.Size = New System.Drawing.Size(618, 150)
        Me.dgvFactDatos.TabIndex = 29
        '
        'Factura
        '
        Me.Factura.HeaderText = "Factura"
        Me.Factura.Name = "Factura"
        Me.Factura.Width = 85
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 76
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.Width = 76
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.Width = 103
        '
        'TerminosPago
        '
        Me.TerminosPago.HeaderText = "Términos de Pago"
        Me.TerminosPago.Name = "TerminosPago"
        Me.TerminosPago.Width = 110
        '
        'DiasCredito
        '
        Me.DiasCredito.HeaderText = "Días de Crédito"
        Me.DiasCredito.Name = "DiasCredito"
        Me.DiasCredito.Width = 123
        '
        'FormaPago
        '
        Me.FormaPago.HeaderText = "Forma de Pago"
        Me.FormaPago.Name = "FormaPago"
        Me.FormaPago.Width = 93
        '
        'Banco
        '
        Me.Banco.HeaderText = "Banco"
        Me.Banco.Name = "Banco"
        Me.Banco.Width = 77
        '
        'gbFactAccion
        '
        Me.gbFactAccion.Controls.Add(Me.rbFactPagar)
        Me.gbFactAccion.Controls.Add(Me.rbFactEliminar)
        Me.gbFactAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFactAccion.Location = New System.Drawing.Point(46, 257)
        Me.gbFactAccion.Name = "gbFactAccion"
        Me.gbFactAccion.Size = New System.Drawing.Size(320, 53)
        Me.gbFactAccion.TabIndex = 30
        Me.gbFactAccion.TabStop = False
        Me.gbFactAccion.Text = "Acción"
        '
        'rbFactPagar
        '
        Me.rbFactPagar.AutoSize = True
        Me.rbFactPagar.Location = New System.Drawing.Point(185, 21)
        Me.rbFactPagar.Name = "rbFactPagar"
        Me.rbFactPagar.Size = New System.Drawing.Size(67, 21)
        Me.rbFactPagar.TabIndex = 1
        Me.rbFactPagar.Text = "Pagar"
        Me.rbFactPagar.UseVisualStyleBackColor = True
        '
        'rbFactEliminar
        '
        Me.rbFactEliminar.AutoSize = True
        Me.rbFactEliminar.Checked = True
        Me.rbFactEliminar.Location = New System.Drawing.Point(34, 21)
        Me.rbFactEliminar.Name = "rbFactEliminar"
        Me.rbFactEliminar.Size = New System.Drawing.Size(79, 21)
        Me.rbFactEliminar.TabIndex = 0
        Me.rbFactEliminar.TabStop = True
        Me.rbFactEliminar.Text = "Eliminar"
        Me.rbFactEliminar.UseVisualStyleBackColor = True
        '
        'gbFactPagar
        '
        Me.gbFactPagar.Controls.Add(Me.btnFactEliminarCuent)
        Me.gbFactPagar.Controls.Add(Me.ptbFactPagar)
        Me.gbFactPagar.Controls.Add(Me.lblFactReferencia)
        Me.gbFactPagar.Controls.Add(Me.txtFactReferencia)
        Me.gbFactPagar.Controls.Add(Me.txtFactObservacion)
        Me.gbFactPagar.Controls.Add(Me.txtFactPagar)
        Me.gbFactPagar.Controls.Add(Me.btnFactAgregarCuent)
        Me.gbFactPagar.Controls.Add(Me.btnFactPagar)
        Me.gbFactPagar.Controls.Add(Me.lbxCuentas)
        Me.gbFactPagar.Enabled = False
        Me.gbFactPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFactPagar.Location = New System.Drawing.Point(46, 330)
        Me.gbFactPagar.Name = "gbFactPagar"
        Me.gbFactPagar.Size = New System.Drawing.Size(618, 420)
        Me.gbFactPagar.TabIndex = 31
        Me.gbFactPagar.TabStop = False
        Me.gbFactPagar.Text = "Pagar"
        '
        'btnFactEliminarCuent
        '
        Me.btnFactEliminarCuent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactEliminarCuent.Location = New System.Drawing.Point(204, 193)
        Me.btnFactEliminarCuent.Name = "btnFactEliminarCuent"
        Me.btnFactEliminarCuent.Size = New System.Drawing.Size(136, 29)
        Me.btnFactEliminarCuent.TabIndex = 25
        Me.btnFactEliminarCuent.Text = "Eliminar cuenta"
        Me.btnFactEliminarCuent.UseVisualStyleBackColor = True
        '
        'ptbFactPagar
        '
        Me.ptbFactPagar.BackgroundImage = Global.Facturacion.My.Resources.Resources.Paypal
        Me.ptbFactPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbFactPagar.Location = New System.Drawing.Point(363, 32)
        Me.ptbFactPagar.Name = "ptbFactPagar"
        Me.ptbFactPagar.Size = New System.Drawing.Size(232, 190)
        Me.ptbFactPagar.TabIndex = 24
        Me.ptbFactPagar.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(1, -2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbFactBanco)
        Me.SplitContainer1.Panel1.Controls.Add(Me.clbFactFormaPag)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbFactTerminos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFact)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFactAgregar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFactFechaFact)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnFactAgregar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.nudFactDiasCred)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbFactProveedor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFactDiasCred)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFactFact)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFactMonto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFactMonto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFactFormaPag)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFactFact)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFactBancoDef)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvFactDatos)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbFactAccion)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbFactPagar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblFactFecha)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblFactSolicitar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnFactRealizar)
        Me.SplitContainer1.Size = New System.Drawing.Size(1181, 753)
        Me.SplitContainer1.SplitterDistance = 470
        Me.SplitContainer1.TabIndex = 32
        '
        'cbFactBanco
        '
        Me.cbFactBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFactBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFactBanco.FormattingEnabled = True
        Me.cbFactBanco.Items.AddRange(New Object() {"Banco de Costa Rica", "Banco Nacional de Costa Rica", "Banco Popular", "Bac San José", "ScotiaBank", "Banco Promerica", "Otro"})
        Me.cbFactBanco.Location = New System.Drawing.Point(151, 619)
        Me.cbFactBanco.Name = "cbFactBanco"
        Me.cbFactBanco.Size = New System.Drawing.Size(186, 24)
        Me.cbFactBanco.TabIndex = 30
        '
        'clbFactFormaPag
        '
        Me.clbFactFormaPag.FormattingEnabled = True
        Me.clbFactFormaPag.Items.AddRange(New Object() {"Cheque", "Transferencia", "Efectivo"})
        Me.clbFactFormaPag.Location = New System.Drawing.Point(45, 515)
        Me.clbFactFormaPag.Name = "clbFactFormaPag"
        Me.clbFactFormaPag.Size = New System.Drawing.Size(266, 72)
        Me.clbFactFormaPag.TabIndex = 29
        '
        'lblFactFecha
        '
        Me.lblFactFecha.AutoSize = True
        Me.lblFactFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactFecha.Location = New System.Drawing.Point(540, 11)
        Me.lblFactFecha.Name = "lblFactFecha"
        Me.lblFactFecha.Size = New System.Drawing.Size(51, 17)
        Me.lblFactFecha.TabIndex = 11
        Me.lblFactFecha.Text = "Label1"
        '
        'FrmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.lblFactProveedor)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmFactura"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Facturación"
        Me.gbFactTerminos.ResumeLayout(False)
        Me.gbFactTerminos.PerformLayout()
        CType(Me.nudFactDiasCred, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFactDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFactAccion.ResumeLayout(False)
        Me.gbFactAccion.PerformLayout()
        Me.gbFactPagar.ResumeLayout(False)
        Me.gbFactPagar.PerformLayout()
        CType(Me.ptbFactPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFactAgregar As Label
    Friend WithEvents lblFactProveedor As Label
    Friend WithEvents lblFactFechaFact As Label
    Friend WithEvents lblFactDiasCred As Label
    Friend WithEvents lblFactFact As Label
    Friend WithEvents lblFactMonto As Label
    Friend WithEvents lblFactFormaPag As Label
    Friend WithEvents lblFactBancoDef As Label
    Friend WithEvents btnFactAgregar As Button
    Friend WithEvents lblFactSolicitar As Label
    Friend WithEvents txtFactFact As TextBox
    Friend WithEvents txtFactMonto As TextBox
    Friend WithEvents txtFactReferencia As TextBox
    Friend WithEvents lblFactReferencia As Label
    Friend WithEvents txtFactObservacion As TextBox
    Friend WithEvents txtFactPagar As TextBox
    Friend WithEvents btnFactRealizar As Button
    Friend WithEvents btnFactAgregarCuent As Button
    Friend WithEvents btnFactPagar As Button
    Friend WithEvents lbxCuentas As ListBox
    Friend WithEvents cbFactProveedor As ComboBox
    Friend WithEvents dtpFact As DateTimePicker
    Friend WithEvents gbFactTerminos As GroupBox
    Friend WithEvents chkFactContado As CheckBox
    Friend WithEvents chkFactCredito As CheckBox
    Friend WithEvents nudFactDiasCred As NumericUpDown
    Friend WithEvents gbFactAccion As GroupBox
    Friend WithEvents rbFactPagar As RadioButton
    Friend WithEvents rbFactEliminar As RadioButton
    Friend WithEvents gbFactPagar As GroupBox
    Friend WithEvents ptbFactPagar As PictureBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lblFactFecha As Label
    Friend WithEvents clbFactFormaPag As CheckedListBox
    Friend WithEvents dgvFactDatos As DataGridView
    Friend WithEvents cbFactBanco As ComboBox
    Friend WithEvents btnFactEliminarCuent As Button
    Friend WithEvents Factura As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents TerminosPago As DataGridViewTextBoxColumn
    Friend WithEvents DiasCredito As DataGridViewTextBoxColumn
    Friend WithEvents FormaPago As DataGridViewTextBoxColumn
    Friend WithEvents Banco As DataGridViewTextBoxColumn
End Class
