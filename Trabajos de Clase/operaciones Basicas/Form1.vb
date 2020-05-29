Public Class Form1

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If CheckBoxSuma.Checked = True Then
            txtSigno.Text = " +"

        ElseIf CheckBoxResta.Checked = True Then
            txtSigno.Text = "-"

        ElseIf CheckBoxMulti.Checked = True Then
            txtSigno.Text = "*"

        ElseIf CheckBoxDivi.Checked = True Then
            txtSigno.Text = "/"

        ElseIf CheckBoxPoten.Checked = True Then
            txtSigno.Text = "^"

        ElseIf CheckBoxRaiz.Checked = True Then
            txtSigno.Text = "²"
            txtValor2.Text = "Dejar Vacio"
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valor1, valor2 As Integer
        Dim suma, resta, multiplicacion, potencia As Integer
        Dim divicion, raiz, respuesta As Double

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        If txtValor1.Text = "" And txtValor2.Text = "" Then
            MsgBox("Ingrese un numero en ambas casillas", vbInformation)
        ElseIf txtValor2.Text Then
            MsgBox("Ingrese un numero en la primer casilla", vbInformation)
        ElseIf txtValor1.Text = "" Then
            MsgBox("Ingrese un numero en la primer casilla", vbInformation)
        End If

        If CheckBoxSuma.Checked = True Then
            suma = valor1 + valor2
            respuesta = suma

        ElseIf CheckBoxResta.Checked = True Then
            resta = valor1 - valor2
            respuesta = resta

        ElseIf CheckBoxMulti.Checked = True Then
            multiplicacion = valor1 * valor2
            respuesta = multiplicacion

        ElseIf CheckBoxDivi.Checked = True Then
            If valor2 = 0 Then
                MsgBox("ingrese un valor distinto de 0", vbInformation)
            Else
                divicion = valor1 / valor2
                respuesta = divicion
            End If
        ElseIf CheckBoxPoten.Checked = True Then
                potencia = valor1 ^ (valor2)
                respuesta = potencia

            ElseIf CheckBoxRaiz.Checked = True Then
                raiz = valor1 ^ 0.5

            respuesta = raiz
        End If

        txtRespuesta.Text = respuesta
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValor1.Text = ""
        txtValor2.Text = ""
        txtSigno.Text = ""
        txtRespuesta.Text = ""
        CheckBoxSuma.Checked = False
        CheckBoxResta.Checked = False
        CheckBoxMulti.Checked = False
        CheckBoxDivi.Checked = False
        CheckBoxPoten.Checked = False
        CheckBoxRaiz.Checked = False
    End Sub
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub CheckBoxSuma_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSuma.CheckedChanged
        If CheckBoxSuma.Checked = True Then
            CheckBoxDivi.Enabled = False
            CheckBoxMulti.Enabled = False
            CheckBoxPoten.Enabled = False
            CheckBoxRaiz.Enabled = False
            CheckBoxResta.Enabled = False
        End If
        If CheckBoxSuma.Checked = False Then
            CheckBoxDivi.Enabled = True
            CheckBoxMulti.Enabled = True
            CheckBoxPoten.Enabled = True
            CheckBoxRaiz.Enabled = True
            CheckBoxResta.Enabled = True
        End If
    End Sub
End Class
