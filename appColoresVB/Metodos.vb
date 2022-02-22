
Public Class Metodos
  Public Shared Sub Limpiar(f As Form)
    For Each elControl As Control In f.Controls
      If TypeOf elControl Is TextBox Then
        CType(elControl, TextBox).Clear()
      End If
    Next
  End Sub
End Class
