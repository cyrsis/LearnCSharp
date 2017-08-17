Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes

Imports WPFComponents
Imports System.ComponentModel

Namespace WPFListBox
  ''' <summary>
  ''' Interaction logic for frmListBoxSortUsingCode.xaml
  ''' </summary>
  Partial Public Class frmListBoxSortUsingCode
    Inherits Window

    Public Sub New()
      InitializeComponent()
    End Sub

    Private Sub SortTheData(ByVal sender As Object, ByVal e As RoutedEventArgs)
      ' For sorting to work, the ItemsSource must use the ToList()
      If lstCustomers IsNot Nothing Then
        Dim dataView As ICollectionView = CollectionViewSource.GetDefaultView(lstCustomers.ItemsSource)

        dataView.SortDescriptions.Clear()
        dataView.SortDescriptions.Add(New SortDescription(TryCast(sender, RadioButton).Tag.ToString(), ListSortDirection.Ascending))

        lstCustomers.ItemsSource = dataView
      End If
    End Sub
  End Class
End Namespace
