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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CoursewareApp {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
			
		}

	

		
		private double _opacityDelta =1;
		private void Grid_MouseWheel(object sender, MouseWheelEventArgs e) {
			if (e.Delta > 0)
			{
				_opacityDelta = Math.Min(1.0, _opacityDelta + .02);
			}
			else
			{
				_opacityDelta = Math.Max(0, _opacityDelta - .02);
			}
			pretzelImage.Opacity = _opacityDelta;
			pastryImage.Opacity = 1 - _opacityDelta;
			messageText.Text = _opacityDelta.ToString("F");
		}
	}
}
