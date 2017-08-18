using System.Windows;

namespace PlayBeep
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayBtn_Click(object sender, RoutedEventArgs e)
        {
            //Play a tone for 3 seconds
            int frequency = 440;
            int duration = 3000;
            System.Console.Beep(frequency, duration);
        }
    }
}
