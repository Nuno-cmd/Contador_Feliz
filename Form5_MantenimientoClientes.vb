Imports System.Data.Sql
Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Form5_MantenimientoClientes

    Dim SQLCmd As New SqlCommand
    Dim conexion As New SqlConnection
    Dim cad_Provincia As String
    Dim cad_Canton As String
    Dim cad_Distrito As String
    Dim cad_tipoID, cad_Ar As String
    Dim bandera As String
    Dim path As String
    Dim busca As Integer

    Public Sub Form5_MantenimientoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Proceso que llena el Combobox Provincia
        Try

            bandera = " la conexion"
            path = My.Computer.FileSystem.ReadAllText("C:\Users\Fauricio\Desktop\SISTEMAS\Programacion III\Lecciones\Proyectos\Contador_Final\My Project\Path1.txt")
            conexion.ConnectionString = "Data Source=LAPTOP-5FFLL852\SQLEXPRESS;Initial Catalog=" + path
            conexion.Open()
            limpiar()
            mostrar()

            bandera = " tipo de identificacion"
            seleccionarIdentificacion()
            bandera = " selección de país"
            seleccionarPais()

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

    Public Sub limpiar()
        cbx_Provincia.ResetText()
        cbx_Provincia.SelectedText = "Seleccionar"
        cbx_pais.ResetText()
        cbx_pais.SelectedText = "Seleccionar"
        cbx_tipoID.ResetText()
        cbx_tipoID.SelectedText = "Seleccionar"
        cbx_Canton.ResetText()
        cbx_Canton.SelectedText = "Seleccionar"
        cbx_Distrito.ResetText()
        cbx_Distrito.SelectedText = "Seleccionar"
        txt_cedula.Clear()
        txt_nombre.Clear()
        txt_apellido1.Clear()
        txt_apellido2.Clear()
        txt_email.Clear()
        txt_telefono.Clear()
        txt_direccion.Clear()
    End Sub

    Private Sub buscar()
        Dim dt As New DataTable
        Dim consulta As String = "SELECT * FROM Clientes WHERE Cedula = '" & txt_cedula.Text & "'"
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
                MsgBox("El cliente digitado se encuentra registrado.", vbInformation, "Mensaje")
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

            bandera = " query selección de clientes en base de datos SQL"
            Dim sql As String = "SELECT * FROM Clientes"
            Dim SQLCmd As New SqlCommand(sql, conexion)

            bandera = " adaptador de SQL en llenado de DataGridView con clientes"
            Dim adaptador As New SqlDataAdapter(SQLCmd)
            Dim ds As New DataSet

            bandera = " llenado de adaptador DataGridView con los clientes"
            adaptador.Fill(ds, "Clientes")

            bandera = " verificación de existencia de tabla clientes"
            If ds.Tables.Count > 0 Then 'Busca que existan tablas del query..
                bandera = " llenado de DataGridView con los clientes"
                DGV_Clientes.DataSource = ds.Tables(0)
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

            bandera = " selección Tipo de Identificación, debe elegir opción"
            cbx_tipoID.ValueMember = "Tipo_Identificacion"
            cad_tipoID = cbx_tipoID.SelectedValue.ToString

            bandera = " selección de Área/País, debe elegir opción"
            cbx_pais.ValueMember = "PaisNombre"
            cad_Ar = cbx_pais.SelectedValue.ToString

            bandera = " selección de Provincia, debe elegir opción, aplica sólo para Costa Rica"
            cad_Provincia = cbx_Provincia.SelectedValue.ToString

            bandera = " selección de Cantón, debe elegir opción, aplica sólo para Costa Rica"
            cbx_Canton.ValueMember = "nombreCanton"
            cad_Canton = cbx_Canton.SelectedValue.ToString

            bandera = " selección de Distrito, debe elegir opción, aplica sólo para Costa Rica"
            cad_Distrito = cbx_Distrito.SelectedValue.ToString
            bandera = " registro de Datos del formulario en SQL Server"

            If txt_cedula.Text = "" Then
                MsgBox("Debe ingresar el número de cédula ó identificación", vbInformation, "Mensaje")

            ElseIf txt_nombre.Text = "" Then
                MsgBox("Debe ingresar el nombre", vbInformation, "Mensaje")

            ElseIf txt_apellido1.Text = "" Then
                MsgBox("Debe ingresar el primer apellido", vbInformation, "Mensaje")
            ElseIf txt_apellido2.Text = "" Then
                MsgBox("Debe ingresar el segundo apellido", vbInformation, "Mensaje")

            Else

                Dim strInsert As String = "Insert into Clientes (Tipo_Cedula, Cedula, Nombre, Apellido1, Apellido2, Email, Area, Telefono, Provincia, Canton, Distrito, Direccion)" &
                        "Values ('" & cad_tipoID.ToString & "'," & "'" + txt_cedula.Text + "'," & "'" + txt_nombre.Text + "'," & "'" + txt_apellido1.Text + "'," & "'" + txt_apellido2.Text + "'," & "'" + txt_email.Text + "'," & "'" & cad_Ar.ToString & "'," & "'" + txt_telefono.Text + "'," & "'" & cad_Provincia.ToString & "'," & "'" & cad_Canton.ToString & "'," & "'" & cad_Distrito.ToString & "'," & "'" + txt_direccion.Text + "'" & ")"

                bandera = " SqlCommand de registrar datos en SQL Server"
                SQLCmd = New SqlCommand(strInsert, conexion)
                SQLCmd.ExecuteNonQuery()

                MsgBox("Cliente Registrado Exitosamente", vbInformation, "Mensaje")
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

        result = MessageBox.Show("Realmente desea editar los datos del usuario?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            Try

                bandera = " verificación de apertura de la conexión"
                If conexion.State <> ConnectionState.Open Then
                    bandera = " conexión"
                    conexion.Open()
                End If
                bandera = " selección Tipo de Identificación, debe elegir opción"
                cbx_tipoID.ValueMember = "Tipo_Identificacion"
                cad_tipoID = cbx_tipoID.SelectedValue.ToString

                bandera = " selección de Área/País, debe elegir opción"
                cbx_pais.ValueMember = "PaisNombre"
                cad_Ar = cbx_pais.SelectedValue.ToString

                bandera = " selección de Provincia, debe elegir opción, aplica sólo para Costa Rica"
                cad_Provincia = cbx_Provincia.SelectedValue.ToString

                bandera = " selección de Cantón, debe elegir opción, aplica sólo para Costa Rica"
                cbx_Canton.ValueMember = "nombreCanton"
                cad_Canton = cbx_Canton.SelectedValue.ToString

                bandera = " selección de Distrito, debe elegir opción, aplica sólo para Costa Rica"
                cad_Distrito = cbx_Distrito.SelectedValue.ToString
                bandera = " registro de Datos del formulario en SQL Server"

                If txt_cedula.Text = "" Then
                    MsgBox("Debe ingresar el número de cédula ó identificación", vbInformation, "Mensaje")

                ElseIf txt_nombre.Text = "" Then
                    MsgBox("Debe ingresar el nombre", vbInformation, "Mensaje")

                ElseIf txt_apellido1.Text = "" Then
                    MsgBox("Debe ingresar el primer apellido", vbInformation, "Mensaje")
                ElseIf txt_apellido2.Text = "" Then
                    MsgBox("Debe ingresar el segundo apellido", vbInformation, "Mensaje")

                Else
                    bandera = " registro de Datos del formulario en SQL Server"

                    Dim strInsert As String
                    strInsert = ""
                    strInsert &= "Update Clientes set Tipo_Cedula='" & cad_tipoID.ToString & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Clientes set Nombre='" & txt_nombre.Text & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Clientes set Apellido1='" & txt_apellido1.Text & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Clientes set Apellido2='" & txt_apellido2.Text & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Clientes set Email='" & txt_email.Text & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Clientes set Area='" & cad_Ar.ToString & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Clientes set Telefono='" & txt_telefono.Text & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Clientes set Provincia='" & cad_Provincia.ToString & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Clientes set Canton='" & cad_Canton.ToString & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Clientes set Distrito='" & cad_Distrito.ToString & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Clientes set Direccion='" & txt_direccion.Text & "' where Cedula='" & txt_cedula.Text & "'"

                    bandera = " SqlCommand de registrar datos en SQL Server"
                    SQLCmd = New SqlCommand(strInsert, conexion)
                    SQLCmd.ExecuteNonQuery()

                    MsgBox("Cliente Modificado Exitosamente", vbInformation, "Mensaje")
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

        result = MessageBox.Show("Realmente desea eliminar el cliente?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            Try
                bandera = " verificación de apertura de la conexión"
                If conexion.State <> ConnectionState.Open Then
                    bandera = " conexión"
                    conexion.Open()
                End If

                Dim strInsert As String

                strInsert = ""
                strInsert &= "Delete from Clientes where Cedula='" & txt_cedula.Text & "'"


                bandera = " SqlCommand de registrar datos en SQL Server"
                SQLCmd = New SqlCommand(strInsert, conexion)
                SQLCmd.ExecuteNonQuery()

                MsgBox("Cliente Eliminado Exitosamente", vbInformation, "Mensaje")
                mostrar()
                limpiar()

            Catch ex As Exception

                MsgBox("Error al procesar " & bandera, vbInformation, "Error")

            End Try
            conexion.Close()


        End If
    End Sub
    Public Sub seleccionarPais()

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
    Public Sub seleccionarIdentificacion()

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
    Public Sub cbx_tipoID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tipoID.SelectedIndexChanged
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

    Public Sub cbx_pais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_pais.SelectedIndexChanged
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
    Public Sub cbx_Provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Provincia.SelectedIndexChanged
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

    Public Sub cbx_Canton_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Canton.SelectedIndexChanged
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

    Private Sub btn_registrarCliente_Click(sender As Object, e As EventArgs) Handles btn_registrarCliente.Click
        buscar()
        If busca > 0 Then
            actualizar()
        Else
            registrar()
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
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
                        txt_nombre.Text = dr.Item("Nombre").ToString

                        bandera = " recuperación de apellidos"
                        If cbx_tipoID.SelectedValue < 2 Then
                            txt_apellido1.Text = dr.Item("Apellido1").ToString
                            txt_apellido2.Text = dr.Item("Apellido2").ToString
                        End If
                        txt_email.Text = dr.Item("Email").ToString
                        txt_telefono.Text = dr.Item("Telefono").ToString
                        cbx_pais.SelectedValue = dr.Item("Area").ToString
                        txt_direccion.Text = dr.Item("Direccion").ToString

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

    Private Sub txt_cedula_TextChanged(sender As Object, e As EventArgs) Handles txt_cedula.TextChanged

    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        limpiar()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        buscar()
        If busca > 0 Then
            actualizar()
        Else
            MsgBox("El cliente que desea actualizar no se encuentra registrado. Proceda a Registrarlo", vbInformation, "Mensaje")

        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If txt_cedula.Text = "" Then
            MsgBox("Debe ingresar el número de cédula del cliente", vbInformation, "Mensaje")
        Else
            buscar()
            If busca > 0 Then
                eliminar()
            Else
                MsgBox("El cliente que desea eliminar no se encuentra registrado.", vbInformation, "Mensaje")
            End If
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

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub

    Private Sub txt_cedula_Validating(sender As Object, e As CancelEventArgs) Handles txt_cedula.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm5.SetError(sender, "")
        Else
            Me.ErrorProviderForm5.SetError(sender, " debe ingresar el número de cédula o identificación, este dato es obligatorio")
        End If
    End Sub

    Private Sub txt_apellido1_TextChanged(sender As Object, e As EventArgs) Handles txt_apellido1.TextChanged

    End Sub

    Private Sub txt_nombre_Validating(sender As Object, e As CancelEventArgs) Handles txt_nombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm5.SetError(sender, "")
        Else
            Me.ErrorProviderForm5.SetError(sender, " debe ingresar el nombre, este dato es obligatorio")
        End If
    End Sub

    Private Sub txt_apellido2_TextChanged(sender As Object, e As EventArgs) Handles txt_apellido2.TextChanged

    End Sub

    Private Sub txt_apellido1_Validating(sender As Object, e As CancelEventArgs) Handles txt_apellido1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm5.SetError(sender, "")
        Else
            Me.ErrorProviderForm5.SetError(sender, " debe ingresar el primer apellido, este dato es obligatorio")
        End If
    End Sub

    Private Sub btn_actualizarBarra_Click(sender As Object, e As EventArgs) Handles btn_actualizarBarra.Click
        buscar()
        If busca > 0 Then
            actualizar()
        Else
            MsgBox("El cliente que desea actualizar no se encuentra registrado. Proceda a Registrarlo", vbInformation, "Mensaje")

        End If
    End Sub

    Private Sub txt_apellido2_Validating(sender As Object, e As CancelEventArgs) Handles txt_apellido2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm5.SetError(sender, "")
        Else
            Me.ErrorProviderForm5.SetError(sender, " debe ingresar el segundo apellido, este dato es obligatorio")
        End If
    End Sub
End Class