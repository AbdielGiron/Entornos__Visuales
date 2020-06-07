Public Class EcuacionCuadratica
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim a, b, c, x1, x2 As Double

        If txtA.Text = "" Or txtB.Text = "" Or txtC.Text = "" Then
            MsgBox("llene todos los espacios(A,B,C)", "INGRESO DE DATOS", vbCritical)
        End If
        If txtA.Text = "0" Then
            MsgBox("A debe de ser distinto de O", "INGRESO DE DATOS", vbCritical)
        End If

        a = txtA.Text
        b = txtB.Text
        c = txtC.Text

        If b < (4 * (a * c)) Then
            MsgBox("No es posible realizar la operacion", "INGRESO DE DATOS",)
        Else
            x1 = ((b * (-1)) + (((b ^ 2) - (4 * (a * c))) ^ (1 / 2))) / (2 * a)
            x2 = ((b * (-1)) - (((b ^ 2) - (4 * (a * c))) ^ (1 / 2))) / (2 * a)

            txtX1.Text = x1
            txtX2.Text = x2
        End If


    End Sub

    Private Sub brnBorrar_Click(sender As Object, e As EventArgs) Handles brnBorrar.Click
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        txtX1.Clear()
        txtX2.Clear()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class