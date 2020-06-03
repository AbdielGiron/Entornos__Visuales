Public Class Form2
    Private Sub txtLogin_Click(sender As Object, e As EventArgs) Handles txtLogin.Click
        If txtUsuario.Text = "Abdiel" And (txtContra.Text = "123") Then
            Me.Hide()
            Form3.Show()
        Else
            MsgBox("Error")
        End If
    End Sub

    Private Sub txtAbout_Click(sender As Object, e As EventArgs) Handles txtAbout.Click
        Me.Close()
    End Sub
End Class