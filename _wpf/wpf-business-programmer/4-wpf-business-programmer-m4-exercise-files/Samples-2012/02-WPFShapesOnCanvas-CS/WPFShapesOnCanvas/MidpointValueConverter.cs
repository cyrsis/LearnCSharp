using System;
using System.Globalization;
using System.Windows.Data;

namespace WPFShapesOnCanvas
{
  public class MidpointValueConverter : IMultiValueConverter
  {
    #region Convert/ConvertBack Methods
    public object Convert(object[] values, Type targetType,
      object parameter, CultureInfo culture)
    {
      double offset = 0;

      if (values == null || values.Length < 2)
      {
        throw new ArgumentException("The MidpointValueConverter class requires 2 double values to be passed to it. First pass the Total Overall Measurement (Height/Width), then the Control Measurement to Center.", "values");
      }

      double totalMeasure = (double)values[0];
      double controlMeasure = (double)values[1];

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
