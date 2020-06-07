Public Class Numeros
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim numero As Double
        Dim total As Integer

        numero = InputBox("Ingrese el numero:", "INGRESAR", vbInformation)
        cmbIngresados.Items.Add(numero)
        txtTotal.Text = total + 1

    End Sub
End Class