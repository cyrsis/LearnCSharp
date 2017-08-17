Imports System.Globalization
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data

<ValueConversion(GetType(String), GetType(String))> _
 Public Class StringToLowerCaseConverter
  Implements IValueConverter

  Public Function Convert(ByVal value As Object, _
                          ByVal targetType As Type, _
                          ByVal parameter As Object, _
                          ByVal culture As CultureInfo) As Object _
                  Implements System.Windows.Data.IValueConverter.Convert
    Return System.Convert.ToString(value).ToLower()
  End Function

  Public Function ConvertBack(ByVal value As Object, _
                              ByVal targetType As Type, _
                              ByVal parameter As Object, _
                              ByVal culture As CultureInfo) As Object _
                  Implements System.Windows.Data.IValueConverter.ConvertBack
    Return System.Convert.ToString(value)
  End Function
End Class
