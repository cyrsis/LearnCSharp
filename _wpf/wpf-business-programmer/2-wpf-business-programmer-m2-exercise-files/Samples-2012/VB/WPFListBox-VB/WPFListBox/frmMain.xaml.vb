Namespace WPFListBox
  Partial Public Class frmMain
    Protected Sub btnListBox2Templates_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
      Dim frm As New frmListBox2Templates
      frm.Show()
    End Sub

    Protected Sub btnListFormat_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
      Dim frm As New frmListBoxFormat()
      frm.Show()
    End Sub

    Protected Sub btnListFormatConverter_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
      Dim frm As New frmListBoxFormatConverter()
      frm.Show()
    End Sub

    Protected Sub btnListImage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
      Dim frm As New frmListBoxWithImage()
      frm.Show()
    End Sub

    Protected Sub btnListBoxSortingUsingXaml_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
      Dim frm As New frmListBoxSortUsingXaml()
      frm.Show()
    End Sub

    Protected Sub btnListBoxFilter_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
      Dim frm As New frmListBoxFilter()
      frm.Show()
    End Sub

    Protected Sub btnListBoxSortingUsingCode_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
      Dim frm As New frmListBoxSortUsingCode()
      frm.Show()
    End Sub

    Protected Sub btnDataTriggerConverter_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
      Dim frm As New frmListBoxDataTriggerConverter()
      frm.Show()
    End Sub

    Protected Sub btnObjectConverter_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
      Dim frm As New frmListBoxConverterObject()
      frm.Show()
    End Sub

    Private Sub btnListBoxDataProvider_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnListBoxDataProvider.Click
      Dim frm As New frmListBoxDataProvider
      frm.Show()
    End Sub
  End Class
End Namespace