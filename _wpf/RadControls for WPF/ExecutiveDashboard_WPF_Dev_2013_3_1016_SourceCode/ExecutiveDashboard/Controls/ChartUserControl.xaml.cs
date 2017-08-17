using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Telerik.Windows.Controls.Charting;
#if !SILVERLIGHT
using System.Windows.Media;
#endif

namespace ExecutiveDashboard
{
    public partial class ChartUserControl : UserControl
    {
        public bool IsAnimating
        {
            get { return (bool)GetValue(IsAnimatingProperty); }
            set { SetValue(IsAnimatingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsAnimating.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsAnimatingProperty =
            DependencyProperty.Register("IsAnimating", typeof(bool), typeof(ChartUserControl), new PropertyMetadata(false, OnIsAnimatingPropertyChanged));

        private static void OnIsAnimatingPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            (d as ChartUserControl).OnIsAnimatingChanged(args);
        }

        private void OnIsAnimatingChanged(DependencyPropertyChangedEventArgs args)
        {
            if ((bool)args.NewValue)
            {
                this.UpdateChartImage();
            }
        }

        public ChartUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates the image that is shown when the settings panel is being opened. 
        /// </summary>
        private void UpdateChartImage()
        {
            this.radChart.DefaultView.ChartArea.AxisX.AxisLabelsVisibility = Visibility.Collapsed;
            this.radChart.DefaultView.ChartArea.AxisY.AxisLabelsVisibility = Visibility.Collapsed;

            bool showPointMarks = (this.radChart.SeriesMappings[0].SeriesDefinition as AreaSeriesDefinition).ShowPointMarks;
            (this.DataContext as ViewModel).ShowPointMarks = false;


#if !SILVERLIGHT
            var bitmapSource = CreateBitmapSourceFromVisual(this.radChart.ActualWidth, this.radChart.ActualHeight, this.radChart, false);
            this.chartImage.Source = new WriteableBitmap(bitmapSource);
#else
            this.chartImage.Source = new WriteableBitmap(this.radChart, null);
#endif

            (this.DataContext as ViewModel).ShowPointMarks = showPointMarks;
            this.radChart.DefaultView.ChartArea.AxisX.AxisLabelsVisibility = Visibility.Visible;
            this.radChart.DefaultView.ChartArea.AxisY.AxisLabelsVisibility = Visibility.Visible;
        }

#if !SILVERLIGHT
        public static BitmapSource CreateBitmapSourceFromVisual(
        Double width,
        Double height,
        Visual visualToRender,
        Boolean undoTransformation)
        {

            if (visualToRender == null)
            {

                return null;

            }
            RenderTargetBitmap bmp = new RenderTargetBitmap((Int32)Math.Ceiling(width),
                                                            (Int32)Math.Ceiling(height),
                                                            96,
                                                            96,
                                                            PixelFormats.Pbgra32);

            if (undoTransformation)
            {

                DrawingVisual dv = new DrawingVisual();
                using (DrawingContext dc = dv.RenderOpen())
                {

                    VisualBrush vb = new VisualBrush(visualToRender);

                    dc.DrawRectangle(vb, null, new Rect(new Point(), new Size(width, height)));
                }
                bmp.Render(dv);
            }
            else
            {
                bmp.Render(visualToRender);
            }
            return bmp;
        }
#endif
    }
}
