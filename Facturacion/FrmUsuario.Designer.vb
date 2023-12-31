<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnAccesoIngresar = New System.Windows.Forms.Button()
        Me.btnAccesoSalir = New System.Windows.Forms.Button()
        Me.lblAccesoUsuario = New System.Windows.Forms.Label()
        Me.lblAccesoContra = New System.Windows.Forms.Label()
        Me.lblAccesoTit = New System.Windows.Forms.Label()
        Me.lblAccesoSis = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAccesoFecha = New System.Windows.Forms.Label()
        Me.ptbAccesoFact = New System.Windows.Forms.PictureBox()
        Me.ptbAccesoFondo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ptbAccesoFact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbAccesoFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(201, 29)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(247, 28)
        Me.txtUsuario.TabIndex = 0
        '
        'txtContrasena
        '
        Me.txtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.Location = New System.Drawing.Point(201, 78)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(247, 28)
        Me.txtContrasena.TabIndex = 1
        '
        'btnAccesoIngresar
        '
        Me.btnAccesoIngresar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAccesoIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccesoIngresar.Location = New System.Drawing.Point(120, 138)
        Me.btnAccesoIngresar.Name = "btnAccesoIngresar"
        Me.btnAccesoIngresar.Size = New System.Drawing.Size(111, 33)
        Me.btnAccesoIngresar.TabIndex = 2
        Me.btnAccesoIngresar.Text = "Ingresar"
        Me.btnAccesoIngresar.UseVisualStyleBackColor = False
        '
        'btnAccesoSalir
        '
        Me.btnAccesoSalir.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAccesoSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccesoSalir.Location = New System.Drawing.Point(295, 138)
        Me.btnAccesoSalir.Name = "btnAccesoSalir"
        Me.btnAccesoSalir.Size = New System.Drawing.Size(119, 33)
        Me.btnAccesoSalir.TabIndex = 3
        Me.btnAccesoSalir.Text = "Salir"
        Me.btnAccesoSalir.UseVisualStyleBackColor = False
        '
        'lblAccesoUsuario
        '
        Me.lblAccesoUsuario.AutoSize = True
        Me.lblAccesoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccesoUsuario.Location = New System.Drawing.Point(52, 32)
        Me.lblAccesoUsuario.Name = "lblAccesoUsuario"
        Me.lblAccesoUsuario.Size = New System.Drawing.Size(81, 24)
        Me.lblAccesoUsuario.TabIndex = 4
        Me.lblAccesoUsuario.Text = "Usuario"
        '
        'lblAccesoContra
        '
        Me.lblAccesoContra.AutoSize = True
        Me.lblAccesoContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccesoContra.Location = New System.Drawing.Point(52, 81)
        Me.lblAccesoContra.Name = "lblAccesoContra"
        Me.lblAccesoContra.Size = New System.Drawing.Size(116, 24)
        Me.lblAccesoContra.TabIndex = 5
        Me.lblAccesoContra.Text = "Contraseña"
        '
        'lblAccesoTit
        '
        Me.lblAccesoTit.AutoSize = True
        Me.lblAccesoTit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccesoTit.ForeColor = System.Drawing.Color.Blue
        Me.lblAccesoTit.Location = New System.Drawing.Point(336, 130)
        Me.lblAccesoTit.Name = "lblAccesoTit"
        Me.lblAccesoTit.Size = New System.Drawing.Size(158, 31)
        Me.lblAccesoTit.TabIndex = 6
        Me.lblAccesoTit.Text = "Bienvenido"
        '
        'lblAccesoSis
        '
        Me.lblAccesoSis.AutoSize = True
        Me.lblAccesoSis.BackColor = System.Drawing.Color.Transparent
        Me.lblAccesoSis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccesoSis.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAccesoSis.Location = New System.Drawing.Point(564, 20)
        Me.lblAccesoSis.Name = "lblAccesoSis"
        Me.lblAccesoSis.Size = New System.Drawing.Size(163, 54)
        Me.lblAccesoSis.TabIndex = 7
        Me.lblAccesoSis.Text = "Sistema Facturación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      Versión 1.0.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            2018"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.txtContrasena)
        Me.Panel1.Controls.Add(Me.btnAccesoSalir)
        Me.Panel1.Controls.Add(Me.btnAccesoIngresar)
        Me.Panel1.Controls.Add(Me.lblAccesoUsuario)
        Me.Panel1.Controls.Add(Me.lblAccesoContra)
        Me.Panel1.Location = New System.Drawing.Point(159, 182)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 191)
        Me.Panel1.TabIndex = 9
        '
        'lblAccesoFecha
        '
        Me.lblAccesoFecha.AutoSize = True
        Me.lblAccesoFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccesoFecha.Location = New System.Drawing.Point(12, 424)
        Me.lblAccesoFecha.Name = "lblAccesoFecha"
        Me.lblAccesoFecha.Size = New System.Drawing.Size(51, 17)
        Me.lblAccesoFecha.TabIndex = 11
        Me.lblAccesoFecha.Text = "Label6"
        '
        'ptbAccesoFact
        '
        Me.ptbAccesoFact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbAccesoFact.Image = Global.Facturacion.My.Resources.Resources.hoa_don_dien_tu
        Me.ptbAccesoFact.Location = New System.Drawing.Point(105, 40)
        Me.ptbAccesoFact.Name = "ptbAccesoFact"
        Me.ptbAccesoFact.Size = New System.Drawing.Size(184, 111)
        Me.ptbAccesoFact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbAccesoFact.TabIndex = 12
        Me.ptbAccesoFact.TabStop = False
        '
        'ptbAccesoFondo
        '
        Me.ptbAccesoFondo.BackColor = System.Drawing.Color.White
        Me.ptbAccesoFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbAccesoFondo.Image = Global.Facturacion.My.Resources.Resources.depositphotos_40189333_stock_photo_futuristic_background
        Me.ptbAccesoFondo.Location = New System.Drawing.Point(2, 1)
        Me.ptbAccesoFondo.Name = "ptbAccesoFondo"
        Me.ptbAccesoFondo.Size = New System.Drawing.Size(796, 420)
        Me.ptbAccesoFondo.TabIndex = 8
        Me.ptbAccesoFondo.TabStop = False
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ptbAccesoFact)
        Me.Controls.Add(Me.lblAccesoFecha)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblAccesoSis)
        Me.Controls.Add(Me.lblAccesoTit)
        Me.Controls.Add(Me.ptbAccesoFondo)
        Me.Name = "FrmUsuario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso al Sistema de Facturación"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ptbAccesoFact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbAccesoFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnAccesoIngresar As Button
    Friend WithEvents btnAccesoSalir As Button
    Friend WithEvents lblAccesoUsuario As Label
    Friend WithEvents lblAccesoContra As Label
    Friend WithEvents lblAccesoTit As Label
    Friend WithEvents lblAccesoSis As Label
    Friend WithEvents ptbAccesoFondo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAccesoFecha As Label
    Friend WithEvents ptbAccesoFact As PictureBox
End Class
