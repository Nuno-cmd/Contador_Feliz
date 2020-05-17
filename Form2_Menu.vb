
Public Class Form2_Menu

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Application.Exit()
    End Sub

    Private Sub btn_maximizar_Click(sender As Object, e As EventArgs) Handles btn_maximizar.Click
        Me.WindowState = FormWindowState.Maximized
        btn_maximizar.Visible = False
        btn_restaurar.Visible = True
    End Sub

    Private Sub btn_restaurar_Click(sender As Object, e As EventArgs) Handles btn_restaurar.Click
        Me.WindowState = FormWindowState.Normal
        btn_restaurar.Visible = False
        btn_maximizar.Visible = True
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbx_Logout_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pcbx_logout.Click
        Application.Exit()
    End Sub

    Private Sub btn_Administracion_Click(sender As Object, e As EventArgs) Handles btn_Administracion.Click
        pnl_subMenuAdministracion.Visible = True
        pnl_Facturacion.Visible = False
    End Sub

    Private Sub btn_mantenimientoUsuarios_Click(sender As Object, e As EventArgs) Handles btn_mantenimientoUsuarios.Click
        pnl_subMenuAdministracion.Visible = False
        Form3_MantenimientoUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub btn_datosEmpresa_Click(sender As Object, e As EventArgs) Handles btn_datosEmpresa.Click
        pnl_subMenuAdministracion.Visible = False
        Form4_DatosEmpresa.Show()
        Me.Hide()
    End Sub

    Private Sub btn_tipoCambio_Click(sender As Object, e As EventArgs) Handles btn_tipoCambio.Click
        pnl_subMenuAdministracion.Visible = False
    End Sub

    Private Sub btn_Descuento_Click(sender As Object, e As EventArgs) Handles btn_Descuento.Click
        pnl_subMenuAdministracion.Visible = False
    End Sub

    Private Sub btn_Facturacion_Click(sender As Object, e As EventArgs) Handles btn_Facturacion.Click
        pnl_subMenuAdministracion.Visible = False
        pnl_Facturacion.Visible = True
    End Sub

    Private Sub btn_facturarCliente_Click(sender As Object, e As EventArgs) Handles btn_facturarCliente.Click
        pnl_Facturacion.Visible = False
        Form6_Facturar.Show()
        Me.Hide()
    End Sub

    Private Sub btn_facturaElectronica_Click(sender As Object, e As EventArgs) Handles btn_facturaElectronica.Click
        pnl_Facturacion.Visible = False
        Form7_FacturaElectronica.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Inicio_Click(sender As Object, e As EventArgs) Handles btn_Inicio.Click
        pnl_Facturacion.Visible = False
        pnl_subMenuAdministracion.Visible = False
    End Sub

    Private Sub btn_Clientes_Click(sender As Object, e As EventArgs) Handles btn_Clientes.Click
        pnl_Facturacion.Visible = False
        pnl_subMenuAdministracion.Visible = False
        Form5_MantenimientoClientes.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Productos_Click(sender As Object, e As EventArgs) Handles btn_Productos.Click
        pnl_Facturacion.Visible = False
        pnl_subMenuAdministracion.Visible = False
        Form5b_Productos.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_Documentos_Click(sender As Object, e As EventArgs) Handles btn_Documentos.Click
        pnl_Facturacion.Visible = False
        pnl_subMenuAdministracion.Visible = False
        Form8_DocumentosEmitidos.Show()
        Me.Hide()
    End Sub
End Class
