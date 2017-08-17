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

	
		private void All_KeyDown(object sender, KeyEventArgs e) {
			resultsListBox.Items.Add(string.Format ($"KeyDown: {e.Key.ToString(),9}"));
		}

		private void All_KeyUp(object sender, KeyEventArgs e) {

			resultsListBox.Items.Add(string.Format($"KeyUp: {e.Key.ToString(),14}"));


		}

		
		

		private void Button_Click(object sender, RoutedEventArgs e) {
			resultsListBox.Items.Clear();
		}
    
		private void TextBox2_PreviewTextInput(object sender, TextCompositionEventArgs e) {

			// use TextInput/PreviewTextInput to react to text input whether from keyboard, 
			// or voice or handwriting recognition. 
			// In languages that support multiple key sequences that produce a single text character
			// TextInput fires when the key sequence is done!
			if (!string.IsNullOrEmpty(e.Text))
			{
				e.Handled = Char.IsPunctuation(e.Text[0]);
			}

		}

		private void TextBox3_PreviewTextInput(object sender, TextCompositionEventArgs e) {
			if (!string.IsNullOrEmpty(e.Text))
			{
				e.Handled = !Char.IsNumber(e.Text[0]);
			}
		}
	}
}
