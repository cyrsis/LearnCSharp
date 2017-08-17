using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using PDSA.MessageBroker;
using PDSA.WPF;

namespace Windows8Shell
{
  public partial class ucProductView : UserControl
  {
    #region Constructor
    public ucProductView()
    {
      InitializeComponent();

      _ViewModel = (ProductViewModel)this.Resources["viewModel"];
    }
    #endregion

    #region Private Variables
    ProductViewModel _ViewModel = null;
    #endregion

    #region UserControl Loaded Event Procedure
    private void UserControl_Loaded(object sender, RoutedEventArgs e)
    {
      _ViewModel.LoadAll();      
    }
    #endregion

    #region lstData SelectionChanged Event
    private void lstData_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      // Clone current record in case we edit and need to cancel
      _ViewModel.CloneCurrent();
    }
    #endregion

    #region Edit Click Event
    private void btnEdit_Click(object sender, RoutedEventArgs e)
    {
      // Display the current Record
      // Clicking on the Edit button does not change the 
      // Selected Item of the list box, so we need to do that
      lstData.SelectedItem = ((PDSAucButtonImageText)sender).DataContext;

      // Send 'Editing' Message
      SendMessage("Editing");

      _ViewModel.EditData();
    }
    #endregion

    #region Delete Click Event
    private void btnDelete_Click(object sender, RoutedEventArgs e)
    {
      // Display the current Record
      // Clicking on the Delete button does not change the 
      // Selected Item of the list box, so we need to do that
      lstData.SelectedItem = ((PDSAucButtonImageText)sender).DataContext;

      if (PDSAMessageBox.Show("Delete This Product?", "Delete?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
        _ViewModel.Delete();
    }
    #endregion

    #region Add Click Event
    private void btnAdd_Click(object sender, RoutedEventArgs e)
    {
      _ViewModel.AddData();
    }
    #endregion

    #region Save Click Event
    private void btnSave_Click(object sender, RoutedEventArgs e)
    {
      _ViewModel.Save();

      // Send 'Normal' Message out
      SendMessage("Normal");
    }
    #endregion

    #region Cancel Click Event
    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
      _ViewModel.CancelEdit();

      // Send 'Normal' Message out
      SendMessage("Normal");
    }
    #endregion

    #region TextHasChanged Event
    private void TextHasChanged(object sender, TextChangedEventArgs e)
    {
      // Only Change Mode if Element has Keyboard Focus
      if (((UIElement)sender).IsKeyboardFocused)
        if (!_ViewModel.IsSaveEnabled)
          _ViewModel.SetUIState(PDSA.Common.PDSAEditUIState.Edit);
    }
    #endregion

    #region SendMessage Method
    private void SendMessage(string message)
    {
      // Send 'Normal' Message out
      (Application.Current as App).MessageBroker.SendMessage(
        new PDSAMessageBrokerMessage(message, null));
    }
    #endregion
  }
}
