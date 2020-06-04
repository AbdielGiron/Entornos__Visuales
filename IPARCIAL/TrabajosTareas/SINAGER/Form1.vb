Public Class Form1
    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim departamentos, mascarillas As Integer
        departamentos = Val(txtDptos.Text)
        If departamentos > 18 Or departamentos < 1 Or txtDptos.Text = " " Or Not IsNumeric(txtDptos.Text) Then
            MsgBox("error en la primer casilla", vbInformation)
        Else
            For i = 1 To departamentos Step 1
                Do
                    mascarillas = InputBox("Ingrese la cantidad de mascarillas del Dpto " & i, "Ingresar",)
                    cmbCantidadXDptos.Items.Add(mascarillas)
                Loop While (mascarillas < 0 Or mascarillas > 10000)
            Next
        End If
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim idDepartamento, municipio, cantEntregada, stock As Integer
        Dim itemDepartamento As String

        idDepartamento = cmbCantidadXDptos.SelectedIndex
        itemDepartamento = cmbCantidadXDptos.SelectedItem.ToString
        municipio = Val(txtCantMuni.Text)
        txtStock.Text = cmbCantidadXDptos.SelectedItem
        stock = Val(txtStock.Text)

        Select Case idDepartamento
            Case 0
                For i = 1 To municipio Step 1
                    Do
                        cantEntregada = InputBox("Ingrese la cantidad de mascarillas del municipio " & i, "Ingresar",)
                        If cantEntregada <= stock Then
                            stock -= cantEntregada
                            txtStock.Text = stock
                        Else
                            MsgBox("Cantidad de mascarillas insuficientes", vbInformation)
                            i = i
                        End If
                    Loop While (stock < cantEntregada Or stock = 0)
                Next
            Case 2
            Case 3
            Case 4
            Case 5
            Case 6
            Case 7
            Case 8
            Case 9
            Case 10
            Case 11
            Case 12
            Case 13
            Case 14
            Case 15
            Case 16
            Case 17
            Case 18
        End Select
    End Sub

    Private Sub cmbCantidadXDptos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCantidadXDptos.SelectedIndexChanged
        Dim stock As Integer

        stock = cmbCantidadXDptos.SelectedItem.ToString
    End Sub
End Class
