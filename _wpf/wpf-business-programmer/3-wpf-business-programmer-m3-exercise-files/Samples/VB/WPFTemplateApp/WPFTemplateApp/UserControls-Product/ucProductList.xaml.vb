Imports System.Windows
Imports System.Windows.Controls

Partial Public Class ucProductList
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

    ' Display the Edit Window
    Dim win As New winProductListDetail()
    win.DataContext = _ViewModel
    win.ShowDialog()
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

#Region "Edit Click Event"
  Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    ' Need to move ListView to Selected Item
    lstData.SelectedItem = DirectCast(sender, Button).DataContext

    ' Display the Edit Window
    Dim win As New winProductListDetail()
    win.DataContext = _ViewModel
    win.ShowDialog()
  End Sub
#End Region
End Class