Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form1_RecContrasena
    Dim conexion As New SqlConnection
    Dim enunciado As SqlCommand
    Dim resp As SqlDataReader
    Dim bandera As String
    Dim path As String
    Private Sub btn_solicitaPregunta_Click(sender As Object, e As EventArgs) Handles btn_solicitaPregunta.Click

        Dim dt As New DataTable
        Dim consulta As String = "SELECT * FROM USUARIOS WHERE Usuario = '" & txt_usuario.Text & "'"
        Dim comando As New SqlCommand(consulta, conexion)
        Dim dr As SqlDataReader

        Try
            bandera = " conexión"
            path = My.Computer.FileSystem.ReadAllText("C:\Users\Fauricio\Desktop\SISTEMAS\Programacion III\Lecciones\Proyectos\Contador_Final\My Project\Path1.txt")
            conexion.ConnectionString = "Data Source=LAPTOP-5FFLL852\SQLEXPRESS;Initial Catalog=" + path
            conexion.Open()
            Try
                bandera = " DataReader"
                dr = comando.ExecuteReader

                bandera = " verificación de usuario registrado"
                If txt_usuario.Text = "" Then
                    MsgBox("Debe ingresar el usuario", vbInformation, "Mensaje")
                    conexion.Close()

                Else
                    If dr.Read() Then
                        bandera = " recuperación de Pregunta"
                        txt_Pregunta.Text = dr.Item("Pregunta").ToString
                        txt_respuesta.Enabled = True
                        btn_verificaRespuesta.Enabled = True
                    Else
                        MsgBox("El usuario digitado no se encuentra registrado")
                        txt_usuario.Clear()
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
    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            bandera = " verificación de usuario en base de datos"
            enunciado = New SqlCommand("Select * from Usuarios where Usuario='" & nombreUsuario & "'", conexion)
                    resp = enunciado.ExecuteReader

            If resp.Read Then
                resultado = True
            End If
            resp.Close()
        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try
        Return resultado
    End Function
    Function respuestaPregunta(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            bandera = " lectura de contraseña de usuario registrado"
            enunciado = New SqlCommand("Select Respuesta from Usuarios where Usuario='" & nombreUsuario & "'", conexion)
            resp = enunciado.ExecuteReader

            If resp.Read Then
                resultado = resp.Item("Respuesta")
            End If
            resp.Close()
        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try
        Return resultado
    End Function
    Private Sub btn_verificaRespuesta_Click(sender As Object, e As EventArgs) Handles btn_verificaRespuesta.Click
        Try
            bandera = " conexión"

            path = My.Computer.FileSystem.ReadAllText("C:\Users\Fauricio\Desktop\SISTEMAS\Programacion III\Lecciones\Proyectos\Contador_Final\My Project\Path1.txt")
            conexion = New SqlConnection("Data Source=LAPTOP-5FFLL852\SQLEXPRESS;Initial Catalog=" + path)

            conexion.Open()

            bandera = " verificación de contraseña de usuario registrado"
            Try
                If usuarioRegistrado(txt_usuario.Text) = True Then
                    Dim contra As String = respuestaPregunta(txt_usuario.Text)
                    If contra.Equals(txt_respuesta.Text) = True Then
                        Form2_Menu.Show()
                        Me.Hide()
                    Else
                        MsgBox("Respuesta Invalida", MsgBoxStyle.Critical, "Error")
                        txt_respuesta.Clear()
                    End If
                Else
                    MsgBox("El Usuario: " + txt_usuario.Text + " no se encuentra registrado")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Catch ex As Exception
            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
        End Try
        conexion.Close()
    End Sub
    Private Sub pcbx_logout_Click(sender As Object, e As EventArgs) Handles pcbx_logout.Click
        Application.Exit()
    End Sub
End Class