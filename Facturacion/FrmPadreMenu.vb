Imports System.Windows.Forms

Public Class FrmPadreMenu

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub mnuCascada_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuCascada.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuMVertical_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuMVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuMHorinzontal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuMHorinzontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuOIconos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuOIconos.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Me.Close()
        FrmUsuario.Close()
    End Sub

    Private Sub CrearMostrarHijo(sender As Object, e As EventArgs) Handles mnuNuevaFactura.Click
        Dim Objhijo As New FrmFactura
        Objhijo.MdiParent = Me
        Objhijo.Show()
    End Sub

    Private Sub FrmPadreMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmUsuario.Hide()
    End Sub

    Private Sub FrmPadreMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmUsuario.Close()
    End Sub
End Class
