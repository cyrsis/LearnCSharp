using System.Windows;
using System.Windows.Controls;

namespace WPFTemplateApp
{
  /// <summary>
  /// Interaction logic for winProductListDetail.xaml
  /// </summary>
  public partial class winProductListDetail : Window
  {
    public winProductListDetail()
    {
      InitializeComponent();
    }

    #region Cancel Event
    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
      // Cancel the Edit
      ((ProductViewModel)this.DataContext).CancelEdit();
      this.Close();
    }
    #endregion

    #region Save Event
    private void btnSave_Click(object sender, RoutedEventArgs e)
    {
      // Save the Current Item
      ((ProductViewModel)this.DataContext).SaveData();
      this.Close();
    }
    #endregion

    #region Data Has Changed Methods
    private void TextHasChanged(object sender, TextChangedEventArgs e)
    {
      // Only Change Mode if Element has Keyboard Focus
      if (((UIElement)sender).IsKeyboardFocused)
        ((ProductViewModel)this.DataContext).SetViewStateMode(UIStateMode.Edit);
    }

    private void CheckedHasChanged(object sender, RoutedEventArgs e)
    {
      if (((UIElement)sender).IsKeyboardFocused || ((UIElement)sender).IsMouseDirectlyOver)
        ((ProductViewModel)this.DataContext).SetViewStateMode(UIStateMode.Edit);
    }
    #endregion
  }
}
