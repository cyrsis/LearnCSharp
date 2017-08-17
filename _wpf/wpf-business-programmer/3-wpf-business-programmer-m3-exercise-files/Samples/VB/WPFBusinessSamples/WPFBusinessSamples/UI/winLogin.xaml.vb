Public Class winLogin
  Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    DialogResult = True
    Me.Close()
  End Sub

  Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    DialogResult = False
    Me.Close()
  End Sub

End Class
