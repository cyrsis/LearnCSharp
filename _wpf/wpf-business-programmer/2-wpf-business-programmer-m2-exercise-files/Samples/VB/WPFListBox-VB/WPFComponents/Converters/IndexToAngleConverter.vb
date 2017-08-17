Imports System.Globalization
Imports System.Windows.Controls
Imports System.Windows.Data

<ValueConversion(GetType(ListBoxItem), GetType(Decimal))> _
Public Class IndexToAngleConverter
  Implements IValueConverter

  Public Const ANGLE As Integer = 15

  Public Function Convert(ByVal value As Object, _
                          ByVal targetType As Type, _
                          ByVal parameter As Object, _
                          ByVal culture As CultureInfo) As Object _
                   Implements System.Windows.Data.IValueConverter.Convert

    Dim ret As Double
    Dim itemIndex As Integer
    Dim lstItem As ListBoxItem
    Dim lstBox As ListBox

    ' The 'value' parameter is the ListBoxItem
    lstItem = TryCast(value, ListBoxItem)
    ' Get a reference to the list box so we can get the index of which item is being drawn
    lstBox = DirectCast(ItemsControl.ItemsControlFromItemContainer(lstItem), ListBox)
    ' Get the index of the item being drawn
    itemIndex = lstBox.ItemContainerGenerator.IndexFromContainer(lstItem)

    If (itemIndex Mod 2) <> 0 Then
      ret = ANGLE
    Else
      ret = -(ANGLE)
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