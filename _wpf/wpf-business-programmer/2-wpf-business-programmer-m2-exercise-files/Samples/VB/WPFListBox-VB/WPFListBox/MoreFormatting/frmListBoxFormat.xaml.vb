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

Namespace WPFListBox
  ''' <summary>
  ''' Interaction logic for frmListBoxFormat.xaml
  ''' </summary>
  Partial Public Class frmListBoxFormat
    Inherits Window

    Public Sub New()
      InitializeComponent()
    End Sub

    Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
      lstProducts.ItemsSource = Product.GetProducts(WPFCommon.GetCurrentDirectory() & "\Xml\Product.xml")
    End Sub
  End Class
End Namespace