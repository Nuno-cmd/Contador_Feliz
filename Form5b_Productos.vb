Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Form5b_Productos

    Dim SQLCmd As New SqlCommand
    Dim conexion As New SqlConnection
    Dim cad_unidadMedida As String
    Dim bandera As String
    Dim path As String
    Dim busca As Integer

    Private Sub Form5b_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Proceso que llena el Combobox Provincia
        Try

            bandera = " la conexion"
            path = My.Computer.FileSystem.ReadAllText("C:\Users\Fauricio\Desktop\SISTEMAS\Programacion III\Lecciones\Proyectos\Contador_Final\My Project\Path1.txt")
            conexion.ConnectionString = "Data Source=LAPTOP-5FFLL852\SQLEXPRESS;Initial Catalog=" + path
            conexion.Open()
            limpiar()
            mostrar()

            bandera = " selección de unidad de medida"
            SeleccionarUnidadMedida()

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
    Public Sub limpiar()

        txt_codProducto.Clear()
        txt_precioUnitario.Clear()
        txt_descripcionProducto.Clear()

    End Sub

    Public Sub buscar()
        ' Verifica existencia del producto
        Dim dt As New DataTable
        Dim consulta As String = "SELECT * FROM Productos WHERE Codigo = '" & txt_codProducto.Text & "'"
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
                MsgBox("El producto digitado se encuentra registrado.", vbInformation, "Mensaje")
                busca = 1
            Else
                busca = 0
            End If

        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try

        conexion.Close()
    End Sub
    Private Sub btn_buscarProducto_Click(sender As Object, e As EventArgs) Handles btn_buscarProducto.Click

        'Busca el producto y llena textbox y combobox con datos del producto encontrado
        Dim dt As New DataTable
        Dim consulta As String = "SELECT * FROM Productos WHERE Codigo = '" & txt_codProducto.Text & "'"
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

                bandera = " verificación de producto registrado"
                If txt_codProducto.Text = "" Then
                    MsgBox("Debe incluir el codigo del producto")
                    conexion.Close()

                Else
                    If dr.Read() Then
                        bandera = " recuperación de Nombre"
                        txt_descripcionProducto.Text = dr.Item("Descripcion").ToString
                        txt_precioUnitario.Text = dr.Item("Precio_Unitario").ToString
                        cbx_unidadMedida.SelectedValue = dr.Item("Unidad_Medida").ToString

                    Else
                        MsgBox("El código de producto no se encuentra registrado")
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

    Public Sub mostrar()
        Try
            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()
            End If

            bandera = " query selección de productos en base de datos SQL"
            Dim sql As String = "SELECT * FROM Productos"
            Dim SQLCmd As New SqlCommand(sql, conexion)

            bandera = " adaptador de SQL en llenado de DataGridView con productos"
            Dim adaptador As New SqlDataAdapter(SQLCmd)
            Dim ds As New DataSet

            bandera = " llenado de adaptador DataGridView con los productos"
            adaptador.Fill(ds, "Productos")

            bandera = " verificación de existencia de tabla productos"
            If ds.Tables.Count > 0 Then 'Busca que existan tablas del query..
                bandera = " llenado de DataGridView con los productos"
                DGV_Productos.DataSource = ds.Tables(0)
            End If

        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try
    End Sub

    Public Sub registrar()
        Try
            If conexion.State <> ConnectionState.Open Then
                bandera = " conexión"
                conexion.Open()
            End If

            bandera = " selección unidad de medida, debe elegir opción"
            cbx_unidadMedida.ValueMember = "Unidad_Medida"
            cad_unidadMedida = cbx_unidadMedida.SelectedValue.ToString


            bandera = " registro de Datos del formulario en SQL Server"

            If txt_codProducto.Text = "" Then
                MsgBox("Debe ingresar el código de producto", vbInformation, "Mensaje")

            ElseIf txt_descripcionProducto.Text = "" Then
                MsgBox("Debe ingresar la descripción del producto", vbInformation, "Mensaje")

            ElseIf txt_precioUnitario.Text = "" Then
                MsgBox("Debe ingresar el precio unitario del producto", vbInformation, "Mensaje")

            Else

                Dim strInsert As String = "Insert into Productos (Codigo, Descripcion, Unidad_Medida, Precio_Unitario)" &
                        "Values ('" + txt_codProducto.Text + "'," & "'" + txt_descripcionProducto.Text + "'," & "'" & cad_unidadMedida.ToString & "'," & "'" + txt_precioUnitario.Text + "'" & ")"

                bandera = " SqlCommand de registrar datos en SQL Server"
                SQLCmd = New SqlCommand(strInsert, conexion)
                SQLCmd.ExecuteNonQuery()

                MsgBox("Producto Registrado Exitosamente", vbInformation, "Mensaje")
                mostrar()
                limpiar()

            End If
        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

            conexion.Close()

        End Try
    End Sub

    Public Sub actualizar()
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del producto?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            Try

                bandera = " verificación de apertura de la conexión"
                If conexion.State <> ConnectionState.Open Then
                    bandera = " conexión"
                    conexion.Open()
                End If


                bandera = " unidad de medida, debe elegir opción"
                    cbx_unidadMedida.ValueMember = "Unidad_Medida"
                    cad_unidadMedida = cbx_unidadMedida.SelectedValue.ToString


                    bandera = " registro de Datos del formulario en SQL Server"

                If txt_codProducto.Text = "" Then
                    MsgBox("Debe ingresar el código de producto", vbInformation, "Mensaje")

                ElseIf txt_descripcionProducto.Text = "" Then
                    MsgBox("Debe ingresar la descripción del producto", vbInformation, "Mensaje")

                ElseIf txt_precioUnitario.Text = "" Then
                    MsgBox("Debe ingresar el precio unitario del producto", vbInformation, "Mensaje")

                Else
                    bandera = " registro de Datos del formulario en SQL Server"

                    Dim strInsert As String
                    strInsert = ""
                    strInsert &= "Update Productos set Descripcion='" & txt_descripcionProducto.Text & "' where Descripcion='" & txt_codProducto.Text & "'"
                    strInsert &= "Update Productos set Unidad_Medida='" & cad_unidadMedida.ToString & "' where Codigo='" & txt_codProducto.Text & "'"
                    strInsert &= "Update Productos set Precio_Unitario='" & txt_precioUnitario.Text & "' where Codigo='" & txt_codProducto.Text & "'"

                    bandera = " SqlCommand de registrar datos en SQL Server"
                    SQLCmd = New SqlCommand(strInsert, conexion)
                    SQLCmd.ExecuteNonQuery()

                    MsgBox("Producto Modificado Exitosamente", vbInformation, "Mensaje")
                    mostrar()
                    limpiar()

                End If

            Catch ex As Exception

                MsgBox("Error al procesar " & bandera, vbInformation, "Error")

            End Try
            conexion.Close()


        End If
    End Sub

    Public Sub eliminar()
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar el producto?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            Try
                bandera = " verificación de apertura de la conexión"
                If conexion.State <> ConnectionState.Open Then
                    bandera = " conexión"
                    conexion.Open()
                End If

                Dim strInsert As String

                strInsert = ""
                strInsert &= "Delete from Productos where Codigo='" & txt_codProducto.Text & "'"


                bandera = " SqlCommand de registrar datos en SQL Server"
                SQLCmd = New SqlCommand(strInsert, conexion)
                SQLCmd.ExecuteNonQuery()

                MsgBox("Producto Eliminado Exitosamente", vbInformation, "Mensaje")
                mostrar()
                limpiar()

            Catch ex As Exception

                MsgBox("Error al procesar " & bandera, vbInformation, "Error")

            End Try
            conexion.Close()


        End If
    End Sub

    Private Sub btn_Restaurar_Click(sender As Object, e As EventArgs) Handles btn_Restaurar.Click
        Try
            bandera = " visibilidad de botones al restaurar ventana"
            Me.WindowState = FormWindowState.Normal
            btn_Restaurar.Visible = False
            btn_Maximizar.Visible = True

        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try
    End Sub

    Private Sub btn_Maximizar_Click(sender As Object, e As EventArgs) Handles btn_Maximizar.Click
        Try
            bandera = " visibilidad de botones al maximizar ventana"
            Me.WindowState = FormWindowState.Maximized
            btn_Maximizar.Visible = False
            btn_Restaurar.Visible = True
        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Try
            bandera = " boton de cerrar ventana"
            Application.Exit()
        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Try
            bandera = " boton atrás"
            Form2_Menu.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try
    End Sub

    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_Minimizar.Click
        Try
            bandera = " boton minimizar ventana"
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try
    End Sub

    Private Sub btn_mostrar_Click_1(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        mostrar()
    End Sub


    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        limpiar()
    End Sub


    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If txt_codProducto.Text = "" Then
            MsgBox("Debe ingresar el código del producto", vbInformation, "Mensaje")
        Else
            buscar()
            If busca > 0 Then
                eliminar()
            Else
                MsgBox("El producto que desea eliminar no se encuentra registrado.", vbInformation, "Mensaje")
            End If
        End If
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        buscar()
        If busca > 0 Then
            actualizar()
        Else
            registrar()
        End If
    End Sub

    Private Sub btn_actualizar_Click_1(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        buscar()
        If busca > 0 Then
            actualizar()
        Else
            MsgBox("El producto que desea actualizar no se encuentra registrado. Proceda a Registrarlo", vbInformation, "Mensaje")

        End If
    End Sub

    Private Sub txt_codProducto_Validating(sender As Object, e As CancelEventArgs) Handles txt_codProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm5.SetError(sender, "")
        Else
            Me.ErrorProviderForm5.SetError(sender, " debe ingresar el código de producto, este dato es obligatorio")
        End If
    End Sub


    Private Sub txt_precioUnitario_Validating(sender As Object, e As CancelEventArgs) Handles txt_precioUnitario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm5.SetError(sender, "")
        Else
            Me.ErrorProviderForm5.SetError(sender, " debe ingresar el precio unitario, este dato es obligatorio")
        End If
    End Sub

    Private Sub txt_descripcionProducto_Validating(sender As Object, e As CancelEventArgs) Handles txt_descripcionProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm5.SetError(sender, "")
        Else
            Me.ErrorProviderForm5.SetError(sender, " debe ingresar la descripcion del producto, este dato es obligatorio")
        End If
    End Sub

    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        buscar()
        If busca > 0 Then
            actualizar()
        Else
            registrar()
        End If
    End Sub

    Private Sub btn_actualizarBarra_Click(sender As Object, e As EventArgs) Handles btn_actualizarBarra.Click
        buscar()
        If busca > 0 Then
            actualizar()
        Else
            MsgBox("El producto que desea actualizar no se encuentra registrado. Proceda a Registrarlo", vbInformation, "Mensaje")

        End If
    End Sub
End Class