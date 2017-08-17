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

namespace BindingProperties
{
    /// <summary>
    /// Interaction logic for MyCustomControl.xaml
    /// </summary>
    public partial class MyCustomControl : UserControl
    {
        public MyCustomControl()
        {
            InitializeComponent();
            TheContent.MouseDown += ChangeIt;
        }

        void ChangeIt(object sender, MouseButtonEventArgs e)
        {
            MyBackground = new SolidColorBrush(Colors.Red);
        }

        public Brush MyBackground
        {
            get { return (Brush)GetValue(MyBackgroundProperty); }
            set { SetValue(MyBackgroundProperty, value); }
        }

        public static readonly DependencyProperty MyBackgroundProperty =
            DependencyProperty.Register("MyBackground", typeof(Brush), 
            typeof(MyCustomControl), 
            new FrameworkPropertyMetadata(new SolidColorBrush(Colors.Gray),
                FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, 
                OnBrushChanged));
   
        private static void OnBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((MyCustomControl)d).TheContent.Fill = e.NewValue as Brush;
        }


    }
}
