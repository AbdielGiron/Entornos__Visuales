Public Class Form3
    Dim cantidad, precio As Integer
    Dim subtotal, ISV, total As Double

    Private Sub btnMas1_Click(sender As Object, e As EventArgs) Handles btnMas1.Click
        cantidad = Val(txt1.Text)
        cantidad += 1
        txt1.Text = cantidad
    End Sub

    Private Sub btnMas2_Click(sender As Object, e As EventArgs) Handles btnMas2.Click
        cantidad = Val(txt2.Text)
        cantidad += 1
        txt2.Text = cantidad
    End Sub

    Private Sub btnMas3_Click(sender As Object, e As EventArgs) Handles btnMas3.Click
        cantidad = Val(txt3.Text)
        cantidad += 1
        txt3.Text = cantidad
    End Sub

    Private Sub btnMas4_Click(sender As Object, e As EventArgs) Handles btnMas4.Click
        cantidad = Val(txt4.Text)
        cantidad += 1
        txt4.Text = cantidad
    End Sub

    Private Sub btnMas5_Click(sender As Object, e As EventArgs) Handles btnMas5.Click
        cantidad = Val(txt5.Text)
        cantidad += 1
        txt5.Text = cantidad
    End Sub

    Private Sub btnMenos1_Click(sender As Object, e As EventArgs) Handles btnMenos1.Click
        If cantidad > 1 Then
            cantidad = Val(txt1.Text)
            cantidad -= 1
            txt1.Text = cantidad
        End If
    End Sub

    Private Sub btnMenos2_Click(sender As Object, e As EventArgs) Handles btnMenos2.Click
        If cantidad > 1 Then
            cantidad = Val(txt2.Text)
            cantidad -= 1
            txt2.Text = cantidad
        End If
    End Sub

    Private Sub btnMenos3_Click(sender As Object, e As EventArgs) Handles btnMenos3.Click
        If cantidad > 1 Then
            cantidad = Val(txt3.Text)
            cantidad -= 1
            txt3.Text = cantidad
        End If
    End Sub

    Private Sub btnMenos4_Click(sender As Object, e As EventArgs) Handles btnMenos4.Click
        If cantidad > 1 Then
            cantidad = Val(txt4.Text)
            cantidad -= 1
            txt4.Text = cantidad
        End If
    End Sub

    Private Sub btnMenos5_Click(sender As Object, e As EventArgs) Handles btnMenos5.Click
        If cantidad > 1 Then
            cantidad = Val(txt5.Text)
            cantidad -= 1
            txt5.Text = cantidad
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btnNuevo.Enabled = True

        LabelTitulo.Text = "4 ESTACIONES"
        cantidad = Val(txt1.Text)
        precio = 318.0
        subtotal = cantidad * precio
        ISV = subtotal * 0.15
        total = subtotal + ISV
        txtCantidad.Text = cantidad
        txtPrecio.Text = precio
        txtSubTotal.Text = subtotal
        txtISV.Text = ISV
        txtTotal.Text = total

        cmbVentas.Items.Add(txtCantidad.Text & " " & "'" & LabelTitulo.Text & "'")
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        btn1.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btnNuevo.Enabled = True

        LabelTitulo.Text = "SUPER SUPREMA"
        cantidad = Val(txt2.Text)
        precio = 280.0
        subtotal = cantidad * precio
        ISV = subtotal * 0.15
        total = subtotal + ISV
        txtCantidad.Text = cantidad
        txtPrecio.Text = precio
        txtSubTotal.Text = subtotal
        txtISV.Text = ISV
        txtTotal.Text = total

        cmbVentas.Items.Add(txtCantidad.Text & " " & "'" & LabelTitulo.Text & "'")
    End Sub


    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        btn1.Enabled = False
        btn2.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btnNuevo.Enabled = True

        LabelTitulo.Text = "CANADIENSE"
        cantidad = Val(txt3.Text)
        precio = 280.0
        subtotal = cantidad * precio
        ISV = subtotal * 0.15
        total = subtotal + ISV
        txtCantidad.Text = cantidad
        txtPrecio.Text = precio
        txtSubTotal.Text = subtotal
        txtISV.Text = ISV
        txtTotal.Text = total

        cmbVentas.Items.Add(txtCantidad.Text & " " & "'" & LabelTitulo.Text & "'")
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn5.Enabled = False
        btnNuevo.Enabled = True

        LabelTitulo.Text = "SUPREMA"
        cantidad = Val(txt4.Text)
        precio = 250.0
        subtotal = cantidad * precio
        ISV = subtotal * 0.15
        total = subtotal + ISV
        txtCantidad.Text = cantidad
        txtPrecio.Text = precio
        txtSubTotal.Text = subtotal
        txtISV.Text = ISV
        txtTotal.Text = total

        cmbVentas.Items.Add(txtCantidad.Text & " " & "'" & LabelTitulo.Text & "'")
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btnNuevo.Enabled = True

        LabelTitulo.Text = "PEPERONI O JAMON LOVERS"
        cantidad = Val(txt5.Text)
        precio = 250.0
        subtotal = cantidad * precio
        ISV = subtotal * 0.15
        total = subtotal + ISV
        txtCantidad.Text = cantidad
        txtPrecio.Text = precio
        txtSubTotal.Text = subtotal
        txtISV.Text = ISV
        txtTotal.Text = total

        cmbVentas.Items.Add(txtCantidad.Text & " " & "'" & LabelTitulo.Text & "'")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txt1.Text = 1
        txt2.Text = 1
        txt3.Text = 1
        txt4.Text = 1
        txt5.Text = 1
        LabelTitulo.Text = " "
        txtCantidad.Clear()
        txtPrecio.Clear()
        txtSubTotal.Clear()
        txtISV.Clear()
        txtTotal.Clear()
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class