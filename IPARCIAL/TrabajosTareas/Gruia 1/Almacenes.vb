Public Class Almacenes

    Dim numeroAlmacen As Integer
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        numeroAlmacen = 1


        If CheckBox1.Checked = True Then
            txtVenta.Enabled = True
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            CheckBox9.Enabled = False
            CheckBox10.Enabled = False
        Else
            txtVenta.Enabled = False
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
            CheckBox9.Enabled = True
            CheckBox10.Enabled = True
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        numeroAlmacen = 2

        If CheckBox2.Checked = True Then
            txtVenta.Enabled = True
            CheckBox1.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            CheckBox9.Enabled = False
            CheckBox10.Enabled = False
        Else
            txtVenta.Enabled = False
            CheckBox1.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
            CheckBox9.Enabled = True
            CheckBox10.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        numeroAlmacen = 3
        If CheckBox3.Checked = True Then
            txtVenta.Enabled = True
            CheckBox2.Enabled = False
            CheckBox1.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            CheckBox9.Enabled = False
            CheckBox10.Enabled = False
        Else
            txtVenta.Enabled = False
            CheckBox2.Enabled = True
            CheckBox1.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
            CheckBox9.Enabled = True
            CheckBox10.Enabled = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        numeroAlmacen = 4

        If CheckBox4.Checked = True Then
            txtVenta.Enabled = True
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox1.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            CheckBox9.Enabled = False
            CheckBox10.Enabled = False
        Else
            txtVenta.Enabled = False
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
            CheckBox9.Enabled = True
            CheckBox10.Enabled = True
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        numeroAlmacen = 5

        If CheckBox5.Checked = True Then
            txtVenta.Enabled = True
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox1.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            CheckBox9.Enabled = False
            CheckBox10.Enabled = False
        Else
            txtVenta.Enabled = False
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox1.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
            CheckBox9.Enabled = True
            CheckBox10.Enabled = True
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        numeroAlmacen = 6

        If CheckBox6.Checked = True Then
            txtVenta.Enabled = True
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox1.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            CheckBox9.Enabled = False
            CheckBox10.Enabled = False
        Else
            txtVenta.Enabled = False
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox1.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
            CheckBox9.Enabled = True
            CheckBox10.Enabled = True
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        numeroAlmacen = 7

        If CheckBox7.Checked = True Then
            txtVenta.Enabled = True
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox1.Enabled = False
            CheckBox8.Enabled = False
            CheckBox9.Enabled = False
            CheckBox10.Enabled = False
        Else
            txtVenta.Enabled = False
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox1.Enabled = True
            CheckBox8.Enabled = True
            CheckBox9.Enabled = True
            CheckBox10.Enabled = True
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        numeroAlmacen = 8

        If CheckBox8.Checked = True Then
            txtVenta.Enabled = True
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox1.Enabled = False
            CheckBox9.Enabled = False
            CheckBox10.Enabled = False
        Else
            txtVenta.Enabled = False
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox1.Enabled = True
            CheckBox9.Enabled = True
            CheckBox10.Enabled = True
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        numeroAlmacen = 9

        If CheckBox9.Checked = True Then
            txtVenta.Enabled = True
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            CheckBox1.Enabled = False
            CheckBox10.Enabled = False
        Else
            txtVenta.Enabled = False
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
            CheckBox1.Enabled = True
            CheckBox10.Enabled = True
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        numeroAlmacen = 10

        If CheckBox10.Checked = True Then
            txtVenta.Enabled = True
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            CheckBox9.Enabled = False
            CheckBox1.Enabled = False
        Else
            txtVenta.Enabled = False
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
            CheckBox9.Enabled = True
            CheckBox1.Enabled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim alm1, alm2, alm3, alm4, alm5, alm6, alm7, alm8, alm9, alm10, media As Double

        For i = 1 To 10 Step 1

            If txtVenta.Text = "" Then
                MsgBox("Ingrese las ventas mensuales", vbCritical)
            Else
                btnNuevo.Enabled = True
                Select Case numeroAlmacen

                    Case 1
                        alm1 = Val(txtVenta.Text)
                    Case 2
                        alm2 = Val(txtVenta.Text)
                    Case 3
                        alm3 = Val(txtVenta.Text)
                    Case 4
                        alm4 = Val(txtVenta.Text)
                    Case 5
                        alm5 = Val(txtVenta.Text)
                    Case 6
                        alm6 = Val(txtVenta.Text)
                    Case 7
                        alm7 = Val(txtVenta.Text)
                    Case 8
                        alm8 = Val(txtVenta.Text)
                    Case 9
                        alm9 = Val(txtVenta.Text)
                    Case 10
                        alm10 = Val(txtVenta.Text)
                End Select
            End If
        Next

        media = (alm1 + alm2 + alm3 + alm4 + alm5 + alm5 + alm6 + alm7 + alm8 + alm9 + alm10) / 10
        txtVenta.Text = media
        If alm1 > media Then
            cmbDestacados.Items.Add("El coral, Sigua")
        End If
        If alm2 > media Then
            cmbDestacados.Items.Add("El coral, Comayagua")
        End If
        If alm3 > media Then
            cmbDestacados.Items.Add("El coral, SPS")
        End If
        If alm4 > media Then
            cmbDestacados.Items.Add("La Colonia, sigua")
        End If
        If alm5 > media Then
            cmbDestacados.Items.Add("Pajaro Azul, SPS")
        End If
        If alm6 > media Then
            cmbDestacados.Items.Add("El Coral, Copan")
        End If
        If alm7 > media Then
            cmbDestacados.Items.Add("El Coral, Tegus")
        End If
        If alm8 > media Then
            cmbDestacados.Items.Add("La colonia, SPS")
        End If
        If alm9 > media Then
            cmbDestacados.Items.Add("La Colonia, tegus")
        End If
        If alm10 > media Then
            cmbDestacados.Items.Add("Pajaro Azul, Tegus")
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        txtVenta.Text = ""
        btnNuevo.Enabled = False
    End Sub
End Class