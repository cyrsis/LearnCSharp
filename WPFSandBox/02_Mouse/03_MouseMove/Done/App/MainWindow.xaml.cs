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

	

		
		
		
		

		private void Grid_MouseMove(object sender, MouseEventArgs e) {
			// get the current mouse position, relative to an element.

			var position = e.GetPosition(innerGrid);
			line1.X2 = position.X;
			line1.Y2 = position.Y;

			line2.X2 = position.X;
			line2.Y2 = position.Y;

			line3.X2 = position.X;
			line3.Y2 = position.Y;

			line4.X2 = position.X;
			line4.Y2 = position.Y;

			line5.X2 = position.X;
			line5.Y2 = position.Y;

			line6.X2 = position.X;
			line6.Y2 = position.Y;

			ellipse1.Margin = new Thickness(position.X -10, position.Y-10, 0,0);
			



		}
	}
}
