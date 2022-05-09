Public Class MenuProveedores
    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox1.Click
        Me.Close()
        login.Close()
    End Sub

    Private Sub BunifuPictureBox3_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MenuVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        MenuVentas.Show()
        Me.Close()
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        MenuPersonas.Show()
        Me.Close()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        MenuInventario.Show()
        Me.Close()
    End Sub
End Class
