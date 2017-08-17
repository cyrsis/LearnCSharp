Imports System.Windows
Imports System.Windows.Controls

Partial Public Class ucProductWithImages
  Inherits UserControl
  Private _ViewModel As ProductViewModel

#Region "Constructor / Initialize View Model"
  Public Sub New()
    InitializeComponent()

    ' Initialize the View Model
    _ViewModel = DirectCast(Me.FindResource("viewModel"), ProductViewModel)

    ' For some reason, the ListView is not Selected, so Select it
    lstData.SelectedIndex = 0
  End Sub
#End Region

#Region "Add Event"
  Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    ' Create blank Object and Put UI into Add Mode
    _ViewModel.AddRecord()
  End Sub
#End Region

#Region "Delete Event"
  Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    ' Need to move ListView to Selected Item
    lstData.SelectedItem = DirectCast(sender, Button).DataContext

    ' Delete the Current Item
    _ViewModel.DeleteData()
  End Sub
#End Region

#Region "Cancel Event"
  Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    ' Cancel the Edit
    _ViewModel.CancelEdit()
    lstData.SelectedIndex = 0
  End Sub
#End Region

#Region "Save Event"
  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    ' Save the Current Item
    _ViewModel.SaveData()
  End Sub
#End Region

#Region "Data Has Changed Methods"
  Private Sub TextHasChanged(ByVal sender As Object, ByVal e As TextChangedEventArgs)
    ' Only Change Mode if Element has Keyboard Focus
    If DirectCast(sender, UIElement).IsKeyboardFocused Then
      _ViewModel.SetViewStateMode(UIStateMode.Edit)
    End If
  End Sub

  Private Sub CheckedHasChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
    If DirectCast(sender, UIElement).IsKeyboardFocused OrElse DirectCast(sender, UIElement).IsMouseDirectlyOver Then
      _ViewModel.SetViewStateMode(UIStateMode.Edit)
    End If
  End Sub
#End Region
End Class