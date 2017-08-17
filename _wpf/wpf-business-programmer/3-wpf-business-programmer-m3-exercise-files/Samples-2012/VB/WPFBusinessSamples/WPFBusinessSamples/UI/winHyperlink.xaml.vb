Public Class winHyperlink
  Private Sub lnkAbout_RequestNavigate(ByVal sender As Object, ByVal e As System.Windows.Navigation.RequestNavigateEventArgs)
    Dim win As New winAbout()

    win.Show()
  End Sub
End Class
