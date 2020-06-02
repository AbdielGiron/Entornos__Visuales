Public Class AcumuladorContador
    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Try
            Dim precio, total, totalpagar, orden As Integer
            orden = txtPedido.Text
            For i = 1 To orden Step 1
                precio = InputBox("Ingrese el precio del platillo No." & i, "Precio del Platillo")
                totalpagar += precio
            Next
            total = totalpagar / orden
            txtTotalPagar.Text = totalpagar
            txtTotalIndividual.Text = total
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtPedido.Clear()
        txtTotalPagar.Clear()
        txtTotalIndividual.Clear()
    End Sub

    Private Sub AcumuladorContador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
