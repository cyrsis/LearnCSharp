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

namespace CoursewareApp {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
			this.Loaded += MainWindow_Loaded;
		}

		private void MainWindow_Loaded(object sender, RoutedEventArgs e) {
			Rectangle r;
			for (int i = 0; i < 255; i++)
			{
				r = new Rectangle();
				r.Fill = new SolidColorBrush(Color.FromRgb((byte)i, (byte)128, (byte)180));
				r.StrokeThickness = 2;
				r.Stroke = new SolidColorBrush(Colors.DarkGray);
				r.Width = 80;
				r.Height = 60;
				fishEyePanel01.Children.Add(r);
			}
		}
	}
}
