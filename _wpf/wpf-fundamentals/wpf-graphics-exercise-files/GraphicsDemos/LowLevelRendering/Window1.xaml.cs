using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace LowLevelRendering
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            rootPanel.MouseDown += new MouseButtonEventHandler(rootPanel_MouseDown);
        }

        void rootPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            rootPanel.RenderTransform = new ScaleTransform(6, 6);
        }
    }
}
