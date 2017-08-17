Imports System.Globalization
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data

<ValueConversion(GetType(ListBoxItem), GetType(Thickness))> _
 Public Class IndexToMarginConverter
  Implements IValueConverter

  Public Function Convert(ByVal value As Object, _
                          ByVal targetType As Type, _
                          ByVal parameter As Object, _
                          ByVal culture As CultureInfo) As Object _
                          Implements System.Windows.Data.IValueConverter.Convert
    Dim ret As Thickness
    Dim itemIndex As Integer
    Dim lstItem As ListBoxItem
    Dim lstBox As ListBox

    lstItem = TryCast(value, ListBoxItem)
    lstBox = DirectCast(ItemsControl.ItemsControlFromItemContainer(lstItem), ListBox)
    itemIndex = lstBox.ItemContainerGenerator.IndexFromContainer(lstItem)

    If (itemIndex Mod 2) <> 0 Then
      ret = New Thickness(5, 0, 30, 30)
    Else
      ret = New Thickness(30, 25, 0, 0)
    End If

    Return ret
  End Function

  Public Function ConvertBack(ByVal value As Object, _
                              ByVal targetType As Type, _
                              ByVal parameter As Object, _
                              ByVal culture As CultureInfo) As Object _
                              Implements System.Windows.Data.IValueConverter.ConvertBack

    Throw New NotImplementedException()
  End Function
End Class
