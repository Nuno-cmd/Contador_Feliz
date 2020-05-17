Imports System.Data.SqlClient

Public Class Conexion

    Protected conexion As New SqlConnection
    Public bandera As String
    Public idusuario As Integer
    Protected path As String

    Protected Function conectar()
        Try
            bandera = " la conexion"
            path = My.Computer.FileSystem.ReadAllText("C:\Users\Fauricio\Desktop\SISTEMAS\Programacion III\Lecciones\Proyectos\Contador_Final\My Project\Path1.txt")

            conexion.ConnectionString = "Data Source=LAPTOP-5FFLL852\SQLEXPRESS;Initial Catalog=" + path
            conexion.Open()
            Return True
        Catch ex As Exception

            MsgBox("Error al procesar " & bandera, vbInformation, "Error")
            Return False
        End Try
    End Function


End Class
