using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
#if !SILVERLIGHT
using System.Windows.Media;
#endif

namespace SalesDashboard
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

        private void UpdateChartImage()
        {
            var viewModel = this.DataContext as ViewModel;
            var areChartYLabelsVisible = viewModel.AreChartYLabelsVisible;
            Thickness newImageMargin = this.radChart.Margin;
            int newLeftMarginOffsetWhenBeingCollapsed = -27;
            int newLeftMarginOffsetWhenBeingExpanded = 19;

            //grid.width shows whether the options panel is collapsed (==0) or expanded (>0)
            newImageMargin.Left += (this.root.ActualWidth < 800) ? newLeftMarginOffsetWhenBeingCollapsed : newLeftMarginOffsetWhenBeingExpanded;

            this.chartImage.Margin = newImageMargin;

            var a = radChart.ActualWidth - radChart.SeriesMappings[3].ChartArea.ActualWidth;

            //hide chart axis labels
            this.radChart.SeriesMappings[3].ChartArea.AxisX.AxisLabelsVisibility = Visibility.Collapsed;
            viewModel.AreChartYLabelsVisible = false;
#if !SILVERLIGHT
            var bitmapSource = CreateBitmapSourceFromVisual(this.radChart.ActualWidth, this.radChart.ActualHeight, this.radChart, false);
            this.chartImage.Source = new WriteableBitmap(bitmapSource);
#else
            this.chartImage.Source = new WriteableBitmap(this.radChart, null);
#endif
            //show chart axis labels
            radChart.SeriesMappings[3].ChartArea.AxisX.AxisLabelsVisibility = Visibility.Visible;
            viewModel.AreChartYLabelsVisible = areChartYLabelsVisible;
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
