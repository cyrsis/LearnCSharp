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


			mainInk.DefaultDrawingAttributes = _standardInk;

		

		}


		private DrawingAttributes _standardInk;
	
		private void SizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {


		}

		private void mainInk_Gesture(object sender, InkCanvasGestureEventArgs e) {
			ReadOnlyCollection<GestureRecognitionResult> gestures = e.GetGestureRecognitionResults();
			foreach (GestureRecognitionResult g in gestures)
			{

				gestureResultTextBlock.Text = g.ApplicationGesture.ToString();
				confidenceResultTextBlock.Text = g.RecognitionConfidence.ToString();

				if (g.ApplicationGesture == ApplicationGesture.Left && g.RecognitionConfidence == RecognitionConfidence.Strong)
				{
					translateTransform.X -= 10;
				}

				if (g.ApplicationGesture == ApplicationGesture.Right && g.RecognitionConfidence == RecognitionConfidence.Strong)
				{
					translateTransform.X += 10;
				}

				if (g.ApplicationGesture == ApplicationGesture.Up && g.RecognitionConfidence == RecognitionConfidence.Strong)
				{
					translateTransform.Y -= 10;
				}

				if (g.ApplicationGesture == ApplicationGesture.Down && g.RecognitionConfidence == RecognitionConfidence.Strong)
				{
					translateTransform.Y += 10;
				}

				if (g.ApplicationGesture == ApplicationGesture.ChevronUp && g.RecognitionConfidence == RecognitionConfidence.Strong)
				{
					scaleTransform.ScaleY = scaleTransform.ScaleX += .2;
				}
				if (g.ApplicationGesture == ApplicationGesture.ChevronDown && g.RecognitionConfidence == RecognitionConfidence.Strong)
				{
					scaleTransform.ScaleY = scaleTransform.ScaleX -= .2;
				}
			}
		

		}
	}
}
