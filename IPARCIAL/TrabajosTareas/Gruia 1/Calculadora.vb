Public Class Calculadora
    Dim operacion As Integer
    Dim dato1, dato2, resultado As Double

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtPantalla.Text = txtPantalla.Text & "1"
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtPantalla.Text = txtPantalla.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtPantalla.Text = txtPantalla.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtPantalla.Text = txtPantalla.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtPantalla.Text = txtPantalla.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtPantalla.Text = txtPantalla.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtPantalla.Text = txtPantalla.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtPantalla.Text = txtPantalla.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtPantalla.Text = txtPantalla.Text & "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtPantalla.Text = txtPantalla.Text & "0"
    End Sub

    Private Sub btn00_Click(sender As Object, e As EventArgs) Handles btn00.Click
        txtPantalla.Text = txtPantalla.Text & "00"
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        Try
            If txtPantalla.Text.IndexOf(".") > 0 Then
                Beep()
            ElseIf txtPantalla.Text <> "." Then
                txtPantalla.Text = txtPantalla.Text & "."
            Else
                txtPantalla.Text = "0."
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        operacion = 1
        dato1 = Val(txtPantalla.Text)
        txtPantalla.Clear()
        txtOperacion.Text = dato1 & " + "
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        operacion = 2
        dato1 = Val(txtPantalla.Text)
        txtPantalla.Clear()
        txtOperacion.Text = dato1 & " - "
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        operacion = 3
        dato1 = Val(txtPantalla.Text)
        txtPantalla.Clear()
        txtOperacion.Text = dato1 & " × "
    End Sub

    Private Sub btnDivicion_Click(sender As Object, e As EventArgs) Handles btnDivicion.Click
        operacion = 4
        dato1 = Val(txtPantalla.Text)
        txtPantalla.Clear()
        txtOperacion.Text = dato1 & " ÷ "
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        dato2 = Val(txtPantalla.Text)
        txtOperacion.Text = txtOperacion.Text & dato2

        Select Case operacion
            Case 1
                resultado = dato1 + dato2
            Case 2
                resultado = dato1 - dato2
            Case 3
                resultado = dato1 * dato2
            Case 4
                resultado = dato1 / dato2
        End Select
        txtPantalla.Text = resultado

        cmbHistory.Items.Add(txtOperacion.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOperacion.Clear()
        txtPantalla.Clear()
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class