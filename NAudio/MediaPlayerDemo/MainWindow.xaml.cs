using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MediaPlayerDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            comboUrl.SelectedIndex = 0;
            mediaElement.LoadedBehavior = MediaState.Manual;
            mediaElement.MediaOpened += OnMediaOpened;
            mediaElement.MediaFailed += OnMediaFailed;            
        }

        private void OnPlayClick(object sender, RoutedEventArgs e)
        {
            mediaElement.Source =  new Uri(comboUrl.Text, UriKind.RelativeOrAbsolute);
            mediaElement.Volume = 0.5;
            mediaElement.Play();
        }

        void OnMediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show(e.ErrorException.Message);
        }

        private void OnMediaOpened(object sender, RoutedEventArgs routedEventArgs)
        {
            labelDuration.Content = mediaElement.NaturalDuration.ToString();
        }

        private void OnStopClick(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
        }

        private void OnRewindClick(object sender, RoutedEventArgs e)
        {
            mediaElement.Position = TimeSpan.Zero;
        }
    }
}
