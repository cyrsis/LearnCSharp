using System.Windows;
using System.Windows.Controls;

namespace WPFTemplateApp
{
  public partial class ucProductList : UserControl
  {
    ProductViewModel _ViewModel;

    #region Constructor / Initialize View Model
    public ucProductList()
    {
      InitializeComponent();

      // Initialize the View Model
      _ViewModel = (ProductViewModel)this.FindResource("viewModel");

      // For some reason, the ListView is not Selected, so Select it
      lstData.SelectedIndex = 0;
    }
    #endregion

    #region Add Event
    private void btnAdd_Click(object sender, RoutedEventArgs e)
    {
      // Create blank Object and Put UI into Add Mode
      _ViewModel.AddRecord();

      // Display the Edit Window
      winProductListDetail win = new winProductListDetail();
      win.DataContext = _ViewModel;
      win.ShowDialog();
    }
    #endregion

    #region Delete Event
    private void btnDelete_Click(object sender, RoutedEventArgs e)
    {
      // Need to move ListView to Selected Item
      lstData.SelectedItem = ((Button)sender).DataContext;

      // Delete the Current Item
      _ViewModel.DeleteData();
    }
    #endregion

    #region Edit Click Event
    private void btnEdit_Click(object sender, RoutedEventArgs e)
    {
      // Need to move ListView to Selected Item
      lstData.SelectedItem = ((Button)sender).DataContext;

      // Display the Edit Window
      winProductListDetail win = new winProductListDetail();
      win.DataContext = _ViewModel;
      win.ShowDialog();
    }
    #endregion
  }
}