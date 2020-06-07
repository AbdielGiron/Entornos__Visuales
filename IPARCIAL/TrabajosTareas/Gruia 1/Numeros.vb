Public Class Numeros
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim numero, suma As Double
        Dim total, positivos, negativos, pares, impares As Integer

        numero = InputBox("Ingrese el numero:", "INGRESAR", vbInformation)
        cmbIngresados.Items.Add(numero)

        total = Val(txtTotal.Text)
        suma = Val(txtSuma.Text)
        positivos = Val(txtPositivos.Text)
        negativos = Val(txtNegativos.Text)
        pares = Val(txtPares.Text)
        impares = Val(txtImpares.Text)

        suma += numero
        txtSuma.Text = suma

        total += 1
        txtTotal.Text = total

        If numero > 0 Then
            positivos += 1
            txtPositivos.Text = positivos
        Else
            negativos += 1
            txtNegativos.Text = negativos
        End If

        If (numero Mod 2) = 0 Then
            pares += 1
            txtPares.Text = pares
        Else
            impares += 1
            txtImpares.Text = impares
        End If

    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class