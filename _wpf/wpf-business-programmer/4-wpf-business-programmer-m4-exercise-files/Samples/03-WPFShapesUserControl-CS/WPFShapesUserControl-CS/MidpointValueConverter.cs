using System;
using System.Globalization;
using System.Windows.Data;

namespace WPFShapesUserControl_CS
{
  public class MidpointValueConverter : IMultiValueConverter
  {
    #region Convert/ConvertBack Methods
    public object Convert(object[] values, Type targetType,
      object parameter, CultureInfo culture)
    {
      double offset = 0;
      double totalMeasure = 0;
      double controlMeasure = 0;

      // Make sure enough "values" were passed
      if (values == null || values.Length < 2)
      {
        throw new ArgumentException("The MidpointValueConverter class requires 2 double values to be passed to it. First pass the total measure (width/height) of the outside control, then the total measure (width/height) of the inside control.", "values");
      }

      // Get the total width/height
      totalMeasure = (double)values[0];
      // Get the width/height of the control
      controlMeasure = (double)values[1];

      // check for any offset to the width/height
      if (parameter != null)
        offset = System.Convert.ToDouble(parameter);

      return (object)(((totalMeasure - controlMeasure) / 2) + offset);
    }

    public object[] ConvertBack(object value, Type[] targetTypes,
      object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
    #endregion
  }
}
