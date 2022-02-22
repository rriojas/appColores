Public Class Form1
  Private Sub CambiaColorFondo(ByVal sender As Object, ByVal e As EventArgs) Handles txtR.TextChanged, txtG.TextChanged, txtB.TextChanged
    Dim R As Integer = 0
    If txtR.Text <> "" Then
      R = Integer.Parse(txtR.Text)
    End If
    Dim G As Integer = 0
    If txtG.Text <> "" Then
      G = Integer.Parse(txtG.Text)
    End If
    Dim B As Integer = 0
    If txtB.Text <> "" Then
      B = Integer.Parse(txtB.Text)
    End If
    Me.BackColor = Color.FromArgb(R, G, B)
  End Sub
  Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
    Metodos.Limpiar(Me)
  End Sub
End Class
