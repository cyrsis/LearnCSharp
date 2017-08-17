Public Class winLoadUserControl
  Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    btnLoad.IsEnabled = False

    Dim ucaddr As New ucAddress()
    Dim addr As New Address()

    stpMain.Children.Add(ucaddr)

    ucaddr.DataContext = addr.CreateSample()
  End Sub
End Class
