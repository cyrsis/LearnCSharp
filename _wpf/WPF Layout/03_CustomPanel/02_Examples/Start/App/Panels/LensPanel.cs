using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace CoursewareApp.
	Panels
{
	// John Stewien
	public class LensPanel : UniformWrapPanel
	{
		private Point lastPoint;
		private double radiusSquared = 62500;
		private double radius = 250;
		private double strength = 110;
		private bool mouseOver = false;
		public LensPanel()
		{
			this.MouseMove += new MouseEventHandler(LensUniformWrapPanel_MouseMove);
			this.MouseEnter += new MouseEventHandler(LensUniformWrapPanel_MouseEnter);
			this.MouseLeave += new MouseEventHandler(LensUniformWrapPanel_MouseLeave);
		}
		protected Rect GetTransformedRect(Point location, Size size)
		{
			Vector Top = new Vector(location.X + size.Width * 0.5 , location.Y);
			Vector Bottom = new Vector(location.X + size.Width * 0.5, location.Y + size.Height);
			Vector Left = new Vector(location.X, location.Y + size.Height * 0.5);
			Vector Right = new Vector(location.X + size.Width, location.Y + size.Height * 0.5);
			ApplyLensToPoint(ref Top);
			ApplyLensToPoint(ref Bottom);
			ApplyLensToPoint(ref Left);
			ApplyLensToPoint(ref Right);
			Rect retVal = new Rect(new Point(Left.X, Top.Y), new Size(Right.X - Left.X, Bottom.Y - Top.Y));
			return retVal;
		}
		protected void ApplyLensToPoint(ref Vector point)
		{
			Vector centre = (Vector)lastPoint;
			Vector diff = point - centre;
			if (diff.LengthSquared < radiusSquared)
			{
				Vector normalized = diff;
				normalized.Normalize();
				Vector offset = normalized * Math.Pow(Math.Sin(diff.Length / radius * Math.PI), 1) * strength;
				point += offset;
				if ((point - centre).LengthSquared > radiusSquared)
				{
					point = centre + normalized * radius;
				}
			}
		}
		protected override Size MeasureOverride(Size availableSize)
		{
			ScaleTransform unit = new ScaleTransform(1, 1);
			// Get the maximum size
			foreach (FrameworkElement child in InternalChildren)
			{
				child.LayoutTransform = unit;
			}
			return base.MeasureOverride(availableSize);
		}
		/// <summary>
		/// Override the default Arrange method
		/// </summary>
		/// <param name="finalSize"></param>
		/// <returns></returns>
		protected override Size ArrangeOverride(Size finalSize)
		{
			if (!mouseOver)
			{
				return base.ArrangeOverride(finalSize);
			}
			Size returnSize = new Size(
			 Math.Max(uniformSize.Width, finalSize.Width / columnCount),
			 Math.Max(uniformSize.Height, finalSize.Height / rowCount));
			Size renderedSize = new Size(Math.Ceiling(uniformSize.Width ), Math.Ceiling(uniformSize.Height));
			int columnNo = 0;
			int rowNo = 0;
			foreach (FrameworkElement child in InternalChildren)
			{
				Rect theRect = GetTransformedRect(new Point(Math.Round(columnNo * uniformSize.Width), Math.Round(rowNo * uniformSize.Height)), renderedSize);
				// Round off the rectangle sizes otherwise the PresentationFontCache gets thrashed
				// from all the different font sizes.
				ScaleTransform transform = new ScaleTransform(Math.Round(theRect.Width) / renderedSize.Width, Math.Round(theRect.Height) / renderedSize.Height);
				child.LayoutTransform = transform;
				child.Arrange(theRect);
				switch (itemOrdering)
				{
					case Orientation.Vertical:
						rowNo++;
						if (rowNo >= rowCount)
						{
							rowNo = 0;
							columnNo++;
						}
						break;
					case Orientation.Horizontal:
						columnNo++;
						if (columnNo >= columnCount)
						{
							columnNo = 0;
							rowNo++;
						}
						break;
				}
			}
			return new Size(returnSize.Width * columnCount, returnSize.Height * rowCount); // Returns the final Arranged size
		}
		// ********************************************************************
		// Mouse Handlers
		// ********************************************************************
		#region Mouse Handlers
		/// <summary>
		/// When the mouse leaves, this restores the control to normal appearance
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void LensUniformWrapPanel_MouseLeave(object sender, MouseEventArgs e)
		{
			mouseOver = false;
			this.InvalidateMeasure();
		}
		/// <summary>
		/// When the mouse enters this indicates the lens effect is operational
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void LensUniformWrapPanel_MouseEnter(object sender, MouseEventArgs e)
		{
			mouseOver = true;
		}
		/// <summary>
		/// Updates the appearance as the mouse moves over
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void LensUniformWrapPanel_MouseMove(object sender, MouseEventArgs e)
		{
			lastPoint = Mouse.GetPosition(this);
			this.InvalidateArrange();
		}
		#endregion Mouse Handlers
	}
}
