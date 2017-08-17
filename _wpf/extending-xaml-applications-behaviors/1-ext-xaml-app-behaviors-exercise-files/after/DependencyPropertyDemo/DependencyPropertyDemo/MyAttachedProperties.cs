using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DependencyPropertyDemo
{
    public static class MyAttachedProperties
    {


        public static int GetSpeed(DependencyObject obj)
        {
            return (int)obj.GetValue(SpeedProperty);
        }

        public static void SetSpeed(DependencyObject obj, int value)
        {
            obj.SetValue(SpeedProperty, value);
        }

        // Using a DependencyProperty as the backing store for Speed.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SpeedProperty =
            DependencyProperty.RegisterAttached("Speed", typeof(int), typeof(MyAttachedProperties), new PropertyMetadata(11, OnSpeedChanged));

        private static void OnSpeedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Shape s = d as Shape;
            if (s != null)
            {
                s.Fill = new SolidColorBrush(Colors.Red);
            }
        }


    }
}
