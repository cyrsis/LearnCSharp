using System.Windows;

namespace DemoWpfApplication
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel
                               {
                                   FirstName = "Robert",
                                   LastName = "Smith"
                               };

        }
    }
}
