Public Class Form1
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim cadena As String
        cadena = txtCadena.Text
        'lenght retorna el Nº de posiciones de una cadena, incluyendo los espacios
        txtLongitud.Text = cadena.Length
        txtUltimoCaracter.Text = cadena.Substring(cadena.Length - 1, 1)
        txtPrimerCaracter.Text = cadena.Substring(0, 1)
        txtPosicionFija.Text = cadena.Substring(2, 7)
        txtPosicionB.Text = cadena.IndexOf("B", 0) + 1
        txtMayusculas.Text = cadena.ToUpper
        txtMinusculas.Text = cadena.ToLower
        txtBorrasEspacios.Text = cadena.Replace(" ", "")
    End Sub
End Class
