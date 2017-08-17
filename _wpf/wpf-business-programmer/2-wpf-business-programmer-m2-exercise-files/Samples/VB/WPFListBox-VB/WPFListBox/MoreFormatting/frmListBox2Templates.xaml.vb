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

Namespace WPFListBox
  ''' <summary>
  ''' Interaction logic for frmListBox2Templates.xaml
  ''' </summary>
  Partial Public Class frmListBox2Templates
    Inherits Window

    Public Sub New()
      InitializeComponent()
    End Sub

    Private Sub btnMore_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
      Dim tmpl As DataTemplate

      tmpl = DirectCast(Me.FindResource("tmplMore"), DataTemplate)
      If tmpl IsNot Nothing Then
        lstData.ItemTemplate = tmpl
      End If
    End Sub

    Private Sub btnLess_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
      Dim tmpl As DataTemplate

      tmpl = DirectCast(Me.FindResource("tmplLess"), DataTemplate)
      If tmpl IsNot Nothing Then
        lstData.ItemTemplate = tmpl
      End If
    End Sub
  End Class
End Namespace