Public Class winMain
  Private Sub btnMenus_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winMenus()

    win.Show()
  End Sub

  Private Sub btnAbout_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winAbout()

    win.Show()
  End Sub

  Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winLogin()

    win.Owner = Me
    win.ShowDialog()
    If win.DialogResult.HasValue AndAlso win.DialogResult.Value Then
      MessageBox.Show("User Logged In")
    Else
      MessageBox.Show("User Clicked Cancel")
    End If
  End Sub

  Private Sub btnToolbar_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winToolbar()

    win.Show()
  End Sub

  Private Sub btnStatusbar_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winStatusBar()

    win.Show()
  End Sub

  Private Sub btnStatusbarPanels_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winStatusBarPanels()

    win.Show()
  End Sub

  Private Sub btnTooltip_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winTooltips()

    win.Show()
  End Sub

  Private Sub btnHyperlink_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winHyperlink()

    win.Show()
  End Sub

  Private Sub btnDockPanelLayout_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winDockPanelLayout()

    win.Show()
  End Sub

  Private Sub btnGridLayout_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winGridLayout()

    win.Show()
  End Sub

  Private Sub btnGridLayout2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winGridLayout2()

    win.Show()
  End Sub

  Private Sub btnLogin2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winLogin2()

    win.Owner = Me
    win.ShowDialog()
    If win.DialogResult.HasValue AndAlso win.DialogResult.Value Then
      MessageBox.Show("User Logged In")
    Else
      MessageBox.Show("User Clicked Cancel")
    End If
  End Sub


  Private Sub btnAddressUserControl_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winAddress()

    win.Show()
  End Sub

  Private Sub btnLoadUserControl_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winLoadUserControl()

    win.Show()
  End Sub

  Private Sub btnMenusOnLeft_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winMenuOnLeft()

    win.Show()
  End Sub

  Private Sub btnWinNoBorder_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winWindowNoBorder()

    win.Show()
  End Sub

  Private Sub btnWinEllipse_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim win As New winWindowEllipse()

    win.Show()
  End Sub
End Class
