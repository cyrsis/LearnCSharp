using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows;

namespace WaveData
{
    class DoubleArrayToPointsConverter : IValueConverter
    {
        private double widthValue = 100;

        public double Width
        {
            get { return widthValue; }
            set { widthValue = value; }
        }

        private double scaleValue = 1;

        public double Scale
        {
            get { return scaleValue; }
            set { scaleValue = value; }
        }

        private double offsetValue;

        public double Offset
        {
            get { return offsetValue; }
            set { offsetValue = value; }
        }


	
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double[] values = value as double[];
            if (values == null)
            {
                throw new ArgumentException("value", "Must be double[]");
            }

            PointCollection points = new PointCollection(values.Length);
            for (int i = 0; i < values.Length; ++i)
            {
                double x = i * Width / values.Length;
                double y = values[i] * Scale + Offset;
                points.Add(new Point(x, y));
            }

            return points;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
