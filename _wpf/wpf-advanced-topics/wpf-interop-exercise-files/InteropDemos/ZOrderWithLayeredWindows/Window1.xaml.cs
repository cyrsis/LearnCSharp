using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZOrderWithLayeredWindows
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        OnTop topLayer = new OnTop();
        public Window1()
        {
            InitializeComponent();

            this.ContentRendered += new EventHandler(Window1_ContentRendered);
            this.LocationChanged += new EventHandler(Window1_LocationChanged);
        }

        void Window1_ContentRendered(object sender, EventArgs e)
        {
            topLayer.Owner = this;
            SetLocation();
            topLayer.Show();

            this.MaxWidth = this.ActualWidth;
            this.MaxHeight = this.ActualHeight;
        }

        void Window1_LocationChanged(object sender, EventArgs e)
        {
            SetLocation();
        }

        private void SetLocation()
        {
            topLayer.Top = this.Top + SystemParameters.WindowCaptionHeight;
            topLayer.Left = this.Left;
        }

    }
}
