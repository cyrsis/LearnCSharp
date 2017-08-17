Imports System.Windows
Imports System.Windows.Controls

''' <summary>
''' Interaction logic for winProductListDetail.xaml
''' </summary>
Partial Public Class winProductListDetail
  Inherits Window
  Public Sub New()
    InitializeComponent()
  End Sub

#Region "Cancel Event"
  Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    ' Cancel the Edit
    DirectCast(Me.DataContext, ProductViewModel).CancelEdit()
    Me.Close()
  End Sub
#End Region

#Region "Save Event"
  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    ' Save the Current Item
    DirectCast(Me.DataContext, ProductViewModel).SaveData()
    Me.Close()
  End Sub
#End Region

#Region "Data Has Changed Methods"
  Private Sub TextHasChanged(ByVal sender As Object, ByVal e As TextChangedEventArgs)
    ' Only Change Mode if Element has Keyboard Focus
    If DirectCast(sender, UIElement).IsKeyboardFocused Then
      DirectCast(Me.DataContext, ProductViewModel).SetViewStateMode(UIStateMode.Edit)
    End If
  End Sub

  Private Sub CheckedHasChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
    If DirectCast(sender, UIElement).IsKeyboardFocused OrElse DirectCast(sender, UIElement).IsMouseDirectlyOver Then
      DirectCast(Me.DataContext, ProductViewModel).SetViewStateMode(UIStateMode.Edit)
    End If
  End Sub
#End Region
End Class