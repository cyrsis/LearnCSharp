using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;

namespace WpfApplication8
{
    abstract class Shape
    {
        public Shape(Canvas canvas)
        {
            _canvas = canvas;
        }

        public virtual void Draw()
        {
            double left = _canvas.ActualWidth * _rand.NextDouble();
            double top = _canvas.ActualHeight * _rand.NextDouble();
            _element.SetValue(Canvas.LeftProperty, left);
            _element.SetValue(Canvas.TopProperty, top);
            _canvas.Children.Add(_element);
        }

        private Canvas _canvas;
        protected System.Windows.Shapes.Shape _element;
        static Random _rand = new Random();
    }

    class Circle : Shape
    {
        public Circle(Canvas canvas) 
            :base(canvas)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 10;
            ellipse.Height = 10;
            ellipse.Fill = new SolidColorBrush(Colors.Green);
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
            _element = ellipse;
        }

        public override void Draw()
        {
            _element.Fill = new SolidColorBrush(Colors.Red);
            base.Draw();
        }
       
    }

    class Square : Shape
    {
        public Square(Canvas canvas)
            :base(canvas)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 10;
            rect.Height = 10;
            rect.Fill = new SolidColorBrush(Colors.Green);
            rect.Stroke = new SolidColorBrush(Colors.Black);
            _element = rect;
        }       
    }
}
