Public Class Form1

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim cantidad, ISVporciento As Integer
        Dim precio, subtotal, descuento, ISV, total As Double

        'encender la opcion de nuevo
        btnNuevo.Enabled = True

        'verifica que las casillas no esten vacias
        If txtPrecio.Text = "" Or txtCantidad.Text = "" Then
            MsgBox("Es necesario llenar ambas casillas", vbInformation)

            'verifica que los datos sean numericos
        ElseIf Not IsNumeric(txtPrecio.Text) Or Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Es necesario que ambos datos sean numericos", vbInformation)
            txtCantidad.Text = ""
            txtPrecio.Text = ""

            'realiza los calculos
        Else
            Precio = Val(txtPrecio.Text)
            cantidad = Val(txtCantidad.Text)
            subtotal = Val(txtSubtotal.Text)
            ISVporciento = Val(txtListaISV.Text)

            'calcal el subtotal
            subtotal = precio * cantidad
            txtSubtotal.Text = subtotal
            total = subtotal

            'calculo del ISV
            If ChkAplicarImpuesto.Checked = True Then
                txtDescuento.Enabled = False
                If ISVporciento = 15 Then
                    ISV = subtotal * (0.15)
                Else
                    ISV = subtotal * (0.17)
                End If
                txtISV.Text = ISV
                total = subtotal - ISV
            End If

            'calculo del descuento
            If ChkAplicarDescuento.Checked = True Then
                txtISV.Enabled = False
                If txtListaDescuentos.Text = "Comercial(Empleados)" Then
                    descuento = subtotal * (0.2)

                ElseIf txtListaDescuentos.Text = "Por Volumen(No acumulado)" Then
                    descuento = subtotal * (0.5)

                ElseIf txtListaDescuentos.Text = "Por Volumen(Acumulado)" Then
                    descuento = subtotal * (0.1)

                ElseIf txtListaDescuentos.Text = "Por Pronto Pago" Then
                    descuento = subtotal * (0.4)

                ElseIf txtListaDescuentos.Text = "Por 3ra Edad" Then
                    descuento = subtotal * (0.25)

                ElseIf txtListaDescuentos.Text = "Por menuedo" Then
                    descuento = subtotal * (0.2)
                End If
                txtDescuento.Text = descuento
                total = subtotal - descuento
            End If
            txtTotal.Text = total
        End If

    End Sub

    Private Sub ChkAplicarDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAplicarDescuento.CheckedChanged

        'limita al usuario a poder escojer entre descuento y ISV
        If ChkAplicarDescuento.Checked = False Then
            txtListaDescuentos.Enabled = False
            ChkAplicarImpuesto.Enabled = True
        Else
            txtListaDescuentos.Enabled = True
            ChkAplicarImpuesto.Enabled = False
        End If
    End Sub

    Private Sub ChkAplicarImpuesto_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAplicarImpuesto.CheckedChanged

        'limita al usuario a poder escojer entre descuento y ISV
        If ChkAplicarImpuesto.Checked = False Then
            txtListaISV.Enabled = False
            ChkAplicarDescuento.Enabled = True
        Else
            txtListaISV.Enabled = True
            ChkAplicarDescuento.Enabled = False
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        'Limpia cada una de las casillas
        txtPrecio.Text = ""
        txtCantidad.Text = ""
        ChkAplicarDescuento.Checked = False
        ChkAplicarImpuesto.Checked = False
        txtListaDescuentos.Text = ""
        txtListaISV.Text = ""

        txtSubtotal.Text = ""
        txtDescuento.Text = ""
        txtISV.Text = ""
        txtTotal.Text = ""
        'volver hacer inactivo el boton de "NUEVO"
        btnNuevo.Enabled = False

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
