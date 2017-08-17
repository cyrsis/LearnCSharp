using System.Windows;
using System.Windows.Controls;

namespace WPFTemplateApp
{
  public partial class ucProductWithImages : UserControl
  {
    ProductViewModel _ViewModel;

    #region Constructor / Initialize View Model
    public ucProductWithImages()
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

    #region Cancel Event
    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
      // Cancel the Edit
      _ViewModel.CancelEdit();
      lstData.SelectedIndex = 0;
    }
    #endregion

    #region Save Event
    private void btnSave_Click(object sender, RoutedEventArgs e)
    {
      // Save the Current Item
      _ViewModel.SaveData();
    }
    #endregion

    #region Data Has Changed Methods
    private void TextHasChanged(object sender, TextChangedEventArgs e)
    {
      // Only Change Mode if Element has Keyboard Focus
      if (((UIElement)sender).IsKeyboardFocused)
        _ViewModel.SetViewStateMode(UIStateMode.Edit);
    }

    private void CheckedHasChanged(object sender, RoutedEventArgs e)
    {
      if (((UIElement)sender).IsKeyboardFocused || ((UIElement)sender).IsMouseDirectlyOver)
        _ViewModel.SetViewStateMode(UIStateMode.Edit);
    }
    #endregion
  }
}