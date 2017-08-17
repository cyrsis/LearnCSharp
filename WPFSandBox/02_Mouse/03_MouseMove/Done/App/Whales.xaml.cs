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
using System.Windows.Shapes;

namespace CoursewareApp {
	/// <summary>
	/// Interaction logic for Orbs.xaml
	/// </summary>
	public partial class Whales : Window {
		public Whales() {
			InitializeComponent();

			for (int xCounter = 0; xCounter < 81; xCounter++)
			{
				var img = new Image();
					if (xCounter % 2 == 0)
					{
						img.Source = new BitmapImage(new Uri("WhaleBlue.png", UriKind.RelativeOrAbsolute));
					}
					else
					{
						img.Source = new BitmapImage(new Uri("WhaleGreen.png", UriKind.RelativeOrAbsolute));
					}
					img.Opacity = .6;
					img.Width = img.Height = 32;
					img.Stretch = Stretch.Uniform;

					img.HorizontalAlignment = HorizontalAlignment.Left;
					img.VerticalAlignment = VerticalAlignment.Top;
					//	img.LayoutTransform = new ScaleTransform();
					innerGrid.Children.Add(img);

					//Grid.SetColumn(img, xCounter);
					//Grid.SetRow(img, yCounter);

					_whales = innerGrid.Children.OfType<Image>();
				
			}
		}
		private IEnumerable<Image> _whales;
		private void Grid_MouseMove(object sender, MouseEventArgs e) {

			foreach (var whale in _whales)
			{

				var position = e.GetPosition(whale);

				whale.Width = Math.Max (32,Math.Abs(position.X * Math.Tanh(position.Y)));
				whale.Height =Math.Max(32, Math.Abs(position.Y * Math.Atan(position.X)));


			}
		}
	}
}
