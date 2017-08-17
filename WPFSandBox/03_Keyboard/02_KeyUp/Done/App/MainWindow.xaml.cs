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

		private void TextBox_KeyUp(object sender, KeyEventArgs e) {

			// check for a Textual key
			if (e.Key == Key.S)
			{
				resultTextBlock.Text = "Pressed the 'S' key";
			}
			else
			{
				resultTextBlock.Text = e.Key.ToString();
			}
		}
		private void text2_KeyUp(object sender, KeyEventArgs e) {
			resultTextBlock.Text = "";
			// check for an Action key
			if (e.Key == Key.Escape)
			{

				resultTextBlock.Text = "Pressed the Escape Key";
			}
			else if (e.Key == Key.Home)
			{

				resultTextBlock.Text = "Pressed the Home Key";
			}
			else
			{
				resultTextBlock.Text = e.Key.ToString();
			}
		}

		private void text3_KeyUp(object sender, KeyEventArgs e) {
			// check the Caps Lock or other 'toggled key'
			if (e.IsToggled & e.Key == Key.CapsLock)
			{
				resultTextBlock.Text = "CapsLock is on";
			}
			else
			{
				resultTextBlock.Text = "CapsLock is off";
			}

		}

		private void text4_KeyUp(object sender, KeyEventArgs e) {
			// note: testing for the modifier keys assumes that it is pressed with another key
			if ((e.KeyboardDevice.Modifiers & ModifierKeys.Shift) == ModifierKeys.Shift)
			{
				resultTextBlock.Text = "Pressed the Shift Key";
			}
			if ((e.KeyboardDevice.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
			{
				resultTextBlock.Text = "Pressed the Control Key";
			}
			else
			{
				resultTextBlock.Text = e.Key.ToString();
			}
		}
    
		

		private void clearButton_Click(object sender, System.Windows.RoutedEventArgs e) {
			enteredTextBlock.Text = "";
		}
	}
}
