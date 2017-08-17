using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SalesDashboard
{
    public partial class ColorSelector : UserControl
    {
        private double dragDeltaX, dragDeltaY;
        private bool canvasMouseLBPressed,hueMouseLBPressed;
        private bool changedManually = false;

        public ColorSelector()
        {
            this.DataContext = this;
            InitializeComponent();

            Loaded += new RoutedEventHandler(ColorSelector_Loaded);
        }

        void ColorSelector_Loaded(object sender, RoutedEventArgs e)
        {
            this.saturationSlider.ValueChanged += new RoutedPropertyChangedEventHandler<double>(saturationSlider_ValueChanged);
            this.luminanceSlider.ValueChanged += new RoutedPropertyChangedEventHandler<double>(luminanceSlider_ValueChanged);
            
            this.colorAreaCanvas.MouseLeftButtonDown += new MouseButtonEventHandler(colorArea_MouseLeftButtonDown);
            this.colorAreaCanvas.MouseLeftButtonUp += new MouseButtonEventHandler(colorAreaCanvas_MouseLeftButtonUp);
            this.colorAreaCanvas.MouseMove += new MouseEventHandler(colorAreaCanvas_MouseMove);
            this.colorAreaCanvas.SizeChanged += new SizeChangedEventHandler(colorAreaCanvas_SizeChanged);

            this.hueRectangle.MouseMove += this.hueRectangle_MouseMove;
            this.hueRectangle.MouseLeftButtonDown += this.hueRectangle_MouseLeftButtonDown;
            this.hueRectangle.MouseLeftButtonUp += this.hueRectangle_MouseLeftButtonUp;

            this.colorPickerThumb.DragStarted += this.ColorPickerThumb_DragStarted;
            this.colorPickerThumb.DragDelta += this.ColorPickerThumb_DragDelta;

            this.SetColorPickerThumbTop(1 - this.Luminance);
            this.SetColorPickerThumbLeft(this.Saturation);
        }

        void colorAreaCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.SetColorPickerThumbTop(1 - this.Luminance);
            this.SetColorPickerThumbLeft(this.Saturation);
        }

        //Canvas Events
        void colorAreaCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.colorAreaCanvas.ReleaseMouseCapture();
            this.canvasMouseLBPressed = false;
        }

        void colorArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            changedManually = true;

            this.canvasMouseLBPressed = this.colorAreaCanvas.CaptureMouse();
            double offsetX = 0;
            double offsetY = 0;

            offsetX = e.GetPosition(colorAreaCanvas).X;
            offsetY = e.GetPosition(colorAreaCanvas).Y;

            var saturationValue = offsetX / colorAreaCanvas.ActualWidth;
            var luminanceValue = 1 - offsetY / colorAreaCanvas.ActualHeight;

            this.saturationSlider.Value = saturationValue;
            this.luminanceSlider.Value = luminanceValue;
        }

        void colorAreaCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (canvasMouseLBPressed)
            {
                changedManually = true;
                double offsetX = 0;
                double offsetY = 0;

                offsetX = e.GetPosition(colorAreaCanvas).X;
                offsetY = e.GetPosition(colorAreaCanvas).Y;

                var saturationValue = offsetX / colorAreaCanvas.ActualWidth;
                var luminanceValue = 1 - offsetY / colorAreaCanvas.ActualHeight;

                this.saturationSlider.Value = saturationValue;
                this.luminanceSlider.Value = luminanceValue;
            }
        }

        //HueRectangle Events
        void hueRectangle_MouseMove(object sender, MouseEventArgs e)
        {
            if (hueMouseLBPressed)
            {
                changedManually = true;
                double offsetY = 0;
                offsetY = e.GetPosition(hueRectangle).Y;
                hueSlider.Value = 1 - offsetY / hueRectangle.ActualHeight;
            }
        }

        void hueRectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            hueRectangle.ReleaseMouseCapture();
            hueMouseLBPressed = false;
        }

        void hueRectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            changedManually = true;
            hueMouseLBPressed = hueRectangle.CaptureMouse();

            double offsetY = 0;
            offsetY = e.GetPosition(hueRectangle).Y;
            hueSlider.Value = 1 - offsetY / hueRectangle.ActualHeight;
        }

        //Slider Events
        private void SetColorPickerThumbTop(double top)
        {
            double containerLength = colorAreaCanvas.ActualHeight - colorPickerThumb.ActualHeight;
            Canvas.SetTop(this.colorPickerThumb, containerLength * (top));
            this.colorPickerThumb.Opacity = 1;
        }

        private void SetColorPickerThumbLeft(double left)
        {
            double containerLength = colorAreaCanvas.ActualWidth - colorPickerThumb.ActualWidth;
            Canvas.SetLeft(this.colorPickerThumb, containerLength * (left));
            this.colorPickerThumb.Opacity = 1;
        }

        private void luminanceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SetColorPickerThumbTop(1 - e.NewValue);
        }

        private void saturationSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SetColorPickerThumbLeft(e.NewValue);
        }

        void hueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            changedManually = true;
        }

        // Thumb Events
        private void ColorPickerThumb_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            this.dragDeltaX = saturationSlider.Value;
            this.dragDeltaY = luminanceSlider.Value;
        }

        private void ColorPickerThumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            changedManually = true;

            double offsetX = 0;
            double offsetY = 0;

            offsetX = DistanceConverter.PixelsToValue(e.HorizontalChange, (colorAreaCanvas.ActualWidth - colorPickerThumb.ActualWidth), (saturationSlider.Maximum - saturationSlider.Minimum));
            offsetY = DistanceConverter.PixelsToValue(e.VerticalChange, (colorAreaCanvas.ActualHeight - colorPickerThumb.ActualHeight), (luminanceSlider.Maximum - luminanceSlider.Minimum));

            this.dragDeltaX += offsetX;
            this.dragDeltaY += -offsetY;

            var saturationValue = this.dragDeltaX;
            var luminanceValue = this.dragDeltaY;

            this.saturationSlider.Value = saturationValue;
            this.luminanceSlider.Value = luminanceValue;
        }

        //Hue, Saturation, Luminance, CurrentColor
        public double Hue
        {
            get
            {
                return (double)GetValue(HueProperty);
            }
            set
            {
                SetValue(HueProperty, value);
            }
        }

        public double Saturation
        {
            get
            {
                return (double)GetValue(SaturationProperty);
            }
            set
            {
                SetValue(SaturationProperty, value);
            }
        }

        public double Luminance
        {
            get
            {
                return (double)GetValue(LuminanceProperty);
            }
            set
            {
                SetValue(LuminanceProperty, value);
            }
        }

        public Color CurrentColor
        {
            get
            {
                return (Color)GetValue(CurrentColorProperty);
            }
            set
            {
                SetValue(CurrentColorProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for Hue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HueProperty =
        DependencyProperty.Register("Hue", typeof(double), typeof(ColorSelector), new PropertyMetadata(0d, OnHuePropertyChanged));

        private static void OnHuePropertyChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ColorSelector cs = sender as ColorSelector;
            if (cs.changedManually)
            {
                Color newColor = ColorConverter.HSLtoRGB(1 - cs.hueSlider.Value, cs.saturationSlider.Value, cs.luminanceSlider.Value);
                cs.CurrentColor = newColor;
                cs.changedManually = false;
            }
        }

        // Using a DependencyProperty as the backing store for Saturation.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SaturationProperty =
        DependencyProperty.Register("Saturation", typeof(double), typeof(ColorSelector), new PropertyMetadata(0d, OnSaturationPropertyChanged));

        private static void OnSaturationPropertyChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ColorSelector cs = sender as ColorSelector;
            if (cs.changedManually)
            {
                Color newColor = ColorConverter.HSLtoRGB(1 - cs.hueSlider.Value, cs.saturationSlider.Value, cs.luminanceSlider.Value);
                cs.CurrentColor = newColor;
            }
            cs.changedManually = false;
        }

        // Using a DependencyProperty as the backing store for Luminance.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LuminanceProperty =
        DependencyProperty.Register("Luminance", typeof(double), typeof(ColorSelector), new PropertyMetadata(0d, OnLuminancePropertyChanged));

        private static void OnLuminancePropertyChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ColorSelector cs = sender as ColorSelector;
            if (cs.changedManually)
            {
                Color newColor = ColorConverter.HSLtoRGB(1 - cs.hueSlider.Value, cs.saturationSlider.Value, cs.luminanceSlider.Value);
                cs.CurrentColor = newColor;
            }
            cs.changedManually = false;
        }

        // Using a DependencyProperty as the backing store for CurrentColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentColorProperty =
        DependencyProperty.Register("CurrentColor", typeof(Color), typeof(ColorSelector), new PropertyMetadata(OnCurrentColorChanged));

        public static void OnCurrentColorChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ColorSelector cs = sender as ColorSelector;
            if (cs.CurrentColor == (Color)e.NewValue && cs.changedManually == false)
            {
                HSL hsl = ColorConverter.RGBtoHSL(cs.CurrentColor);
                cs.Hue = 1 - hsl.H;
                cs.Luminance = hsl.L;
                cs.Saturation = hsl.S;
            }
        }
    }
}