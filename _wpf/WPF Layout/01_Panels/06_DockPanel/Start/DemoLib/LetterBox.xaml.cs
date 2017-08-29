using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DemoLib {


	public partial class LetterBox : UserControl {

		public LetterBox() {
			InitializeComponent();
			this.ToolTipOpening += LetterBox_ToolTipOpening;
		}

		private void LetterBox_ToolTipOpening(object sender, ToolTipEventArgs e) {
			this.ToolTip = string.Format($"Width: {this.ActualWidth}, Height: {this.ActualHeight}");
		}

		#region Letter

		private static FrameworkPropertyMetadataOptions flags = FrameworkPropertyMetadataOptions.AffectsRender;

		/// <summary>
		/// Letter Dependency Property
		/// </summary>
		public static readonly DependencyProperty LetterProperty =
				DependencyProperty.Register("Letter", typeof(char), typeof(LetterBox),
						new FrameworkPropertyMetadata(defaultValue: (char)'A',
							propertyChangedCallback: new PropertyChangedCallback(OnLetterChanged),
							flags: flags));

		/// <summary>
		/// Gets or sets the Letter property. This dependency property
		/// indicates what character to show.
		/// </summary>
		public char Letter {
			get { return (char)GetValue(LetterProperty); }
			set { SetValue(LetterProperty, value); }
		}

		/// <summary>
		/// Handles changes to the Letter property.
		/// </summary>
		private static void OnLetterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
			LetterBox target = (LetterBox)d;
			char oldLetter = (char)e.OldValue;
			char newLetter = target.Letter;
			target.OnLetterChanged(oldLetter, newLetter);
		}

		/// <summary>
		/// Provides derived classes an opportunity to handle changes to the Letter property.
		/// </summary>
		protected virtual void OnLetterChanged(char oldLetter, char newLetter) {
			aBox.Text = newLetter.ToString();
			switch (newLetter)
			{
				case 'a':
				case 'A':

					this.Background = new SolidColorBrush(Colors.LightBlue);
					//FF4BA9C8
					mainBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0x4B),
																																		 Convert.ToByte(0xA9),
																																		 Convert.ToByte(0xC8)));
					break;

				case 'b':
				case 'B':
					//# FFADE6D8
					this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0xAD),
																																		 Convert.ToByte(0xE6),
																																		 Convert.ToByte(0xD8)));
					//#53CBAD
					mainBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0x53),
																																		 Convert.ToByte(0xCB),
																																		 Convert.ToByte(0xAD)));
					break;

				case 'c':
				case 'C':
					// #ADC1E6
					this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0xAD),
																																		 Convert.ToByte(0xC1),
																																		 Convert.ToByte(0xE6)));
					// #6A8FD2
					mainBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0x6A),
																																		 Convert.ToByte(0x8F),
																																		 Convert.ToByte(0xD2)));
					break;

				case 'd':
				case 'D':
					// #C4ADE6
					this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0xC4),
																																		 Convert.ToByte(0xAD),
																																		 Convert.ToByte(0xE6)));
					// #9F7AD6
					mainBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0x7F),
																																		 Convert.ToByte(0x7A),
																																		 Convert.ToByte(0xD6)));
					break;

				case 'e':
				case 'E':
					// mainImage.Source = new BitmapImage(new Uri("images/E.png", UriKind.RelativeOrAbsolute));
					// #DDADE6
					this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0xDD),
																															Convert.ToByte(0xAD),
																															Convert.ToByte(0xE6)));
					// #C16AD2
					mainBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0xC1),
																																		 Convert.ToByte(0x6A),
																																		 Convert.ToByte(0xD2)));
					break;

				case 'f':
				case 'F':
					// #E6ADC4
					this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0xE6),
																															Convert.ToByte(0xAD),
																															Convert.ToByte(0xC4)));
					// #D26A94
					mainBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0xD2),
																																		 Convert.ToByte(0x6A),
																																		 Convert.ToByte(0x94)));
					break;

				case 'g':
				case 'G':
					this.Background = new SolidColorBrush(Colors.LightBlue);
					//FF4BA9C8
					mainBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0x4B),
																																		 Convert.ToByte(0xA9),
																																		 Convert.ToByte(0xC8)));
					break;

				case 'h':
				case 'H':
					//# FFADE6D8
					this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0xAD),
																																		 Convert.ToByte(0xE6),
																																		 Convert.ToByte(0xD8)));
					//#53CBAD
					mainBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0x53),
																																		 Convert.ToByte(0xCB),
																																		 Convert.ToByte(0xAD)));
					break;

				case 'j':
				case 'J':
					// #ADC1E6
					this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0xAD),
																																		 Convert.ToByte(0xC1),
																																		 Convert.ToByte(0xE6)));
					// #6A8FD2
					mainBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0x6A),
																																		 Convert.ToByte(0x8F),
																																		 Convert.ToByte(0xD2)));
					break;

				case 'k':
				case 'K':
					// #C4ADE6
					this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0xC4),
																																		 Convert.ToByte(0xAD),
																																		 Convert.ToByte(0xE6)));
					// #9F7AD6
					mainBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0x7F),
																																		 Convert.ToByte(0x7A),
																																		 Convert.ToByte(0xD6)));
					break;

				case 'l':
				case 'L':
					// #DDADE6
					this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0xDD),
																															Convert.ToByte(0xAD),
																															Convert.ToByte(0xE6)));
					// #C16AD2
					mainBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0xC1),
																																		 Convert.ToByte(0x6A),
																																		 Convert.ToByte(0xD2)));
					break;

				case 'm':
				case 'M':
					// #E6ADC4
					this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0xE6),
																															Convert.ToByte(0xAD),
																															Convert.ToByte(0xC4)));
					// #D26A94
					mainBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0xD2),
																																		 Convert.ToByte(0x6A),
																																		 Convert.ToByte(0x94)));
					break;

				default:

					this.Background = new SolidColorBrush(Colors.LightBlue);
					mainBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(Convert.ToByte(0x4B),
																																		 Convert.ToByte(0xA9),
																																		 Convert.ToByte(0xC8)));
					break;
			}
		}

		#endregion Letter
	}
}