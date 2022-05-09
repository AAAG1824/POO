Public Class MenuFactura
    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox1.Click
        Me.Close()
        login.Close()
    End Sub

    Private Sub BunifuPictureBox3_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) 
        Form2.Show()
    End Sub
End Class
