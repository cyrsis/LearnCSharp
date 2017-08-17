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
  ''' Interaction logic for frmListBoxFilter.xaml
  ''' </summary>
  Partial Public Class frmListBoxFilter

    Public Sub New()
      InitializeComponent()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
      FilterData()
    End Sub

    Private Sub FilterData()
      ' For Filtering to work, the ItemsSource must use the ToList()
      ' It must be IEnumerable<Customer>
      If lstCustomers IsNot Nothing Then
        Dim dataView As ICollectionView = CollectionViewSource.GetDefaultView(lstCustomers.ItemsSource)

        dataView.Filter = Function(cust) DirectCast(cust, Customer).LastName.ToLower().StartsWith(txtLast.Text.ToLower())

        lstCustomers.ItemsSource = dataView
      End If
    End Sub
  End Class
End Namespace
