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

	

		

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {
			var count = passwordEvalBox.Text.Count();
			
			theTransform.X = Math.Min(count * 10, 290);

			if (count > 8)
			{
				messageTextBlock.Text = "Weak";
			}
			if (count >12)
			{
				messageTextBlock.Text = "Good";
			}
			if (count > 20)
			{
				messageTextBlock.Text = "Strong";
			}

			if (count > 28)
			{
				messageTextBlock.Text = "Very Strong";
			}
		}
	}
}
