using System.Windows;
using System.Windows.Controls;

namespace TextBoxSpellCheck
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            // Xaml:
            //   <TextBox Width="300" SpellCheck.IsEnabled="True" />

            //myTextBox.SpellCheck.IsEnabled = true;

            SpellCheck.SetIsEnabled(myTextBox, true);
        }
    }
}
