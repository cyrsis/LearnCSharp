Partial Public Class ucShape
#Region "Shape Enumeration"
  Public Enum ShapeEnums
    Rectangle
    Square
    Triangle
    InvertedTriangle
    Ellipse
    Circle
  End Enum
#End Region

#Region "Private Variables"
  Private mShapeToCreate As ShapeEnums = ShapeEnums.Rectangle
  Private mFillColor As String = "Blue"
  Private mStrokeColor As String = "Black"
  Private mTextColor As String = "White"
  Private mStrokeThickness As Double = 2.0R
  Private mHeightOffset As Integer = 0
  Private mWidthOffset As Integer = 0
#End Region

#Region "Public Properties"
  Public Property HeightOffset() As Integer
    Get
      Return mHeightOffset
    End Get
    Set(ByVal value As Integer)
      mHeightOffset = value
    End Set
  End Property

  Public Property WidthOffset() As Integer
    Get
      Return mWidthOffset
    End Get
    Set(ByVal value As Integer)
      mWidthOffset = value
    End Set
  End Property

  Public Property FillColor() As String
    Get
      Return mFillColor
    End Get
    Set(ByVal value As String)
      mFillColor = value
    End Set
  End Property

  Public Property StrokeColor() As String
    Get
      Return mStrokeColor
    End Get
    Set(ByVal value As String)
      mStrokeColor = value
    End Set
  End Property

  Public Property StrokeThickness() As Double
    Get
      Return mStrokeThickness
    End Get
    Set(ByVal value As Double)
      mStrokeThickness = value
    End Set
  End Property

  Public Property TextColor() As String
    Get
      Return mTextColor
    End Get
    Set(ByVal value As String)
      mTextColor = value
    End Set
  End Property

  Public Property TextToDisplay() As String
    Get
      Return tblock.Text
    End Get
    Set(ByVal value As String)
      tblock.Text = value
    End Set
  End Property

  Public Property ShapeToCreate() As String
    Get
      Return mShapeToCreate.ToString()
    End Get
    Set(ByVal value As String)
      Select Case value.ToLower()
        Case "rectangle"
          mShapeToCreate = ShapeEnums.Rectangle
          Exit Select

        Case "square"
          mShapeToCreate = ShapeEnums.Square
          Exit Select

        Case "triangle"
          mShapeToCreate = ShapeEnums.Triangle
          Exit Select

        Case "invertedtriangle"
          mShapeToCreate = ShapeEnums.InvertedTriangle
          Exit Select

        Case "ellipse"
          mShapeToCreate = ShapeEnums.Ellipse
          Exit Select

        Case "circle"
          mShapeToCreate = ShapeEnums.Circle
          Exit Select
        Case Else

          mShapeToCreate = ShapeEnums.Rectangle
          Exit Select
      End Select
    End Set
  End Property
#End Region

#Region "Loaded Event Procedure"
  Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim shape As Shape = Nothing

    shape = CreateShape()

    If shape IsNot Nothing Then
      ' Insert the Shape into the Canvas 
      ' Place it before the TextBlock Control 
      cnvMain.Children.Insert(0, shape)

      ' Setup the TextBlock Control Properties 
      tblock.Foreground = New SolidColorBrush(DirectCast(ColorConverter.ConvertFromString(mTextColor), Color))
      SetWidthMultiBinding()
      SetHeightMultiBinding()
    End If
  End Sub
#End Region

#Region "CreateShape Method"
  Private Function CreateShape() As Shape
    Dim pc As New PointCollection()
    Dim heightBinding As New Binding("ActualHeight")
    Dim widthBinding As New Binding("ActualWidth")
    Dim shape As Shape = Nothing

    Select Case mShapeToCreate
      Case ShapeEnums.Rectangle, ShapeEnums.Square
        shape = New Rectangle()

        heightBinding.Source = cnvMain.ActualHeight
        shape.SetBinding(Rectangle.HeightProperty, heightBinding)

        widthBinding.Source = cnvMain.ActualWidth
        shape.SetBinding(Rectangle.WidthProperty, widthBinding)

        Exit Select

      Case ShapeEnums.Triangle
        pc.Add(New Point((cnvMain.ActualWidth / 2), 0))
        pc.Add(New Point(0, cnvMain.ActualWidth))
        pc.Add(New Point(cnvMain.ActualWidth, cnvMain.ActualWidth))

        shape = New Polygon()
        DirectCast(shape, Polygon).Points = pc

        Exit Select

      Case ShapeEnums.InvertedTriangle
        pc.Add(New Point(0, 0))
        pc.Add(New Point((cnvMain.ActualWidth / 2), cnvMain.ActualWidth))
        pc.Add(New Point(cnvMain.ActualWidth, 0))

        shape = New Polygon()
        DirectCast(shape, Polygon).Points = pc

        Exit Select

      Case ShapeEnums.Ellipse, ShapeEnums.Circle
        shape = New Ellipse()

        heightBinding.Source = cnvMain.ActualHeight
        shape.SetBinding(Ellipse.HeightProperty, heightBinding)

        widthBinding.Source = cnvMain.ActualWidth
        shape.SetBinding(Ellipse.WidthProperty, widthBinding)

        Exit Select
    End Select

    If shape IsNot Nothing Then
      shape.Fill = New SolidColorBrush(DirectCast(ColorConverter.ConvertFromString(mFillColor), Color))
      shape.Stroke = New SolidColorBrush(DirectCast(ColorConverter.ConvertFromString(mStrokeColor), Color))
      shape.StrokeThickness = mStrokeThickness
      shape.Height = cnvMain.ActualHeight
      shape.Width = cnvMain.ActualWidth
    End If

    Return shape
  End Function
#End Region

#Region "SetWidthMultiBinding"
  Private Sub SetWidthMultiBinding()
    Dim mb As New MultiBinding()
    mb.Converter = New MidpointValueConverter()
    mb.ConverterParameter = mWidthOffset

    Dim bind As New Binding("ActualWidth")
    bind.Source = cnvMain
    bind.Path = New PropertyPath(Canvas.ActualWidthProperty)
    mb.Bindings.Add(bind)

    Dim bind2 As New Binding("ActualWidth")
    bind2.Source = tblock
    bind2.Path = New PropertyPath(TextBlock.ActualWidthProperty)
    mb.Bindings.Add(bind2)

    tblock.SetBinding(Canvas.LeftProperty, mb)
  End Sub
#End Region

#Region "SetHeightMultiBinding Method"
  Private Sub SetHeightMultiBinding()
    Dim mb As New MultiBinding()
    mb.Converter = New MidpointValueConverter()
    mb.ConverterParameter = mHeightOffset

    Dim bind As New Binding("ActualHeight")
    bind.Source = cnvMain
    bind.Path = New PropertyPath(Canvas.ActualHeightProperty)
    mb.Bindings.Add(bind)

    Dim bind2 As New Binding("ActualHeight")
    bind2.Source = tblock
    bind2.Path = New PropertyPath(TextBlock.ActualHeightProperty)
    mb.Bindings.Add(bind2)

    tblock.SetBinding(Canvas.TopProperty, mb)
  End Sub
#End Region
End Class
