using System.Windows;
using System.Windows.Controls;

namespace CoursewareApp.Panels {
	public class AnglePanel : Panel {

		private double _totalWidth = 0;
		private double _totalHeight = 0;
		// this method is called by the parent element (in this example, the Window)
		// return the desired size for this panel
		// availableSize:  provides a constraint to child, given this constraint, what size would you like to be?
		protected override Size MeasureOverride(Size availableSize) {


			// query all panel children
			foreach (UIElement child in Children)
			{

			

				// ask the child to measure it's content and children and set its desiredSize
				child.Measure(availableSize: availableSize);
				Size childSize = child.DesiredSize; // this value is set during the Measure() call.
				_totalWidth += childSize.Width;
				_totalHeight += childSize.Height;
			}

			return new Size(_totalWidth, _totalHeight); // this is the desired size for the AnglePanel;
		}

		// this method is called by the parent element (in this example, the Window)
		// return the Actual size for this panel
		// finalSize is the Size decided by parent element, based on value returned in MeasureOverride
		protected override Size ArrangeOverride(Size finalSize) {
			Point currentPosition = new Point();

			foreach (UIElement child in Children)
			{
				// Tell the child what location and and size to render
				
				Rect childRect = new Rect(location: currentPosition, size: child.DesiredSize);
				child.Arrange(finalRect: childRect);
				currentPosition.Offset(offsetX: childRect.Width,
															 offsetY: childRect.Height);
			}

			return new Size(_totalWidth, _totalHeight);
		}
		// use myPanel.DesiredSize and
		// myPanel.ActualSize to get the values returned from these methods
	}

}
