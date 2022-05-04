Imports Bunifu.UI.WinForms

Public Class login

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click

        Dim contraseña As String
        contraseña = TextBox1.Text

        If (contraseña = "Admin@777") Then
            Form1.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


End Class