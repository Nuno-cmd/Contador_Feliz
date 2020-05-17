Imports System.ComponentModel
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form3_MantenimientoUsuario

    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand
    Dim SqlCmd As New SqlCommand
    Dim bandera As String
    Dim cad_Preg As String
    Dim path As String
    Dim busca As Integer


    Private Sub Form3_Mantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            bandera = " la conexion"
            path = My.Computer.FileSystem.ReadAllText("C:\Users\Fauricio\Desktop\SISTEMAS\Programacion III\Lecciones\Proyectos\Contador_Final\My Project\Path1.txt")
            conexion.ConnectionString = "Data Source=LAPTOP-5FFLL852\SQLEXPRESS;Initial Catalog=" + path
            conexion.Open()
            limpiar()
            mostrar()
            seleccionarPregunta()

        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

        End Try
    End Sub

    Public Sub limpiar()
        cbx_pregunta.ResetText()
        cbx_pregunta.SelectedText = "Seleccionar"
        txt_usuario.Clear()
        txt_contrasena.Clear()
        txt_respuesta.Clear()
        txt_cedula.Clear()
        txt_nombre.Clear()
        txt_apellido1.Clear()
        txt_apellido2.Clear()
        txt_email.Clear()
        txt_telefono.Clear()
        txt_extension.Clear()
        txt_direccion.Clear()
        txt_repitaContrasena.Clear()
    End Sub

    Private Sub buscar()
        Dim dt As New DataTable
        Dim consulta As String = "SELECT * FROM Usuarios WHERE Cedula = '" & txt_cedula.Text & "'"
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
                MsgBox("El usuario digitado se encuentra registrado.", vbInformation, "Mensaje")
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
            Dim sql As String = "SELECT * FROM Usuarios"
            Dim SQLCmd As New SqlCommand(sql, conexion)

            bandera = " adaptador de SQL en llenado de DataGridView con clientes"
            Dim adaptador As New SqlDataAdapter(SQLCmd)
            Dim ds As New DataSet

            bandera = " llenado de adaptador DataGridView con los clientes"
            adaptador.Fill(ds, "Clientes")

            bandera = " verificación de existencia de tabla clientes"
            If ds.Tables.Count > 0 Then 'Busca que existan tablas del query..
                bandera = " llenado de DataGridView con los usuarios"
                DGV_Usuarios.DataSource = ds.Tables(0)
            End If

        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try
    End Sub
    Public Sub registrar()
        Try
            bandera = " selección de pregunta, debe elegir opción"
            cbx_pregunta.ValueMember = "Pregunta"
            cad_Preg = cbx_pregunta.SelectedValue.ToString

            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                bandera = " conexión"
                conexion.Open()
            End If

            If txt_cedula.Text = "" Then
                MsgBox("Debe ingresar el número de cédula, completar en etiqueta de Información Personal", vbInformation, "Mensaje")
            ElseIf txt_nombre.Text = "" Then
                MsgBox("Debe ingresar el nombre, completar en etiqueta de Información Personal", vbInformation, "Mensaje")
            ElseIf txt_apellido1.Text = "" Then
                MsgBox("Debe ingresar el primer apellido, completar en etiqueta de Información Personal", vbInformation, "Mensaje")
            ElseIf txt_apellido2.Text = "" Then
                MsgBox("Debe ingresar el segundo apellido, completar en etiqueta de Información Personal", vbInformation, "Mensaje")
            ElseIf txt_email.Text = "" Then
                MsgBox("Debe ingresar el email, completar en etiqueta de Información Personal", vbInformation, "Mensaje")
            ElseIf txt_telefono.Text = "" Then
                MsgBox("Debe ingresar el número de teléfono, completar en etiqueta de Información Personal", vbInformation, "Mensaje")
            ElseIf txt_direccion.Text = "" Then
                MsgBox("Debe ingresar la dirección, completar en etiqueta de Información Personal", vbInformation, "Mensaje")
            ElseIf txt_usuario.Text = "" Then
                MsgBox("Debe ingresar el usuario, completar en etiqueta de Seguridad", vbInformation, "Mensaje")
            ElseIf txt_respuesta.Text = "" Then
                MsgBox("Debe ingresar la respuesta, completar en etiqueta de Seguridad", vbInformation, "Mensaje")
            ElseIf txt_contrasena.Text = "" Then
                MsgBox("Debe ingresar la contraseña, completar en etiqueta de Seguridad", vbInformation, "Mensaje")
            ElseIf txt_repitaContrasena.Text = "" Then
                MsgBox("Debe verificar la contraseña, completar en etiqueta de Seguridad", vbInformation, "Mensaje")
            Else

                bandera = " registro de Datos del formulario en SQL Server"
                Dim strInsert As String = "Insert into Usuarios (Usuario, Contrasena, Pregunta, Respuesta, Cedula, Nombre, Apellido1, Apellido2, Email, Telefono, Ext, Direccion)" &
                    "Values ('" + txt_usuario.Text + "'," & "'" + txt_contrasena.Text + "'," & "'" & cad_Preg.ToString & "'," & "'" + txt_respuesta.Text + "'," & "'" + txt_cedula.Text + "'," & "'" + txt_nombre.Text + "'," & "'" + txt_apellido1.Text + "'," & "'" + txt_apellido2.Text + "'," & "'" + txt_email.Text + "'," & "'" + txt_telefono.Text + "'," & "'" + txt_extension.Text + "'," & "'" + txt_direccion.Text + "'" & ")"

                bandera = " SqlCommand de registrar datos en SQL Server"
                SqlCmd = New SqlCommand(strInsert, conexion)
                SqlCmd.ExecuteNonQuery()

                MsgBox("Usuario Registrado Exitosamente", vbInformation, "Mensaje")
                mostrar()
                limpiar()

            End If

        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

        End Try
        conexion.Close()

    End Sub

    Public Sub actualizar()

        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del usuario?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            Try
                bandera = " selección de pregunta, debe elegir opción"
                cbx_pregunta.ValueMember = "Pregunta"
                cad_Preg = cbx_pregunta.SelectedValue.ToString

                bandera = " verificación de apertura de la conexión"
                If conexion.State <> ConnectionState.Open Then
                    bandera = " conexión"
                    conexion.Open()
                End If

                If txt_cedula.Text = "" Then
                    MsgBox("Debe ingresar el número de cédula, completar en etiqueta de Información Personal", vbInformation, "Mensaje")
                ElseIf txt_nombre.Text = "" Then
                    MsgBox("Debe ingresar el nombre, completar en etiqueta de Información Personal", vbInformation, "Mensaje")
                ElseIf txt_apellido1.Text = "" Then
                    MsgBox("Debe ingresar el primer apellido, completar en etiqueta de Información Personal", vbInformation, "Mensaje")
                ElseIf txt_apellido2.Text = "" Then
                    MsgBox("Debe ingresar el segundo apellido, completar en etiqueta de Información Personal", vbInformation, "Mensaje")
                ElseIf txt_email.Text = "" Then
                    MsgBox("Debe ingresar el email, completar en etiqueta de Información Personal", vbInformation, "Mensaje")
                ElseIf txt_telefono.Text = "" Then
                    MsgBox("Debe ingresar el número de teléfono, completar en etiqueta de Información Personal", vbInformation, "Mensaje")
                ElseIf txt_direccion.Text = "" Then
                    MsgBox("Debe ingresar la dirección, completar en etiqueta de Información Personal", vbInformation, "Mensaje")
                ElseIf txt_usuario.Text = "" Then
                    MsgBox("Debe ingresar el usuario, completar en etiqueta de Seguridad", vbInformation, "Mensaje")
                ElseIf txt_respuesta.Text = "" Then
                    MsgBox("Debe ingresar la respuesta, completar en etiqueta de Seguridad", vbInformation, "Mensaje")
                ElseIf txt_contrasena.Text = "" Then
                    MsgBox("Debe ingresar la contraseña, completar en etiqueta de Seguridad", vbInformation, "Mensaje")
                ElseIf txt_repitaContrasena.Text = "" Then
                    MsgBox("Debe verificar la contraseña, completar en etiqueta de Seguridad", vbInformation, "Mensaje")
                Else
                    bandera = " registro de Datos del formulario en SQL Server"

                    Dim strInsert As String
                    strInsert = ""
                    strInsert &= "Update Usuarios set Usuario='" & txt_usuario.Text & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Usuarios set Contrasena='" & txt_contrasena.Text & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Usuarios set Pregunta='" & cad_Preg.ToString & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Usuarios set Respuesta='" & txt_respuesta.Text & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Usuarios set Nombre='" & txt_nombre.Text & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Usuarios set Apellido1='" & txt_apellido1.Text & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Usuarios set Apellido2='" & txt_apellido2.Text & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Usuarios set Email='" & txt_email.Text & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Usuarios set Telefono='" & txt_telefono.Text & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Usuarios set Ext='" & txt_extension.Text & "' where Cedula='" & txt_cedula.Text & "'"
                    strInsert &= "Update Usuarios set Direccion='" & txt_direccion.Text & "' where Cedula='" & txt_cedula.Text & "'"

                    bandera = " SqlCommand de registrar datos en SQL Server"
                    SqlCmd = New SqlCommand(strInsert, conexion)
                    SqlCmd.ExecuteNonQuery()

                    MsgBox("Usuario Modificado Exitosamente", vbInformation, "Mensaje")
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

        result = MessageBox.Show("Realmente desea eliminar el usuario?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            Try
                bandera = " verificación de apertura de la conexión"
                If conexion.State <> ConnectionState.Open Then
                    bandera = " conexión"
                    conexion.Open()
                End If

                Dim strInsert As String

                strInsert = ""
                strInsert &= "Delete from Usuarios where Cedula='" & txt_cedula.Text & "'"


                bandera = " SqlCommand de registrar datos en SQL Server"
                SqlCmd = New SqlCommand(strInsert, conexion)
                SqlCmd.ExecuteNonQuery()

                MsgBox("Usuario Eliminado Exitosamente", vbInformation, "Mensaje")
                mostrar()
                limpiar()

            Catch ex As Exception

                MsgBox("Error al procesar " & bandera, vbInformation, "Error")

            End Try
            conexion.Close()


        End If
    End Sub
    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_Restaurar_Click(sender As Object, e As EventArgs) Handles btn_restaurar.Click
        Me.WindowState = FormWindowState.Normal
        btn_restaurar.Visible = False
        btn_Maximizar.Visible = True
    End Sub

    Private Sub btn_Maximizar_Click(sender As Object, e As EventArgs) Handles btn_Maximizar.Click
        Me.WindowState = FormWindowState.Maximized
        btn_Maximizar.Visible = False
        btn_restaurar.Visible = True
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Application.Exit()
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Form2_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        buscar()
        If busca > 0 Then
            actualizar()
        Else
            registrar()
        End If

    End Sub

    Public Sub seleccionarPregunta()

        Try
            Dim sql As String

            bandera = " verificación de apertura de la conexión"
            If conexion.State <> ConnectionState.Open Then
                bandera = " conexión"
                conexion.Open()
            End If

            bandera = " query selección de las preguntas en base de datos SQL"
            sql = "SELECT * FROM Preguntas"
            Dim adaptador As SqlDataAdapter
            Dim dt As DataTable

            bandera = " adaptador de SQL en selección de las preguntas"
            adaptador = New SqlDataAdapter(sql, conexion)
            dt = New DataTable

            bandera = " llenado de preguntas en ComboBox"
            adaptador.Fill(dt)

            bandera = " display de Preguntas"
            cbx_pregunta.DataSource = dt
            cbx_pregunta.DisplayMember = "Pregunta"
            cbx_pregunta.ValueMember = "Pregunta"
            cbx_pregunta.ResetText()
            cbx_pregunta.SelectedText = "Seleccionar"


        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")

        End Try

    End Sub
    Private Sub btn_registrarUsuario_Click(sender As Object, e As EventArgs) Handles btn_registrarUsuario.Click

        buscar()
        If busca > 0 Then
            actualizar()
        Else
            registrar()
        End If

    End Sub

    Private Sub btn_mostrarUsuarios_Click(sender As Object, e As EventArgs) Handles btn_mostrarUsuarios.Click
        mostrar()
    End Sub

    Private Sub txt_cedula_TextChanged(sender As Object, e As EventArgs) Handles txt_cedula.TextChanged

    End Sub
    Private Sub txt_cedula_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_cedula.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm3.SetError(sender, "")
        Else
            Me.ErrorProviderForm3.SetError(sender, " debe ingresar el número de cédula, este dato es obligatorio")
        End If
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub

    Private Sub txt_nombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm3.SetError(sender, "")
        Else
            Me.ErrorProviderForm3.SetError(sender, " debe ingresar el nombre, este dato es obligatorio")
        End If
    End Sub

    Private Sub txt_apellido1_TextChanged(sender As Object, e As EventArgs) Handles txt_apellido1.TextChanged

    End Sub

    Private Sub txt_apellido1_Validating(sender As Object, e As CancelEventArgs) Handles txt_apellido1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm3.SetError(sender, "")
        Else
            Me.ErrorProviderForm3.SetError(sender, " debe ingresar el primer apellido, este dato es obligatorio")
        End If
    End Sub

    Private Sub txt_apellido2_TextChanged(sender As Object, e As EventArgs) Handles txt_apellido2.TextChanged

    End Sub

    Private Sub txt_apellido2_Validating(sender As Object, e As CancelEventArgs) Handles txt_apellido2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm3.SetError(sender, "")
        Else
            Me.ErrorProviderForm3.SetError(sender, " debe ingresar el segundo apellido, este dato es obligatorio")
        End If
    End Sub

    Private Sub txt_email_TextChanged(sender As Object, e As EventArgs) Handles txt_email.TextChanged

    End Sub

    Private Sub txt_email_Validating(sender As Object, e As CancelEventArgs) Handles txt_email.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm3.SetError(sender, "")
        Else
            Me.ErrorProviderForm3.SetError(sender, " debe ingresar el correo, este dato es obligatorio")
        End If
    End Sub

    Private Sub txt_telefono_TextChanged(sender As Object, e As EventArgs) Handles txt_telefono.TextChanged

    End Sub

    Private Sub txt_telefono_Validating(sender As Object, e As CancelEventArgs) Handles txt_telefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm3.SetError(sender, "")
        Else
            Me.ErrorProviderForm3.SetError(sender, " debe ingresar el número de teléfono, este dato es obligatorio")
        End If
    End Sub

    Private Sub txt_direccion_TextChanged(sender As Object, e As EventArgs) Handles txt_direccion.TextChanged

    End Sub

    Private Sub txt_direccion_Validating(sender As Object, e As CancelEventArgs) Handles txt_direccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm3.SetError(sender, "")
        Else
            Me.ErrorProviderForm3.SetError(sender, " debe ingresar la dirección, este dato es obligatorio")
        End If
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub

    Private Sub txt_usuario_Validating(sender As Object, e As CancelEventArgs) Handles txt_usuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm3.SetError(sender, "")
        Else
            Me.ErrorProviderForm3.SetError(sender, " debe ingresar el usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub cbx_pregunta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_pregunta.SelectedIndexChanged

    End Sub

    Private Sub txt_respuesta_TextChanged(sender As Object, e As EventArgs) Handles txt_respuesta.TextChanged

    End Sub

    Private Sub txt_respuesta_Validating(sender As Object, e As CancelEventArgs) Handles txt_respuesta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm3.SetError(sender, "")
        Else
            Me.ErrorProviderForm3.SetError(sender, " debe ingresar la respuesta a la pregunta, este dato es obligatorio")
        End If
    End Sub

    Private Sub txt_contrasena_TextChanged(sender As Object, e As EventArgs) Handles txt_contrasena.TextChanged

    End Sub

    Private Sub txt_contrasena_Validating(sender As Object, e As CancelEventArgs) Handles txt_contrasena.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm3.SetError(sender, "")
        Else
            Me.ErrorProviderForm3.SetError(sender, " debe ingresar la contraseña, este dato es obligatorio")
        End If
    End Sub

    Private Sub txt_repitaContrasena_TextChanged(sender As Object, e As EventArgs) Handles txt_repitaContrasena.TextChanged

    End Sub

    Private Sub txt_repitaContrasena_Validating(sender As Object, e As CancelEventArgs) Handles txt_repitaContrasena.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderForm3.SetError(sender, "")
        Else
            Me.ErrorProviderForm3.SetError(sender, " debe repetir la contraseña, este dato es obligatorio")
        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        limpiar()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        buscar()
        If busca > 0 Then
            actualizar()
        Else
            MsgBox("El usuario que desea actualizar no se encuentra registrado. Proceda a Registrarlo", vbInformation, "Mensaje")

        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        If txt_cedula.Text = "" Then
            MsgBox("Debe ingresar el número de cédula, en etiqueta de Información Personal", vbInformation, "Mensaje")
        Else
            buscar()
            If busca > 0 Then
                eliminar()
            Else
                MsgBox("El usuario que desea eliminar no se encuentra registrado.", vbInformation, "Mensaje")
            End If
        End If

    End Sub

    Private Sub btn_ActualizarBarra_Click(sender As Object, e As EventArgs) Handles btn_ActualizarBarra.Click
        buscar()
        If busca > 0 Then
            actualizar()
        Else
            MsgBox("El usuario que desea actualizar no se encuentra registrado. Proceda a Registrarlo", vbInformation, "Mensaje")

        End If
    End Sub
End Class