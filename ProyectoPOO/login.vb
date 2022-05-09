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

    Private Sub BunifuCheckBox1_CheckedChanged(sender As Object, e As BunifuCheckBox.CheckedChangedEventArgs) Handles BunifuCheckBox1.CheckedChanged

        If e.CheckState = BunifuCheckBox.CheckStates.Checked Then

            TextBox1.PasswordChar = "*"

        ElseIf e.CheckState = BunifuCheckBox.CheckStates.Unchecked Then

            TextBox1.PasswordChar = ""

        End If

    End Sub

    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub BunifuPictureBox3_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class