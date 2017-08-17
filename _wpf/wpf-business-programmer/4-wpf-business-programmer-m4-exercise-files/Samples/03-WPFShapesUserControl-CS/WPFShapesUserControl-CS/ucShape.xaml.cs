using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPFShapesUserControl_CS
{
  /// <summary>
  /// Interaction logic for ucShape.xaml
  /// </summary>
  public partial class ucShape : UserControl
  {
    public ucShape()
    {
      InitializeComponent();
    }

    #region Shape Enumeration
    public enum ShapeEnums
    {
      Rectangle,
      Square,
      Triangle,
      InvertedTriangle,
      Ellipse,
      Circle
    }
    #endregion

    #region Private Variables
    private ShapeEnums mShapeToCreate = ShapeEnums.Rectangle;
    private string mFillColor = "Blue";
    private string mStrokeColor = "Black";
    private string mTextColor = "White";
    private double mStrokeThickness = 2.0;
    private int mHeightOffset = 0;
    private int mWidthOffset = 0;
    #endregion

    #region Public Properties
    public int HeightOffset
    {
      get { return mHeightOffset; }
      set { mHeightOffset = value; }
    }

    public int WidthOffset
    {
      get { return mWidthOffset; }
      set { mWidthOffset = value; }
    }

    public string FillColor
    {
      get { return mFillColor; }
      set { mFillColor = value; }
    }

    public string StrokeColor
    {
      get { return mStrokeColor; }
      set { mStrokeColor = value; }
    }

    public double StrokeThickness
    {
      get { return mStrokeThickness; }
      set { mStrokeThickness = value; }
    }

    public string TextColor
    {
      get { return mTextColor; }
      set { mTextColor = value; }
    }

    public string TextToDisplay
    {
      get { return tblock.Text; }
      set { tblock.Text = value; }
    }

    public string ShapeToCreate
    {
      get { return mShapeToCreate.ToString(); }
      set
      {
        switch (value.ToLower())
        {
          case "rectangle":
            mShapeToCreate = ShapeEnums.Rectangle;
            break;

          case "square":
            mShapeToCreate = ShapeEnums.Square;
            break;

          case "triangle":
            mShapeToCreate = ShapeEnums.Triangle;
            break;

          case "invertedtriangle":
            mShapeToCreate = ShapeEnums.InvertedTriangle;
            break;

          case "ellipse":
            mShapeToCreate = ShapeEnums.Ellipse;
            break;

          case "circle":
            mShapeToCreate = ShapeEnums.Circle;
            break;

          default:
            mShapeToCreate = ShapeEnums.Rectangle;
            break;
        }
      }
    }
    #endregion

    #region Loaded Event Procedure
    private void UserControl_Loaded(object sender, RoutedEventArgs e)
    {
      Shape shape = null;

      shape = CreateShape();

      if (shape != null)
      {
        // Insert the Shape into the Canvas 
        // Place it before the TextBlock Control
        cnvMain.Children.Insert(0, shape);

        // Setup the TextBlock Control Properties
        tblock.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(mTextColor));
        SetWidthMultiBinding();
        SetHeightMultiBinding();
      }
    }
    #endregion

    #region CreateShape Method
    private Shape CreateShape()
    {
      PointCollection pc = new PointCollection();
      Binding heightBinding = new Binding("ActualHeight");
      Binding widthBinding = new Binding("ActualWidth");
      Shape shape = null;

      switch (mShapeToCreate)
      {
        case ShapeEnums.Rectangle:
        case ShapeEnums.Square:
          shape = new Rectangle();

          heightBinding.Source = cnvMain.ActualHeight;
          shape.SetBinding(Rectangle.HeightProperty, heightBinding);

          widthBinding.Source = cnvMain.ActualWidth;
          shape.SetBinding(Rectangle.WidthProperty, widthBinding);

          break;

        case ShapeEnums.Triangle:
          pc.Add(new Point((cnvMain.ActualWidth / 2), 0));
          pc.Add(new Point(0, cnvMain.ActualWidth));
          pc.Add(new Point(cnvMain.ActualWidth, cnvMain.ActualWidth));

          shape = new Polygon();
          ((Polygon)shape).Points = pc;

          break;

        case ShapeEnums.InvertedTriangle:
          pc.Add(new Point(0, 0));
          pc.Add(new Point((cnvMain.ActualWidth / 2), cnvMain.ActualWidth));
          pc.Add(new Point(cnvMain.ActualWidth, 0));

          shape = new Polygon();
          ((Polygon)shape).Points = pc;

          break;

        case ShapeEnums.Ellipse:
        case ShapeEnums.Circle:
          shape = new Ellipse();

          heightBinding.Source = cnvMain.ActualHeight;
          shape.SetBinding(Ellipse.HeightProperty, heightBinding);

          widthBinding.Source = cnvMain.ActualWidth;
          shape.SetBinding(Ellipse.WidthProperty, widthBinding);

          break;
      }

      if (shape != null)
      {
        shape.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(mFillColor));
        shape.Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString(mStrokeColor));
        shape.StrokeThickness = mStrokeThickness;
        shape.Height = cnvMain.ActualHeight;
        shape.Width = cnvMain.ActualWidth;
      }

      return shape;
    }
    #endregion

    #region SetWidthMultiBinding
    private void SetWidthMultiBinding()
    {
      MultiBinding mb = new MultiBinding();
      mb.Converter = new MidpointValueConverter();
      mb.ConverterParameter = mWidthOffset;

      Binding bind = new Binding("ActualWidth");
      bind.Source = cnvMain;
      bind.Path = new PropertyPath(Canvas.ActualWidthProperty);
      mb.Bindings.Add(bind);

      Binding bind2 = new Binding("ActualWidth");
      bind2.Source = tblock;
      bind2.Path = new PropertyPath(TextBlock.ActualWidthProperty);
      mb.Bindings.Add(bind2);

      tblock.SetBinding(Canvas.LeftProperty, mb);
    }
    #endregion

    #region SetHeightMultiBinding Method
    private void SetHeightMultiBinding()
    {
      MultiBinding mb = new MultiBinding();
      mb.Converter = new MidpointValueConverter();
      mb.ConverterParameter = mHeightOffset;

      Binding bind = new Binding("ActualHeight");
      bind.Source = cnvMain;
      bind.Path = new PropertyPath(Canvas.ActualHeightProperty);
      mb.Bindings.Add(bind);

      Binding bind2 = new Binding("ActualHeight");
      bind2.Source = tblock;
      bind2.Path = new PropertyPath(TextBlock.ActualHeightProperty);
      mb.Bindings.Add(bind2);

      tblock.SetBinding(Canvas.TopProperty, mb);
    }
    #endregion
  }
}
