using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace BinaryResources
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            this.MouseDown += new MouseButtonEventHandler(Window1_MouseDown);
        }

        void Window1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Assembly asm = typeof(Window1).Assembly;
            Stream emResStream = asm.GetManifestResourceStream(
                "BinaryResources.EmRes.jpg");

            JpegBitmapDecoder jpegDecoder = new JpegBitmapDecoder(
                emResStream,
                BitmapCreateOptions.None, BitmapCacheOption.Default);

            img.Source = jpegDecoder.Frames[0];

        }
    }
}
