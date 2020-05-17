Public Class Form7_FacturaElectronica
    Private Sub btn_Restaurar_Click(sender As Object, e As EventArgs) Handles btn_Restaurar.Click
        Me.WindowState = FormWindowState.Normal
        btn_Restaurar.Visible = False
        btn_Maximizar.Visible = True
    End Sub

    Private Sub btn_Maximizar_Click(sender As Object, e As EventArgs) Handles btn_Maximizar.Click
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
End Class