Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form6_Facturar

    Dim SQLCmd As New SqlCommand
    Dim conexion As New SqlConnection
    Dim cad_Provincia As String
    Dim cad_Canton As String
    Dim cad_Distrito As String
    Dim cad_tipoID, cad_Ar, cad_tipoDocumento, cad_condicionVenta As String
    Dim cad_unidadMedida As String
    Dim bandera As String
    Dim path As String
    Dim busca As Integer


    Private Sub Form6_Facturar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            bandera = " la conexion"
            path = My.Computer.FileSystem.ReadAllText("C:\Users\Fauricio\Desktop\SISTEMAS\Programacion III\Lecciones\Proyectos\Contador_Final\My Project\Path1.txt")
            conexion.ConnectionString = "Data Source=LAPTOP-5FFLL852\SQLEXPRESS;Initial Catalog=" + path
            conexion.Open()


            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()
            End If

            bandera = " tipo de identificacion"
            SeleccionarIdentificacion()
            bandera = " selección de país"
            SeleccionarPais()
            bandera = " Unidad de Medida"
            SeleccionarUnidadMedida()
            bandera = " Tipo de Documento"
            SeleccionarTipoDocumento()
            bandera = " Condición venta"
            SeleccionarCondicionVenta()
            bandera = " Medio de Pago"
            SeleccionarMedioPago()
            bandera = " Medio de Pago"
            calcularMonto()

            mostrar()
            bandera = " query selección de provincia en base de datos SQL"
            Dim sql As String
            sql = "SELECT * FROM Provincia"
            Dim adaptador As SqlDataAdapter
            Dim dt As DataTable

            bandera = " adaptador de SQL en selección de provincia"

            adaptador = New SqlDataAdapter(sql, conexion)
            dt = New DataTable

            bandera = " llenado de listas de provincias en ComboBox"
            adaptador.Fill(dt)

            bandera = " display de Provincia"
            cbx_Provincia.DisplayMember = "nombreProvincia"
            cbx_Provincia.ValueMember = "IdProvincia"
            cbx_Provincia.DataSource = dt
            cbx_Provincia.ResetText()
            cbx_Provincia.SelectedText = "Seleccionar"

        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

        End Try

    End Sub

    Private Function Sumar(ByVal nombre_Columna As String, ByVal Dgv As DataGridView) As Double

        Dim Total As Double
        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  

        Try

            If Dgv.RowCount > 0 Then
                For i As Integer = 0 To Dgv.RowCount - 1
                    Total = Total + CDbl(Dgv.Item(nombre_Columna.ToLower, i).Value)
                Next
                Return Total
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return Nothing
        End Try

    End Function
    Public Sub calcularMonto()


        txt_subtotal.Text = "¢./ " & FormatNumber((0.87 * Sumar("Total_Linea", DGV_detalleVenta)), 2)
        txt_impuestoMonto.Text = "¢./ " & FormatNumber((0.13 * Sumar("Total_Linea", DGV_detalleVenta)), 2)
        txt_montoTotal.Text = "¢./ " & FormatNumber(Sumar("Total_Linea", DGV_detalleVenta), 2).ToString

    End Sub


    Public Sub limpiarLinea()

        txt_codProducto.Clear()
        txt_precioUnitario.Clear()
        txt_descripcionProducto.Clear()
        txt_cantidadProducto.Clear()
        txt_lineaTotal.Clear()


    End Sub
    Private Sub buscar()
        Dim dt As New DataTable
        Dim consulta As String = "SELECT * FROM Detalle_Venta WHERE Codigo = '" & txt_codProducto.Text & "'"
        Dim comando As New SqlCommand(consulta, conexion)
        Dim dr As SqlDataReader


        Try
            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()
            End If

            bandera = " DataReader"
            dr = comando.ExecuteReader

            bandera = " verificación de usuario registrado"

            If dr.Read() Then
                busca = 1
            Else
                busca = 0
            End If

        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try

        conexion.Close()
    End Sub

    Public Sub mostrar()
        Try
            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()
            End If

            bandera = " query selección de productos en base de datos SQL"
            Dim sql As String = "SELECT * FROM Detalle_Venta"
            Dim SQLCmd As New SqlCommand(sql, conexion)

            bandera = " adaptador de SQL en llenado de DataGridView con detalles de venta"
            Dim adaptador As New SqlDataAdapter(SQLCmd)
            Dim ds As New DataSet

            bandera = " llenado de adaptador DataGridView con los detalles de venta"
            adaptador.Fill(ds, "Detalle_Venta")

            bandera = " verificación de existencia de tabla clientes"
            If ds.Tables.Count > 0 Then 'Busca que existan tablas del query..
                bandera = " llenado de DataGridView con los clientes"
                DGV_detalleVenta.DataSource = ds.Tables(0)
            End If

        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try
    End Sub

    Public Sub eliminar()
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar la línea de producto", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            Try
                bandera = " verificación de apertura de la conexión"
                If conexion.State <> ConnectionState.Open Then
                    bandera = " conexión"
                    conexion.Open()
                End If

                Dim strInsert As String

                strInsert = ""
                strInsert &= "Delete from Detalle_Venta where Codigo='" & txt_codEliminar.Text & "'"


                bandera = " SqlCommand de registrar datos en SQL Server"
                SQLCmd = New SqlCommand(strInsert, conexion)
                SQLCmd.ExecuteNonQuery()

                MsgBox("Línea de Producto eliminada Exitosamente", vbInformation, "Mensaje")
                mostrar()
                limpiarLinea()

            Catch ex As Exception

                MsgBox("Error al procesar " & bandera, vbInformation, "Error")

            End Try
            conexion.Close()

            txt_codEliminar.Clear()

        End If
    End Sub


    Public Sub mostrarDetallesVenta()
        Try
            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()
            End If

            bandera = " query selección de productos en base de datos SQL"
            Dim sql As String = "SELECT * FROM Detalle_Venta"
            Dim SQLCmd As New SqlCommand(sql, conexion)

            bandera = " adaptador de SQL en llenado de DataGridView con detalles de la venta"
            Dim adaptador As New SqlDataAdapter(SQLCmd)
            Dim ds As New DataSet

            bandera = " llenado de adaptador DataGridView con los detalles de la venta"
            adaptador.Fill(ds, "Productos")

            bandera = " verificación de existencia de tabla detalles de venta"
            If ds.Tables.Count > 0 Then 'Busca que existan tablas del query..
                bandera = " llenado de DataGridView con los detalles de venta"
                DGV_detalleVenta.DataSource = ds.Tables(0)
            End If

        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try
    End Sub
    Public Sub SeleccionarPais()

        Try

            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                bandera = " conexión"
                conexion.Open()
            End If

            bandera = " query selección de país en base de datos SQL"
            Dim sql As String
            sql = "SELECT * FROM paises order by PaisNombre;"
            Dim adaptador As SqlDataAdapter
            Dim dt As DataTable

            bandera = " adaptador de SQL en selección de país"
            adaptador = New SqlDataAdapter(sql, conexion)
            dt = New DataTable

            bandera = " llenado de listas de países en ComboBox"
            adaptador.Fill(dt)

            bandera = " display de País"
            cbx_pais.DataSource = dt
            cbx_pais.DisplayMember = "PaisNombre"
            cbx_pais.ValueMember = "PaisNombre"
            cbx_pais.ResetText()
            cbx_pais.SelectedText = "Seleccionar"

        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

        End Try

    End Sub
    Public Sub SeleccionarIdentificacion()

        Try
            Dim sql As String

            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                bandera = " conexión"
                conexion.Open()
            End If

            bandera = " query selección del tipo de identificación en base de datos SQL"
            sql = "SELECT * FROM Identificacion"
            Dim adaptador As SqlDataAdapter
            Dim dt As DataTable

            bandera = " adaptador de SQL en selección de tipo de identificación"
            adaptador = New SqlDataAdapter(sql, conexion)
            dt = New DataTable

            bandera = " llenado de tipo de identificación en ComboBox"
            adaptador.Fill(dt)

            bandera = " display de Tipo de Identificación"
            cbx_tipoID.DataSource = dt
            cbx_tipoID.DisplayMember = "Tipo_Identificacion"
            cbx_tipoID.ValueMember = "Tipo_Identificacion"
            cbx_tipoID.ResetText()
            cbx_tipoID.SelectedText = "Seleccionar"

        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

        End Try

    End Sub

    Public Sub SeleccionarTipoDocumento()

        Try
            Dim sql As String

            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                bandera = " conexión"
                conexion.Open()
            End If

            bandera = " query selección del tipo de identificación en base de datos SQL"
            sql = "SELECT * FROM Tipo_Documento"
            Dim adaptador As SqlDataAdapter
            Dim dt As DataTable

            bandera = " adaptador de SQL en selección de tipo de documento"
            adaptador = New SqlDataAdapter(sql, conexion)
            dt = New DataTable

            bandera = " llenado de tipo de documento en ComboBox"
            adaptador.Fill(dt)

            bandera = " display de Tipo de Documento"
            cbx_tipoDocumento.DataSource = dt
            cbx_tipoDocumento.DisplayMember = "Tipo_Documento"
            cbx_tipoDocumento.ValueMember = "Tipo_Documento"
            cbx_tipoDocumento.ResetText()
            cbx_tipoDocumento.SelectedText = "Seleccionar"

        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

        End Try

    End Sub

    Public Sub SeleccionarCondicionVenta()

        Try
            Dim sql As String

            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                bandera = " conexión"
                conexion.Open()
            End If

            bandera = " query selección de la condición de venta en base de datos SQL"
            sql = "SELECT * FROM Condicion_Venta"
            Dim adaptador As SqlDataAdapter
            Dim dt As DataTable

            bandera = " adaptador de SQL en selección de condición de venta"
            adaptador = New SqlDataAdapter(sql, conexion)
            dt = New DataTable

            bandera = " llenado de condición de venta en ComboBox"
            adaptador.Fill(dt)

            bandera = " display de Condición de venta"
            cbx_condicionVenta.DataSource = dt
            cbx_condicionVenta.DisplayMember = "Condicion_Venta"
            cbx_condicionVenta.ValueMember = "Condicion_Venta"
            cbx_condicionVenta.ResetText()
            cbx_condicionVenta.SelectedText = "Seleccionar"

        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

        End Try

    End Sub

    Public Sub SeleccionarMedioPago()

        Try
            Dim sql As String

            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                bandera = " conexión"
                conexion.Open()
            End If

            bandera = " query selección del medio de pago en base de datos SQL"
            sql = "SELECT * FROM Medio_Pago"
            Dim adaptador As SqlDataAdapter
            Dim dt As DataTable

            bandera = " adaptador de SQL en selección de medio de pago"
            adaptador = New SqlDataAdapter(sql, conexion)
            dt = New DataTable

            bandera = " llenado de medio de pago en ComboBox"
            adaptador.Fill(dt)

            bandera = " display de medio de pago"
            cbx_medioPago.DataSource = dt
            cbx_medioPago.DisplayMember = "Medio_Pago"
            cbx_medioPago.ValueMember = "Medio_Pago"
            cbx_medioPago.ResetText()
            cbx_medioPago.SelectedText = "Seleccionar"

        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

        End Try

    End Sub
    Public Sub Cbx_tipoID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tipoID.SelectedIndexChanged
        Try
            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()
            End If

            bandera = " asignación de ValueMember en Identificación"
            cbx_tipoID.ValueMember = "Id"

            bandera = " visibilidad de Items para Persona Jurídica"
            If cbx_tipoID.SelectedValue > 1 Then
                txt_apellido1.Enabled = False
                txt_apellido2.Enabled = False
                txt_apellido1.Text = "No Aplica"
                txt_apellido2.Text = "No Aplica"
            Else
                txt_apellido1.Enabled = True
                txt_apellido2.Enabled = True
            End If

        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

        End Try

    End Sub

    Public Sub Cbx_pais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_pais.SelectedIndexChanged
        Try
            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()
            End If

            bandera = " asignación de ValueMember en Pais"
            cbx_pais.ValueMember = "PaisArea"

            bandera = " visibilidad de Items para provincia, canton y distrito"
            If (cbx_pais.SelectedValue = "506") Then
                cbx_Provincia.Enabled = True
                cbx_Canton.Enabled = True
                cbx_Distrito.Enabled = True
            Else
                cbx_Provincia.Enabled = False
                cbx_Canton.Enabled = False
                cbx_Distrito.Enabled = False
            End If

        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

        End Try


    End Sub
    Public Sub Cbx_Provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Provincia.SelectedIndexChanged
        ' Proceso que Selecciona la Provincia y llena el Combobox Canton
        Try

            Dim sql, prov As String
            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()
            End If
            prov = cbx_Provincia.SelectedValue.ToString

            bandera = " query selección de cantón en base de datos SQL"
            sql = "SELECT IdCanton, nombreCanton FROM Canton WHERE IdProvincia = " & prov
            Dim adaptador As SqlDataAdapter
            Dim dt As DataTable

            bandera = " adaptador de SQL en selección de cantón"
            adaptador = New SqlDataAdapter(sql, conexion)
            dt = New DataTable

            bandera = " llenado de cantones en ComboBox"
            adaptador.Fill(dt)

            cbx_Canton.DisplayMember = "nombreCanton"
            cbx_Canton.ValueMember = "IdCanton"
            cbx_Canton.DataSource = dt
            cbx_Canton.ResetText()
            cbx_Canton.SelectedText = "Seleccionar"

        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

        End Try

    End Sub

    Public Sub Cbx_Canton_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Canton.SelectedIndexChanged
        ' Proceso que Selecciona el Cantón, llena el Combobox Distrito y selecciona el distrito

        Try

            Dim sql, can As String
            can = cbx_Canton.SelectedValue.ToString

            bandera = " query selección de distrito en base de datos SQL"
            sql = "SELECT IdDistrito, nombreDistrito from Distrito WHERE IdCanton = " & can
            Dim adaptador As SqlDataAdapter
            Dim dt As DataTable

            bandera = " adaptador de SQL en selección de distrito"
            adaptador = New SqlDataAdapter(sql, conexion)
            dt = New DataTable

            bandera = " llenado de distritos en ComboBox"
            adaptador.Fill(dt)

            cbx_Distrito.DisplayMember = "nombreDistrito"
            cbx_Distrito.ValueMember = "nombreDistrito"
            cbx_Distrito.DataSource = dt
            cbx_Distrito.ResetText()
            cbx_Distrito.SelectedText = "Seleccionar"

        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

        End Try

    End Sub

    Public Sub SeleccionarUnidadMedida()

        Try

            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                bandera = " conexión"
                conexion.Open()
            End If

            bandera = " query selección de unidad de medida en base de datos SQL"
            Dim sql As String
            sql = "SELECT * FROM Medidas order by Id_UM;"
            Dim adaptador As SqlDataAdapter
            Dim dt As DataTable

            bandera = " adaptador de SQL en selección de unidad de medida"
            adaptador = New SqlDataAdapter(sql, conexion)
            dt = New DataTable

            bandera = " llenado de unidades de medida en ComboBox"
            adaptador.Fill(dt)

            bandera = " display de unidades de medida"
            cbx_unidadMedida.DataSource = dt
            cbx_unidadMedida.DisplayMember = "Unidad_Medida"
            cbx_unidadMedida.ValueMember = "Unidad_Medida"


        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

        End Try


    End Sub
    Private Sub Btn_Restaurar_Click(sender As Object, e As EventArgs) Handles btn_Restaurar.Click
        Me.WindowState = FormWindowState.Normal
        btn_Restaurar.Visible = False
        btn_Maximizar.Visible = True
    End Sub

    Private Sub Btn_Maximizar_Click(sender As Object, e As EventArgs) Handles btn_Maximizar.Click
        Me.WindowState = FormWindowState.Maximized
        btn_Maximizar.Visible = False
        btn_Restaurar.Visible = True
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Application.Exit()
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Form2_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_buscaEmpresa_Click(sender As Object, e As EventArgs) Handles btn_buscaEmpresa.Click
        Dim dt As New DataTable
        Dim consulta As String = "SELECT * FROM Empresa1 WHERE Nom_Comercial = '" & txt_buscaEmpresa.Text & "'"
        Dim comando As New SqlCommand(consulta, conexion)
        Dim dr As SqlDataReader

        Try
            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()
            End If

            Try
                bandera = " DataReader"
                dr = comando.ExecuteReader

                bandera = " verificación de empresa registrada"
                If txt_buscaEmpresa.Text = "" Then
                    MsgBox("Debe incluir la empresa")
                    conexion.Close()

                Else
                    If dr.Read() Then
                        bandera = " recuperación de Nombre"
                        txt_nombreComercial.Text = dr.Item("Nom_Comercial").ToString
                        txt_nombreEmpresa.Text = dr.Item("Nombre").ToString
                        txt_Apellido1Empresa.Text = dr.Item("Apellido1").ToString
                        txt_Apellido2Empresa.Text = dr.Item("Apellido2").ToString
                        txt_TipoIDEmpresa.Text = dr.Item("Tipo_Cedula").ToString
                        txt_IDEmpresa.Text = dr.Item("Cedula").ToString
                        txt_ProvinciaEmpresa.Text = dr.Item("Provincia").ToString
                        txt_CantonEmpresa.Text = dr.Item("Canton").ToString
                        txt_DistritoEmpresa.Text = dr.Item("Distrito").ToString
                        txt_DireccionEmpresa.Text = dr.Item("Direccion").ToString
                        txt_Tel1Empresa.Text = dr.Item("Telefono").ToString
                        txt_Tel2Empresa.Text = dr.Item("Telefono2").ToString
                        txt_FaxEmpresa.Text = dr.Item("Fax").ToString
                        txt_emailEmpresa.Text = dr.Item("Email").ToString
                        txt_moneda.Text = dr.Item("Moneda").ToString

                    Else
                        MsgBox("La empresa digitada no se encuentra registrada")
                        txt_buscaEmpresa.Clear()
                    End If
                    conexion.Close()

                End If
            Catch ex As Exception
                MsgBox("Error al procesar " & bandera, vbInformation, "Error")
            End Try

        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try
    End Sub

    Private Sub btn_buscarCliente_Click(sender As Object, e As EventArgs) Handles btn_buscarCliente.Click
        Dim dt As New DataTable
        Dim consulta As String = "SELECT * FROM Clientes WHERE Cedula = '" & txt_cedula.Text & "'"
        Dim comando As New SqlCommand(consulta, conexion)
        Dim dr As SqlDataReader

        Try
            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()
            End If

            Try
                bandera = " DataReader"
                dr = comando.ExecuteReader

                bandera = " verificación de usuario registrado"
                If txt_cedula.Text = "" Then
                    MsgBox("Debe incluir el usuario")
                    conexion.Close()

                Else
                    If dr.Read() Then
                        bandera = " recuperación de Nombre"
                        txt_nombreCliente.Text = dr.Item("Nombre").ToString

                        bandera = " recuperación de apellidos"
                        If cbx_tipoID.SelectedValue < 2 Then
                            txt_apellido1.Text = dr.Item("Apellido1").ToString
                            txt_apellido2.Text = dr.Item("Apellido2").ToString
                        End If
                        txt_emailCliente.Text = dr.Item("Email").ToString
                        txt_telefonoCliente.Text = dr.Item("Telefono").ToString
                        cbx_pais.SelectedValue = dr.Item("Area").ToString
                        cbx_tipoID.SelectedValue = dr.Item("Tipo_Cedula").ToString
                        txt_direccionCliente.Text = dr.Item("Direccion").ToString

                    Else
                        MsgBox("El usuario digitado no se encuentra registrado")
                        txt_cedula.Clear()
                    End If
                    conexion.Close()

                End If
            Catch ex As Exception
                MsgBox("Error al procesar " & bandera, vbInformation, "Error")
            End Try

        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try
    End Sub

    Private Sub btn_buscarProducto_Click(sender As Object, e As EventArgs) Handles btn_buscarProducto.Click
        Dim dt As New DataTable
        Dim consulta As String = "SELECT * FROM Productos WHERE Codigo = '" & txt_codProducto.Text & "'"
        Dim comando As New SqlCommand(consulta, conexion)
        Dim dr As SqlDataReader
        Dim cadena As String

        Try
            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()
            End If

            Try
                bandera = " DataReader"
                dr = comando.ExecuteReader

                bandera = " verificación de producto registrado"
                If txt_codProducto.Text = "" Then
                    MsgBox("Debe incluir el codigo del producto")
                    conexion.Close()

                Else
                    If dr.Read() Then
                        bandera = " recuperación de Nombre"
                        txt_descripcionProducto.Text = dr.Item("Descripcion").ToString
                        cadena = dr.Item("Precio_Unitario").ToString
                        txt_precioUnitario.Text = Replace(cadena, ",", ".")
                        cbx_unidadMedida.SelectedValue = dr.Item("Unidad_Medida").ToString

                    Else
                        MsgBox("El código de producto no se encuentra registrado")
                        txt_codProducto.Clear()
                    End If
                    conexion.Close()

                End If
            Catch ex As Exception
                MsgBox("Error al procesar " & bandera, vbInformation, "Error")
            End Try

        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try
    End Sub

    Private Sub btn_limpiarLinea_Click(sender As Object, e As EventArgs) Handles btn_limpiarLinea.Click
        limpiarLinea()
    End Sub

    Public Sub registrarLinea()

        Dim cant, pu As Double

        Try
            If conexion.State <> ConnectionState.Open Then
                bandera = " conexión"
                conexion.Open()
            End If

            bandera = " selección unidad de medida, debe elegir opción"
            cbx_unidadMedida.ValueMember = "Unidad_Medida"
            cad_unidadMedida = cbx_unidadMedida.SelectedValue.ToString

            cant = CDbl(txt_cantidadProducto.Text)
            pu = CDbl(txt_precioUnitario.Text)

            txt_lineaTotal.Text = CStr(cant * pu)

            bandera = " registro de Datos del formulario en SQL Server"

            If txt_codProducto.Text = "" Then
                MsgBox("Debe ingresar el código de producto", vbInformation, "Mensaje")

            ElseIf txt_descripcionProducto.Text = "" Then
                MsgBox("Debe ingresar la descripción del producto", vbInformation, "Mensaje")

            ElseIf txt_precioUnitario.Text = "" Then
                MsgBox("Debe ingresar el precio unitario del producto", vbInformation, "Mensaje")

            Else

                Dim strInsert As String = "Insert into Detalle_Venta (Codigo, Descripcion, Cantidad, Precio_Unitario, Total_Linea)" &
                        "Values ('" + txt_codProducto.Text + "'," & "'" + txt_descripcionProducto.Text + "'," & "'" & CDbl(txt_cantidadProducto.Text) & "'," & "'" & CDbl(txt_precioUnitario.Text) & "'," & "'" & CDbl(txt_lineaTotal.Text) & "'" & ")"


                bandera = " SqlCommand de registrar datos en SQL Server"
                SQLCmd = New SqlCommand(strInsert, conexion)
                SQLCmd.ExecuteNonQuery()

                MsgBox("Producto Registrado Exitosamente", vbInformation, "Mensaje")
                mostrarDetallesVenta()
                limpiarLinea()

            End If
        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

            conexion.Close()

        End Try
    End Sub

    Private Sub btn_agregarLinea_Click(sender As Object, e As EventArgs) Handles btn_agregarLinea.Click
        registrarLinea()
        calcularMonto()
    End Sub

    Private Sub btn_eliminarLinea_Click(sender As Object, e As EventArgs) Handles btn_eliminarLinea.Click
        If txt_codEliminar.Text = "" Then
            MsgBox("Debe ingresar el código del producto a eliminar", vbInformation, "Mensaje")
        Else
            buscarEliminar()
            If busca > 0 Then
                eliminar()
            Else
                MsgBox("El producto que desea eliminar no se encuentra registrado.", vbInformation, "Mensaje")
            End If
        End If
    End Sub

    Private Sub btn_registrarDocumento_Click(sender As Object, e As EventArgs) Handles btn_registrarDocumento.Click
        registrarDocumento()
    End Sub

    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        registrarDocumento()

    End Sub

    Private Sub horafecha_Tick(sender As Object, e As EventArgs) Handles horafecha.Tick
        txt_hora.Text = DateTime.Now.ToLongTimeString()
        txt_fecha.Text = DateTime.Now.ToLongDateString()
    End Sub
    Public Sub registrarDocumento()
        Try
            If conexion.State <> ConnectionState.Open Then
                bandera = " conexión"
                conexion.Open()
            End If

            bandera = " selección Tipo de Documento, debe elegir opción"
            cbx_tipoDocumento.ValueMember = "Tipo_Documento"
            cad_tipoDocumento = cbx_tipoDocumento.SelectedValue.ToString


            bandera = " selección de condición de venta, debe elegir opción"
            cbx_condicionVenta.ValueMember = "Condicion_Venta"
            cad_condicionVenta = cbx_condicionVenta.SelectedValue.ToString

            If txt_referencia.Text = "" Then
                MsgBox("Debe ingresar el número de referencia", vbInformation, "Mensaje")

            ElseIf txt_numDocumento.Text = "" Then
                MsgBox("Debe ingresar el número de Documento", vbInformation, "Mensaje")

            ElseIf txt_nombreCliente.Text = "" Then
                MsgBox("Debe ingresar el nombre del Cliente", vbInformation, "Mensaje")

            ElseIf txt_cedula.Text = "" Then
                MsgBox("Debe ingresar el número de identificación", vbInformation, "Mensaje")

            Else

                Dim strInsert As String = "Insert into Documentos (Referencia, Numero_Documento , Cliente, Identificacion, Tipo_Factura, Fecha, Hora, Moneda, Monto, Estado)" &
                        "Values ('" + txt_referencia.ToString + "'," & "'" & CInt(txt_numDocumento.Text) & "'," & "'" + txt_nombreCliente.Text + "'," & "'" + txt_cedula.Text + "'," & "'" & cad_tipoDocumento.ToString & "'," & "'" + txt_fecha.Text + "'," & "'" + txt_hora.Text + "'," & "'" + txt_moneda.Text + "'," & "'" + txt_montoTotal.Text + "'," & "'" & cad_condicionVenta.ToString & "'" & ")"

                bandera = " SqlCommand de registrar datos en SQL Server"
                SQLCmd = New SqlCommand(strInsert, conexion)
                SQLCmd.ExecuteNonQuery()

                MsgBox("Documento Registrado Exitosamente", vbInformation, "Mensaje")
                mostrar()
                'limpiar()

            End If
        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

            conexion.Close()

        End Try
    End Sub

    Private Sub buscarEliminar()
        Dim dt As New DataTable
        Dim consulta As String = "SELECT * FROM Detalle_Venta WHERE Codigo = '" & txt_codEliminar.Text & "'"
        Dim comando As New SqlCommand(consulta, conexion)
        Dim dr As SqlDataReader

        Try
            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()
            End If

            bandera = " DataReader"
            dr = comando.ExecuteReader

            bandera = " verificación de producto registrado"

            If dr.Read() Then
                busca = 1
            Else
                busca = 0
            End If

        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try

        conexion.Close()
    End Sub

End Class