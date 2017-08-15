using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Mod05_NETNative
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Mandelbrot _mandelbrot = new Mandelbrot(600, 600);
        private double _elapsedMilliseconds;
        private WriteableBitmap _bitmap;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void RunClick(object sender, RoutedEventArgs e)
        {
            _bitmap = BitmapFactory.New(_mandelbrot.Width, _mandelbrot.Height);
            await RunAndTimeMandelbrotInBackground();

            // Avoid invalidation for each pixel drawn
            using (_bitmap.GetBitmapContext())
            {
                _mandelbrot.Draw(_bitmap);
            }

            fractalImage.Width = _mandelbrot.Width;
            fractalImage.Height = _mandelbrot.Height;
            fractalImage.Source = _bitmap;

            elapsedTimeText.Text = String.Format("Calculation time: {0:0.000}ms", _elapsedMilliseconds);
        }

        private Task RunAndTimeMandelbrotInBackground()
        {
            return Task.Run(() =>
                {
                    Stopwatch sw = Stopwatch.StartNew();
                    _mandelbrot.Calculate();
                    _elapsedMilliseconds = sw.Elapsed.TotalMilliseconds;
                });
        }
    }
}
