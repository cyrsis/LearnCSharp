//*****************************************************************************
// Copyright Swordfish Computing 2006                                        **
//                                                                           **
// Filename: Swordfish\WinFX\Controls\UniformWrapPanel.cs                    **
// Authored by: John Stewien of Swordfish Computing                          **
// Date: April 2006                                                          **
//                                                                           **
// - Change Log -                                                            **
//*****************************************************************************
// $Id: UniformWrapPanel.cs,v 1.5 2006/05/26 07:06:38 John S Exp $

using System;
using System.Windows;
using System.Windows.Controls;

namespace CoursewareApp.Panels
{

	public class UniformWrapPanel : Panel
	{
		// ********************************************************************
		// Private Fields
		// ********************************************************************
		#region Private Fields

		/// <summary>
		/// The size of the cells to draw in the panel
		/// </summary>
		protected Size uniformSize;
		/// <summary>
		/// number of columns
		/// </summary>
		protected int columnCount;
		/// <summary>
		/// number of rows
		/// </summary>
		protected int rowCount;
		/// <summary>
		/// item ordering direction
		/// </summary>
		protected Orientation itemOrdering = Orientation.Vertical;
		/// <summary>
		/// item position flow direction
		/// </summary>
		protected Orientation wrapMode = Orientation.Horizontal;

		#endregion

		// ********************************************************************
		// Base Class Overrides
		// ********************************************************************
		#region Base Class Overrides

		/// <summary>
		/// Override the default Measure method of Panel
		/// </summary>
		/// <param name="availableSize"></param>
		/// <returns></returns>
		protected override Size MeasureOverride(Size availableSize)
		{
			Size childSize = availableSize;
			uniformSize = new Size(1, 1);

			// Get the maximum size
			foreach (UIElement child in InternalChildren)
			{
				child.Measure(childSize);
				uniformSize.Width = Math.Max(uniformSize.Width, child.DesiredSize.Width);
				uniformSize.Height = Math.Max(uniformSize.Height, child.DesiredSize.Height);
			}

			// Work out the size required depending if we are going to flow them down the left side, or across the top
			switch (wrapMode)
			{
				case Orientation.Horizontal:
					columnCount = (int)Math.Max(1, Math.Min(InternalChildren.Count, availableSize.Width / uniformSize.Width));
					rowCount = (int)Math.Ceiling((double)InternalChildren.Count / (double)columnCount);
					if (itemOrdering == Orientation.Vertical && rowCount != 0)
						columnCount = (int)Math.Ceiling((double)InternalChildren.Count / (double)rowCount);
					break;
				case Orientation.Vertical:
					rowCount = (int)Math.Max(1, Math.Min(InternalChildren.Count, availableSize.Height / uniformSize.Height));
					columnCount = (int)Math.Ceiling((double)InternalChildren.Count / (double)rowCount);
					if (itemOrdering == Orientation.Horizontal && columnCount != 0)
						rowCount = (int)Math.Ceiling((double)InternalChildren.Count / (double)columnCount);
					break;
			}

			Size requestedSize = new Size(columnCount * uniformSize.Width, rowCount * uniformSize.Height);

			return requestedSize;
		}

		/// <summary>
		/// Override the default Arrange method
		/// </summary>
		/// <param name="finalSize"></param>
		/// <returns></returns>
		protected override Size ArrangeOverride(Size finalSize)
		{
			int columnNo = 0;
			int rowNo = 0;

			Size returnSize = new Size(
				Math.Max(uniformSize.Width, finalSize.Width / columnCount),
				Math.Max(uniformSize.Height, finalSize.Height / rowCount));

			Size renderedSize = new Size(Math.Round(uniformSize.Width), Math.Round(uniformSize.Height));

			foreach (UIElement child in InternalChildren)
			{
				child.Arrange(new Rect(new Point(Math.Round(columnNo * uniformSize.Width), Math.Round(rowNo * uniformSize.Height)), renderedSize));

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

		#endregion Base Class Overrides

		// ********************************************************************
		// Properties
		// ********************************************************************
		#region Properties

		/// <summary>
		/// Gets sets the orientation of the order that items appear
		/// </summary>
		public Orientation ItemOrdering
		{
			get
			{
				return itemOrdering;
			}
			set
			{
				itemOrdering = value;
				InvalidateMeasure();
			}
		}

		/// <summary>
		/// Gets/Sets the method of flowing the layout of the items
		/// </summary>
		public Orientation WrapMode
		{
			get
			{
				return wrapMode;
			}
			set
			{
				wrapMode = value;
				InvalidateMeasure();
			}
		}

		#endregion Properties
	}
}
