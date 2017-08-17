Imports System.Globalization
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data

<ValueConversion(GetType(Product), GetType(String))> _
   Public Class ProductObjectConverter
  Implements IValueConverter

  Public Function Convert(ByVal value As Object, _
                          ByVal targetType As Type, _
                          ByVal parameter As Object, _
                          ByVal culture As CultureInfo) As Object _
                 Implements System.Windows.Data.IValueConverter.Convert
    Dim prod As Product
    Dim ret As String = String.Empty

    prod = DirectCast(value, Product)
    If prod IsNot Nothing Then
      ret = (prod.ProductName & " (ProductId=") + prod.ProductId.ToString() & ")"
    End If

    Return ret
  End Function

  Public Function ConvertBack(ByVal value As Object, _
                              ByVal targetType As Type, _
                              ByVal parameter As Object, _
                              ByVal culture As CultureInfo) As Object _
                  Implements System.Windows.Data.IValueConverter.ConvertBack
    Return System.Convert.ToString(value)
  End Function
End Class
