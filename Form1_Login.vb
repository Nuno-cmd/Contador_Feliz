Imports System.ComponentModel
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Form1_Login

    Dim conexion As SqlConnection
    Dim enunciado As SqlCommand
    Dim respuesta As SqlDataReader
    Dim bandera As String
    Dim path As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            bandera = " verificación de usuario en base de datos"
            enunciado = New SqlCommand("Select * from Usuarios where Usuario='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Mensaje de error")
        End Try
        Return resultado
    End Function
    Function contrasena(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            bandera = " lectura de contraseña de usuario registrado"
            enunciado = New SqlCommand("Select Contrasena from Usuarios where Usuario='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("Contrasena")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Mensaje de error")
        End Try
        Return resultado
    End Function

    Dim cont As Integer = 0
    Dim cantidad As Integer = 3

    Private Sub btn_Ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click

        Try
            bandera = " conexión"
            path = My.Computer.FileSystem.ReadAllText("C:\Users\Fauricio\Desktop\SISTEMAS\Programacion III\Lecciones\Proyectos\Contador_Final\My Project\Path1.txt")
            conexion = New SqlConnection("Data Source=LAPTOP-5FFLL852\SQLEXPRESS;Initial Catalog=" + path)
            conexion.Open()

            bandera = " verificación de contraseña de usuario registrado"

            If txt_usuario.Text = "" Then

                MsgBox("Debe ingresar el usuario", vbInformation, "Mensaje")

            ElseIf txt_contrasena.Text = "" Then

                MsgBox("Debe ingresar la contraseña", vbInformation, "Mensaje")

            Else

                Dim contra As String = contrasena(txt_usuario.Text)

                If usuarioRegistrado(txt_usuario.Text) = True And contra.Equals(txt_contrasena.Text) = True Then

                    cont = 0
                    txt_usuario.Clear()
                    txt_contrasena.Clear()
                    Me.Hide()
                    Form2_Menu.Show()

                Else

                    cont += 1

                    If cont > 2 Then
                        MsgBox(" Ha fallado 3 veces al ingresar el usuario ó contraseña. 

                    Salida de la aplicación", vbCritical, "Mensaje de error")
                        Application.[Exit]()

                    ElseIf cont > 1 Then

                        MsgBox("Usuario y/o Contraseña son Incorrectos.

                    Te queda " + (cantidad - cont).ToString() + " intento.", vbInformation, "Mensaje")
                        txt_usuario.Clear()
                        txt_contrasena.Clear()

                    Else
                        MsgBox("Usuario y/o Contraseña son Incorrectos.

                    Te quedan " + (cantidad - cont).ToString() + " intentos.", vbInformation, "Mensaje")
                        txt_usuario.Clear()
                        txt_contrasena.Clear()

                    End If

                End If

            End If

        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Mensaje de error")

        End Try

        conexion.Close()

    End Sub

    Private Sub btn_olvido_Click(sender As Object, e As EventArgs) Handles btn_olvido.Click
        Try
            bandera = " mostrar formulario de recuperación de contraseña"
            Form1_RecContrasena.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Mensaje de error")
        End Try

    End Sub
    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub

    Private Sub txt_usuario_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_usuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderLogin.SetError(sender, "")
        Else
            Me.ErrorProviderLogin.SetError(sender, " ingrese el usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub txt_contrasena_TextChanged(sender As Object, e As EventArgs) Handles txt_contrasena.TextChanged

    End Sub

    Private Sub txt_contrasena_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_contrasena.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProviderLogin.SetError(sender, "")
        Else
            Me.ErrorProviderLogin.SetError(sender, " ingrese la contraseña, este dato es obligatorio")
        End If
    End Sub

    Private Sub pcbx_logout_Click(sender As Object, e As EventArgs) Handles pcbx_logout.Click
        Application.Exit()
    End Sub
End Class