Public Class FrmFactura
    Dim botonOk As String = ""

    Private Sub FrmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFactFecha.Text = DateTime.Now.ToLocalTime()
    End Sub

    Private Sub btnFactAgregar_Click(sender As Object, e As EventArgs) Handles btnFactAgregar.Click
        If txtFactFact.Text = "" Or txtFactMonto.Text = "" Or cbFactProveedor.Text = "" Or (chkFactContado.Checked.Equals(False) And chkFactCredito.Checked.Equals(False)) Or cbFactBanco.Text = "" Or (clbFactFormaPag.GetItemChecked(0).Equals(False) And clbFactFormaPag.GetItemChecked(1).Equals(False) And clbFactFormaPag.GetItemChecked(2).Equals(False)) Then

            If nudFactDiasCred.Enabled.Equals(True) And nudFactDiasCred.Value = 0 Then
                MessageBox.Show("Error, falta indicar datos", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            MessageBox.Show("Error, falta indicar datos", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Else
            If chkFactContado.Checked.Equals(True) Then
                If clbFactFormaPag.GetItemChecked(0).Equals(True) Then
                    dgvFactDatos.Rows.Add(New String() {txtFactFact.Text, dtpFact.Text, txtFactMonto.Text, cbFactProveedor.Text, "Contado", "0", "Cheque", cbFactBanco.Text})
                End If
                If clbFactFormaPag.GetItemChecked(1).Equals(True) Then
                    dgvFactDatos.Rows.Add(New String() {txtFactFact.Text, dtpFact.Text, txtFactMonto.Text, cbFactProveedor.Text, "Contado", "0", "Transferencia", cbFactBanco.Text})
                End If
                If clbFactFormaPag.GetItemChecked(2).Equals(True) Then
                    dgvFactDatos.Rows.Add(New String() {txtFactFact.Text, dtpFact.Text, txtFactMonto.Text, cbFactProveedor.Text, "Contado", "0", "Efectivo", cbFactBanco.Text})
                End If

                txtFactFact.Text = ""
                txtFactMonto.Text = ""
                cbFactProveedor.SelectedIndex = -1
                chkFactContado.Checked = False
                chkFactCredito.Checked = False
                cbFactBanco.SelectedIndex = -1
                clbFactFormaPag.SetItemChecked(0, False)
                clbFactFormaPag.SetItemChecked(1, False)
                clbFactFormaPag.SetItemChecked(2, False)
                txtFactPagar.Text = ""

            End If

            If chkFactCredito.Checked.Equals(True) Then
                If Not (nudFactDiasCred.Value = 0) Then
                    If clbFactFormaPag.GetItemChecked(0).Equals(True) Then
                        dgvFactDatos.Rows.Add(New String() {txtFactFact.Text, dtpFact.Text, txtFactMonto.Text, cbFactProveedor.Text, "Contado", nudFactDiasCred.Value, "Cheque", cbFactBanco.Text})
                    End If
                    If clbFactFormaPag.GetItemChecked(1).Equals(True) Then
                        dgvFactDatos.Rows.Add(New String() {txtFactFact.Text, dtpFact.Text, txtFactMonto.Text, cbFactProveedor.Text, "Contado", nudFactDiasCred.Value, "Transferencia", cbFactBanco.Text})
                    End If
                    If clbFactFormaPag.GetItemChecked(2).Equals(True) Then
                        dgvFactDatos.Rows.Add(New String() {txtFactFact.Text, dtpFact.Text, txtFactMonto.Text, cbFactProveedor.Text, "Contado", nudFactDiasCred.Value, "Efectivo", cbFactBanco.Text})
                    End If

                    txtFactFact.Text = ""
                    txtFactMonto.Text = ""
                    cbFactProveedor.SelectedIndex = -1
                    chkFactContado.Checked = False
                    chkFactCredito.Checked = False
                    cbFactBanco.SelectedIndex = -1
                    clbFactFormaPag.SetItemChecked(0, False)
                    clbFactFormaPag.SetItemChecked(1, False)
                    clbFactFormaPag.SetItemChecked(2, False)
                    nudFactDiasCred.Value = 0
                    txtFactPagar.Text = ""

                Else
                    MessageBox.Show("Error, falta indicar los días del crédito", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If

        End If

    End Sub

    Private Sub btnFactRealizar_Click(sender As Object, e As EventArgs) Handles btnFactRealizar.Click
        If rbFactEliminar.Checked.Equals(True) Then

            If dgvFactDatos.Rows.Count = 0 Then
                MessageBox.Show("Tabla vacía, no hay datos que eliminar", "Error de ejecusión", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            Else
                botonOk = MessageBox.Show("¿Esta seguro que desea eliminar los datos de la factura seleccionada?", "Confirmación de eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                If botonOk = vbOK Then
                    dgvFactDatos.Rows.Remove(dgvFactDatos.CurrentRow)
                End If
            End If
        End If

        If rbFactPagar.Checked.Equals(True) Then

            If dgvFactDatos.Rows.Count = 0 Then
                MessageBox.Show("Error, información incompleta, favor revise que toda la información solicitada esté almacenada en la tabla para continuar", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                gbFactPagar.Enabled = True
                txtFactObservacion.Text = "El pago será enviado al departamento de contabilidad para ser validado y cargado al banco correspondiente"
            End If
        End If
    End Sub

    Private Sub btnFactAgregarCuent_Click(sender As Object, e As EventArgs) Handles btnFactAgregarCuent.Click
        lbxCuentas.Items.Add(txtFactReferencia.Text)
        txtFactReferencia.Text = ""
    End Sub

    Private Sub btnFactPagar_Click(sender As Object, e As EventArgs) Handles btnFactPagar.Click

        If lbxCuentas.SelectedIndex <= 0 Then
            MessageBox.Show("Por favor elija la cuenta", "Error de pago", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            botonOk = MessageBox.Show("¿Esta seguro que desea ejecutar el pago?", "Confirmación de pago", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            If botonOk = vbOK Then
                txtFactPagar.Text = "El pago de la factura ha sido efectuado con exito."
                dgvFactDatos.Rows.Remove(dgvFactDatos.CurrentRow)
                txtFactObservacion.Text = ""
                gbFactPagar.Enabled = False
            End If
        End If
    End Sub

    Private Sub chkFactCredito_CheckedChanged(sender As Object, e As EventArgs) Handles chkFactCredito.CheckedChanged
        If chkFactCredito.Checked.Equals(True) And chkFactContado.Checked.Equals(True) Then
            MessageBox.Show("Debe seleccionar solo una de la dos opciones (Crédito o Contado)", "Error de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            chkFactCredito.Checked = False
            chkFactContado.Checked = False
        Else
            If chkFactCredito.Checked.Equals(True) Then
                nudFactDiasCred.Enabled = True
            Else
                nudFactDiasCred.Enabled = False
            End If
        End If

    End Sub

    Private Sub chkFactContado_CheckedChanged(sender As Object, e As EventArgs) Handles chkFactContado.CheckedChanged
        If chkFactCredito.Checked.Equals(True) And chkFactContado.Checked.Equals(True) Then
            MessageBox.Show("Debe seleccionar solo una de la dos opciones (Crédito o Contado)", "Error de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            chkFactCredito.Checked = False
            chkFactContado.Checked = False
        End If
    End Sub

    Private Sub txtFactFact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFactFact.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Error, favor ingresar solo números", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub txtFactMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFactMonto.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Error, favor ingresar solo números", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub btnFactEliminarCuent_Click(sender As Object, e As EventArgs) Handles btnFactEliminarCuent.Click
        If lbxCuentas.SelectedIndex <= 0 Then
            MessageBox.Show("Error, por favor indique seleccione la cuenta a eliminar", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            lbxCuentas.Items.RemoveAt(lbxCuentas.SelectedIndex)
            lbxCuentas.Refresh()
        End If
    End Sub

    Private Sub gbFactPagar_Enter(sender As Object, e As EventArgs) Handles gbFactPagar.Enter
        If gbFactPagar.Enabled = False Then
            txtFactObservacion.Text = ""
        End If
    End Sub

End Class