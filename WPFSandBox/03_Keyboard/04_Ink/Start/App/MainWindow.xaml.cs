using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
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
			_standardInk = new DrawingAttributes();
			_standardInk.Color = Colors.Orange;
			_standardInk.StylusTip = StylusTip.Ellipse;
			_standardInk.Height = 2;
			_standardInk.Width = 4;
			_standardInk.FitToCurve = false;

			_highlightInk = new DrawingAttributes();
			_highlightInk.Color = Colors.SpringGreen;
			_highlightInk.IsHighlighter = true;
			_highlightInk.IgnorePressure = true;
			_highlightInk.StylusTip = StylusTip.Rectangle;
			_highlightInk.Height = 24;
			_highlightInk.Width = 8;

			mainInk.DefaultDrawingAttributes = _standardInk;

			this.Loaded += MainWindow_Loaded;

		}

		private void MainWindow_Loaded(object sender, RoutedEventArgs e) {
			InkRadio.Checked += InkRadio_Checked; ;
			HighlightRadio.Checked += HighlightRadio_Checked; ;
		}

		private void HighlightRadio_Checked(object sender, RoutedEventArgs e) {
			mainInk.DefaultDrawingAttributes = _highlightInk;
		}

		private void InkRadio_Checked(object sender, RoutedEventArgs e) {

			mainInk.DefaultDrawingAttributes = _standardInk;
		}

		private DrawingAttributes _standardInk;
		private DrawingAttributes _highlightInk;
		private void SizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {


		}

		
	}
}
