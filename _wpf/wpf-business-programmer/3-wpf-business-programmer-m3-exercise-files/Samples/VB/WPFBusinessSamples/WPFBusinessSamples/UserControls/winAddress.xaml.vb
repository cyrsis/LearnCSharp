Public Class winAddress
  Private Sub btnGetData_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim addr As Address = DirectCast(ucAddr.DataContext, Address)

    MessageBox.Show(addr.GetAddress())
  End Sub

  Private Sub btnSetData_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim addr As New Address()

    addr.State = "CA"
    addr.Street1 = "1 Main Street"
    addr.City = "Tustin"
    addr.PostalCode = "92999"

    ucAddr.DataContext = addr
  End Sub

End Class
