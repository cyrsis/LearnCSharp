using System.Windows;
using System.Windows.Controls;

namespace CoursewareApp.Panels
{

	// panel idea from Nick Thuesen
	public class DiamondStackPanel : Panel
	{

		//private double m_defaultDimension = 140;
		private double m_currentMaxWidth = 0;
		private double m_currentMaxHeight = 0;

		public double DesiredElementDimension
		{
			get { return (double)GetValue(DesiredElementDimensionProperty); }
			set
			{
				////Make sure value is a double we can use else use the default.
				//if (Double.IsNaN(value) || Double.IsInfinity(value))
				//{
				//  value = m_defaultDimension;
				//}
				SetValue(DesiredElementDimensionProperty, value);
			}
		}

		//Create a DP
		// User can set dimensions size
		public static readonly DependencyProperty DesiredElementDimensionProperty =
				DependencyProperty.Register("DesiredElementDimension", typeof(double),
				typeof(DiamondStackPanel),
				new FrameworkPropertyMetadata(75.0, FrameworkPropertyMetadataOptions.AffectsMeasure));

		protected override Size ArrangeOverride(Size finalSize)
		{
			//Tracks the number of elements allowed in each diagonal row.
			int maxNumElementsInRow = 1;
			//Tracks the current position in each diagonal row.
			int currElementPositionInRow = 0;

			//Cycle through each child of the panel.
			foreach (UIElement currChild in Children)
			{
				//Create a rect for the child and set it's size.
				Rect childRect = new Rect(new Size(DesiredElementDimension, DesiredElementDimension));
				//Calculate current child's position.
				childRect.X = (currElementPositionInRow * DesiredElementDimension);
				childRect.Y = ((maxNumElementsInRow - 1) * DesiredElementDimension) - (currElementPositionInRow * DesiredElementDimension);

				//Arrange the child.
				currChild.Arrange(childRect);

				//Check to make sure current size isn't smaller than children's sum.
				if ((childRect.X + DesiredElementDimension) > m_currentMaxWidth)
					m_currentMaxWidth = childRect.X + DesiredElementDimension;
				if ((childRect.Y + DesiredElementDimension) > m_currentMaxHeight)
					m_currentMaxHeight = childRect.Y + DesiredElementDimension;

				//Increment to next position.
				currElementPositionInRow++;

				//Check to make sure current position isn't out of bounds for the current diagonal row.
				if (currElementPositionInRow >= maxNumElementsInRow)
				{
					maxNumElementsInRow++;
					currElementPositionInRow = 0;
				}
			}

			//Return the size.
			return new Size(m_currentMaxWidth, m_currentMaxHeight);
		}

		protected override Size MeasureOverride(Size availableSize)
		{
			//Just return the size we've been tracking.
			return new Size(m_currentMaxWidth, m_currentMaxHeight);
		}

	}
}
