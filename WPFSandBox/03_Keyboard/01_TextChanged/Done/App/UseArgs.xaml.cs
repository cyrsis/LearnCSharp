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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CoursewareApp {
	/// <summary>
	/// Interaction logic for UseArgs.xaml
	/// </summary>
	public partial class UseArgs : Window {
		public UseArgs() {
			InitializeComponent();
			//this.DataContext = _additions;
		}
		private ObservableCollection<TextChange> _additions = new ObservableCollection<TextChange>();
		private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {
			var fullText = (sender as TextBox).Text;
			if (e.Changes.Any())
			{

				addedTextBlock.Text = (e.Changes.Last().AddedLength.ToString());

				offsetTextBlock.Text = (e.Changes.Last().Offset.ToString());

				removedTextBlock.Text = (e.Changes.Last().RemovedLength.ToString());
				//e.Changes.Where(x => x.AddedLength > 0).ToList();
				//	var newTexts = _additions.Select(x => fullText.Substring(x.Offset, x.AddedLength));


			}
			
		}
	}
}
