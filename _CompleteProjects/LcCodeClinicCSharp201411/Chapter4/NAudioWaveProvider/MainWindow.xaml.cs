using NAudio.Wave;
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
        private WaveOut wavPlayer;
        SineWaveProvider32 wavProvider;

//        MediaPlayer player;
        bool isMouseDown = false;
        Point lastPoint;

        public MainWindow()
        {
            InitializeComponent();

            wavProvider = new SineWaveProvider32();
            wavProvider.SetWaveFormat(16000, 1); // 16kHz mono
            
            wavPlayer = new WaveOut();
            wavPlayer.Init(wavProvider);
            wavPlayer.Volume = .5F;

            DisplayValues();
            
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isMouseDown = true;
            wavPlayer.Play();
            DisplayValues();
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isMouseDown = false;
            wavPlayer.Stop();
            DisplayValues();
            
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            //Get current position as a point
            Point p = e.GetPosition(this);
            Debug.WriteLine(p);
            
            // Only process mouse moves if left mouse button is down
            if (isMouseDown)
            {
                //Get values to determine change in position
                double vDelta = p.Y - lastPoint.Y;
                double hDelta = p.X - lastPoint.X;

                //Horizontal moves affect volume
                if (Math.Abs(hDelta) > Math.Abs(vDelta))
                {
                    //Save current volume in case we need it
                    float currentVolume = wavPlayer.Volume;
                    try
                    {
                        //Set new volume
                        wavPlayer.Volume += (float)(hDelta / 200);
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        //Restore old volume
                        wavPlayer.Volume = currentVolume;
                    }
                }
                else
                {
                    //Save current frequency in case we need it
                    float currentFrequency = wavProvider.Frequency;

                    try
                    {
                        //Set new frequency, 10 units at a time
                        float increment;
                        if (vDelta > 0) {
                            if (wavProvider.Frequency == 0)
                            {
                                return;
                            }
                            increment = 10F;
                        }
                        else
                        {
                            increment = -10F;
                        }
                        wavProvider.Frequency -= increment;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        //Restore old frequency
                        wavProvider.Frequency = currentFrequency;
                    }
                }

                //Write values to the screen
                DisplayValues();
            }

            //Remember the current mouse position
            lastPoint = p;

        }

        private void DisplayValues()
        {
            if (!isMouseDown)
            {
                lblVolume.Content = "Off";
            }
            else {
                double volume = Math.Round(wavPlayer.Volume * 100, 2);
                lblVolume.Content = volume + "%";
            }

            float frequency = wavProvider.Frequency;
            lblPitch.Content = frequency + "Hz";
        }

    }
}
