using System.Windows;
using System.Windows.Controls;

namespace CoursewareApp.Panels
{
	public class AnglePanel : Panel
	{

		protected override Size MeasureOverride(Size availableSize)
		{
			double totalWidth = 0;
			double totalHeight = 0;

			foreach (UIElement child in Children)
			{
				child.Measure(new Size(double.PositiveInfinity,
																 double.PositiveInfinity));
				Size childSize = child.DesiredSize;
				totalWidth += childSize.Width;
				totalHeight += childSize.Height;
			}

			return new Size(totalWidth, totalHeight);
		}

		protected override Size ArrangeOverride(Size finalSize)
		{
			Point currentPosition = new Point();

			foreach (UIElement child in Children)
			{
				Rect childRect = new Rect(currentPosition, child.DesiredSize);
				child.Arrange(childRect);
				currentPosition.Offset(childRect.Width, childRect.Height);
			}

			return new Size(currentPosition.X, currentPosition.Y);
		}
	}

}
