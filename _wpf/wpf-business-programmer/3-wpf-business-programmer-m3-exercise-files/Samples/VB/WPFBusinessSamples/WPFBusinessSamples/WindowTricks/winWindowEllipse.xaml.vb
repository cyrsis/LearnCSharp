Public Class winWindowEllipse
  Private Sub Window_MouseLeftButtonDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
    ' Call DragMove to move the window around the screen
    Me.DragMove()
  End Sub

  Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Me.Close()
  End Sub
End Class
