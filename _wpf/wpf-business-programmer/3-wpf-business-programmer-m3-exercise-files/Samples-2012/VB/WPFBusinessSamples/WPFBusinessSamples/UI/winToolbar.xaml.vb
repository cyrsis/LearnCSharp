Public Class winToolbar
  Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
    ' Add Click event handler for each button in the Main toolbar
    tbrMain.[AddHandler](Button.ClickEvent, New RoutedEventHandler(AddressOf Button_Click))
    ' Add Click event handler for each button in the Help toolbar
    tbrHelp.[AddHandler](Button.ClickEvent, New RoutedEventHandler(AddressOf Button_Click))
  End Sub

  Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim btn As Button

    btn = DirectCast(e.OriginalSource, Button)
    Select Case btn.Tag.ToString()
      Case "New"
        MessageBox.Show("New")
        Exit Select
      Case "Save"
        MessageBox.Show("Save")
        Exit Select
      Case "Delete"
        MessageBox.Show("Delete")
        Exit Select
      Case "Explore"
        MessageBox.Show("Explore")
        Exit Select
      Case "Help"
        MessageBox.Show("Help")
        Exit Select
      Case Else
        MessageBox.Show(btn.Tag.ToString())
        Exit Select
    End Select
  End Sub
End Class
