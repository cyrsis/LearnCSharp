using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CoursewareApp.Panels
{
  public class RadialPanel : Panel
  {

    #region Radius

    /// <summary>
    /// Radius Dependency Property
    /// </summary>
    public static readonly DependencyProperty RadiusProperty;

    /// <summary>
    /// Gets or sets the Radius property. This dependency property
    /// indicates ....
    /// </summary>
    public double Radius
    {
      get { return (double)GetValue(RadiusProperty); }
      set { SetValue(RadiusProperty, value); }
    }

    /// <summary>
    /// Handles changes to the Radius property.
    /// </summary>
    private static void OnRadiusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      RadialPanel target = (RadialPanel)d;
      double oldRadius = (double)e.OldValue;
      double newRadius = target.Radius;
      target.OnRadiusChanged(oldRadius, newRadius);
    }

    /// <summary>
    /// Provides derived classes an opportunity to handle changes to the Radius property.
    /// </summary>
    protected virtual void OnRadiusChanged(double oldRadius, double newRadius)
    {
    }

    #endregion
    #region ItemAlignment

    /// <summary>
    /// ItemAlignment Dependency Property
    /// </summary>
    public static readonly DependencyProperty ItemAlignmentProperty =
        DependencyProperty.Register("ItemAlignment", typeof(ItemAlignmentOptions), typeof(RadialPanel),
            new FrameworkPropertyMetadata((ItemAlignmentOptions)ItemAlignmentOptions.Center, 
              FrameworkPropertyMetadataOptions.AffectsArrange,
                new PropertyChangedCallback(OnItemAlignmentChanged)));

    /// <summary>
    /// Gets or sets the ItemAlignment property. This dependency property
    /// indicates ....
    /// </summary>
    public ItemAlignmentOptions ItemAlignment
    {
      get { return (ItemAlignmentOptions)GetValue(ItemAlignmentProperty); }
      set { SetValue(ItemAlignmentProperty, value); }
    }

    /// <summary>
    /// Handles changes to the ItemAlignment property.
    /// </summary>
    private static void OnItemAlignmentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      RadialPanel target = (RadialPanel)d;
      ItemAlignmentOptions oldItemAlignment = (ItemAlignmentOptions)e.OldValue;
      ItemAlignmentOptions newItemAlignment = target.ItemAlignment;
      target.OnItemAlignmentChanged(oldItemAlignment, newItemAlignment);
    }

    /// <summary>
    /// Provides derived classes an opportunity to handle changes to the ItemAlignment property.
    /// </summary>
    protected virtual void OnItemAlignmentChanged(ItemAlignmentOptions oldItemAlignment, ItemAlignmentOptions newItemAlignment)
    {
    }

    #endregion

    #region ItemOrientation

    /// <summary>
    /// ItemOrientation Dependency Property
    /// </summary>
    public static readonly DependencyProperty ItemOrientationProperty =
        DependencyProperty.Register("ItemOrientation", typeof(ItemOrientationOptions), typeof(RadialPanel),
            new FrameworkPropertyMetadata((ItemOrientationOptions)ItemOrientationOptions.Upright, 
              FrameworkPropertyMetadataOptions.AffectsArrange | FrameworkPropertyMetadataOptions.AffectsMeasure,
                new PropertyChangedCallback(OnItemOrientationChanged)));

    /// <summary>
    /// Gets or sets the ItemOrientation property. This dependency property
    /// indicates ....
    /// </summary>
    public ItemOrientationOptions ItemOrientation
    {
      get { return (ItemOrientationOptions)GetValue(ItemOrientationProperty); }
      set { SetValue(ItemOrientationProperty, value); }
    }

    /// <summary>
    /// Handles changes to the ItemOrientation property.
    /// </summary>
    private static void OnItemOrientationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      RadialPanel target = (RadialPanel)d;
      ItemOrientationOptions oldItemOrientation = (ItemOrientationOptions)e.OldValue;
      ItemOrientationOptions newItemOrientation = target.ItemOrientation;
      target.OnItemOrientationChanged(oldItemOrientation, newItemOrientation);
    }

    /// <summary>
    /// Provides derived classes an opportunity to handle changes to the ItemOrientation property.
    /// </summary>
    protected virtual void OnItemOrientationChanged(ItemOrientationOptions oldItemOrientation, ItemOrientationOptions newItemOrientation)
    {
    }

    #endregion
    static RadialPanel()
    {
      RadiusProperty = DependencyProperty.Register("Radius", typeof(double), typeof(RadialPanel),
            new FrameworkPropertyMetadata((double)1,
              FrameworkPropertyMetadataOptions.AffectsArrange,
                new PropertyChangedCallback(OnRadiusChanged)));
    }



    protected override Size MeasureOverride(Size availableSize)
    {
      Size max = new Size(0.0, 0.0);

      // Call Measure on each child and record the maximum
      // width and height of the child elements
      foreach (UIElement element in this.Children)
      {
        element.Measure(availableSize);
        max.Width = Math.Max(max.Width, element.DesiredSize.Width);
        max.Height = Math.Max(max.Height, element.DesiredSize.Height);
      }

      // Compute our own desired size, taking into account the fact
      // that availableSize could specify infinite widths and heights
      // (which are not valid return values)
      double width = double.IsPositiveInfinity(availableSize.Width) ?
          (2.0 * this.Radius) + max.Width : availableSize.Width;
      double height = double.IsPositiveInfinity(availableSize.Height) ?
          (2.0 * this.Radius) + max.Height : availableSize.Height;

      // Return our desired size
      return new Size(width, height);
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
      // Size and position the child elements
      this.Refresh(finalSize);
      return finalSize;
    }

    // Helper methods
    private void Refresh(Size size)
    {
      int i = 0;
      double inc = 360.0 / this.Children.Count;

      foreach (FrameworkElement element in this.Children)
      {
        double width = 0.0;
        double height = 0.0;

        switch (this.ItemAlignment)
        {
          case ItemAlignmentOptions.Left:
            width = 0.0;
            height = 0.0;
            break;

          case ItemAlignmentOptions.Center:
            width = element.DesiredSize.Width / 2.0;
            height = element.DesiredSize.Height / 2.0;
            break;

          case ItemAlignmentOptions.Right:
            width = element.DesiredSize.Width;
            height = element.DesiredSize.Height;
            break;
        }

        double angle = inc * i++;

        if (this.ItemOrientation == ItemOrientationOptions.Rotated)
        {
          RotateTransform transform = new RotateTransform();
          transform.CenterX = width;
          transform.CenterY = height;
          transform.Angle = angle;
          element.RenderTransform = transform;
        }

        double x = this.Radius * Math.Cos((Math.PI * angle) / 180.0);
        double y = this.Radius * Math.Sin((Math.PI * angle) / 180.0);

        element.Arrange(new Rect((x + (size.Width / 2.0)) - width,
            (y + (size.Height / 2.0)) - height,
            element.DesiredSize.Width,
            element.DesiredSize.Height));
      }
    }
  }

  // Enums
  public enum ItemAlignmentOptions
  {
    Left, Center, Right
  }

  public enum ItemOrientationOptions
  {
    Upright, Rotated
  }
}