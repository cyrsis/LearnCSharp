using System.Windows;

using WPFComponents;

namespace WPFBusinessSamples
{
  /// <summary>
  /// Interaction logic for winAddress.xaml
  /// </summary>
  public partial class winAddress : Window
  {
    public winAddress()
    {
      InitializeComponent();
    }

    private void btnGetData_Click(object sender, RoutedEventArgs e)
    {
      Address addr = (Address)ucAddr.DataContext;

      MessageBox.Show(addr.GetAddress());
    }

    private void btnSetData_Click(object sender, RoutedEventArgs e)
    {
      Address addr = new Address();

      addr.State = "CA";
      addr.Street1 = "1 Main Street";
      addr.City = "Tustin";
      addr.PostalCode = "92999";

      ucAddr.DataContext = addr;
    }
  }
}
