Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Form8_DocumentosEmitidos

    Dim SQLCmd As New SqlCommand
    Dim conexion As New SqlConnection
    Dim bandera As String
    Dim path As String
    Dim busca As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            bandera = " la conexion"
            path = My.Computer.FileSystem.ReadAllText("C:\Users\Fauricio\Desktop\SISTEMAS\Programacion III\Lecciones\Proyectos\Contador_Final\My Project\Path1.txt")
            conexion.ConnectionString = "Data Source=LAPTOP-5FFLL852\SQLEXPRESS;Initial Catalog=" + path
            conexion.Open()
            mostrar()

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

            bandera = " query selección de documentos en base de datos SQL"
            Dim sql As String = "SELECT * FROM Documentos"
            Dim SQLCmd As New SqlCommand(sql, conexion)

            bandera = " adaptador de SQL en llenado de DataGridView con documentos"
            Dim adaptador As New SqlDataAdapter(SQLCmd)
            Dim ds As New DataSet

            bandera = " llenado de adaptador DataGridView con los documentos"
            adaptador.Fill(ds, "Documentos")

            bandera = " verificación de existencia de tabla documentos"
            If ds.Tables.Count > 0 Then 'Busca que existan tablas del query..
                bandera = " llenado de DataGridView con los documentos"
                DGV_Documentos.DataSource = ds.Tables(0)
            End If

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

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        mostrar()
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        mostrar()
    End Sub
End Class