Imports System
Imports System.Globalization
Imports System.Windows.Data

Public Class MidpointValueConverter
  Implements IMultiValueConverter

#Region "Convert/ConvertBack Methods"
  Public Function Convert(ByVal values As Object(), ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IMultiValueConverter.Convert
    Dim offset As Double = 0
    Dim totalMeasure As Double = 0
    Dim controlMeasure As Double = 0

    ' Make sure enough "values" were passed
    If values Is Nothing OrElse values.Length < 2 Then
      Throw New ArgumentException("The MidpointValueConverter class requires 2 double values to be passed to it. First pass the total measure (width/height) of the outside control, then the total measure (width/height) of the inside control.", "values")
    End If

    ' Get the total width/height
    totalMeasure = System.Convert.ToDouble(values(0))
    ' Get the width/height of the control
    controlMeasure = System.Convert.ToDouble(values(1))

    If parameter IsNot Nothing Then
      offset = System.Convert.ToDouble(parameter)
    End If

    Return DirectCast((((totalMeasure - controlMeasure) / 2) + offset), Object)
  End Function

  Public Function ConvertBack(ByVal value As Object, ByVal targetTypes As Type(), ByVal parameter As Object, ByVal culture As CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
    Throw New NotImplementedException()
  End Function
#End Region
End Class