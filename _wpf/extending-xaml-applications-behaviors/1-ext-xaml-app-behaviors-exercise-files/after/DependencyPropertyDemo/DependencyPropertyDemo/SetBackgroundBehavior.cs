using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DependencyPropertyDemo
{
    public static class SetBackgroundBehavior
    {


        public static Brush GetBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(BrushProperty);
        }

        public static void SetBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(BrushProperty, value);
        }

        public static readonly DependencyProperty BrushProperty =
            DependencyProperty.RegisterAttached("Brush", typeof(Brush), 
            typeof(SetBackgroundBehavior), new PropertyMetadata(null, OnBrushChanged));

        private static void OnBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            FrameworkElement el = d as FrameworkElement;
            el.MouseEnter += (sender, arg) =>
                {
                    Control c = sender as Control;
                    if (c != null)
                    {
                        c.Background = (Brush)e.NewValue;
                    }
                    Panel p = sender as Panel;
                    if (p != null)
                    {
                        p.Background = GetBrush(p);
                    }
                    Shape s = sender as Shape;
                    if (s != null)
                    {
                        s.Fill = GetBrush(s);
                    }

                };
        }


    }
}
