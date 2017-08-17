using System.Windows;
using System.Windows.Media;

namespace LowLevelRendering
{
    public class CustomRender : FrameworkElement
    {
        protected override void OnRender(DrawingContext drawingContext)
        {
            Rect r = new Rect(0, 0, ActualWidth, ActualHeight);
            drawingContext.DrawRectangle(Brushes.Red, null, r);

            Point ellipseCenter = new Point(ActualWidth / 2, ActualHeight / 2);
            drawingContext.DrawEllipse(Brushes.Yellow, new Pen(Brushes.Black, 2),
                ellipseCenter, ActualWidth / 2 - 4, ActualHeight / 2 - 4);
        }
    }

}
