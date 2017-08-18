using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace PlayWav
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MediaPlayer player = new MediaPlayer();
        bool isMouseDown;
        Point lastPoint;

        public MainWindow()
        {
            InitializeComponent();

            player.Open(new Uri("Tone.wav", UriKind.Relative));
            player.Volume = .5;
            DisplayValues();
            
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isMouseDown = true;
            player.Play();
            DisplayValues();
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isMouseDown = false;
            player.Stop();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            //Get current position as a point
            Point p = e.GetPosition(this);
            
            // Only process mouse moves if left mouse button is down
            if (isMouseDown)
            {
                //Get values to determine change in position
                double vDelta = p.Y - lastPoint.Y;
                double hDelta = p.X - lastPoint.X;

                //Horizontal moves affect volume
                if (Math.Abs(hDelta) > Math.Abs(vDelta))
                {
                    player.Volume += (hDelta / 200);
                }
                DisplayValues();
            }

            lastPoint = p;

        }

        private void DisplayValues()
        {
            double volume = Math.Round(player.Volume, 2) * 100;
            LabelVolume.Content = volume + "%";
        }

    }
}
