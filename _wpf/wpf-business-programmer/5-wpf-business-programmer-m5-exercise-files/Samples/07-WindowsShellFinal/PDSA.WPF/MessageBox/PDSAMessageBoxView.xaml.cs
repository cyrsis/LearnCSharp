using System;
using System.Windows;
using System.Windows.Input;

namespace PDSA.WPF
{
  public partial class PDSAMessageBoxView : Window
  {
    public PDSAMessageBoxView()
    {
      InitializeComponent();
    }

    #region Private Variables
    private MessageBoxButton _Buttons = MessageBoxButton.OK;
    private MessageBoxResult _Result = MessageBoxResult.None;
    #endregion

    #region internal Properties
    internal MessageBoxButton Buttons
    {
      get { return _Buttons; }
      set
      {
        _Buttons = value;
        // Set all Buttons Visibility Properties
        SetButtonsVisibility();
      }
    }

    internal MessageBoxResult Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    #endregion

    #region SetButtonsVisibility Method
    internal void SetButtonsVisibility()
    {
      switch (_Buttons)
      {
        case MessageBoxButton.OK:
          btnOk.Visibility = Visibility.Visible;
          btnCancel.Visibility = Visibility.Collapsed;
          btnYes.Visibility = Visibility.Collapsed;
          btnNo.Visibility = Visibility.Collapsed;
          break;
        case MessageBoxButton.OKCancel:
          btnOk.Visibility = Visibility.Visible;
          btnCancel.Visibility = Visibility.Visible;
          btnYes.Visibility = Visibility.Collapsed;
          btnNo.Visibility = Visibility.Collapsed;
          break;
        case MessageBoxButton.YesNo:
          btnOk.Visibility = Visibility.Collapsed;
          btnCancel.Visibility = Visibility.Collapsed;
          btnYes.Visibility = Visibility.Visible;
          btnNo.Visibility = Visibility.Visible;
          break;
        case MessageBoxButton.YesNoCancel:
          btnOk.Visibility = Visibility.Collapsed;
          btnCancel.Visibility = Visibility.Visible;
          btnYes.Visibility = Visibility.Visible;
          btnNo.Visibility = Visibility.Visible;
          break;
      }
    }
    #endregion

    private void btnYes_Click(object sender, RoutedEventArgs e)
    {
      Result = MessageBoxResult.Yes;
      this.Close();
    }

    private void btnNo_Click(object sender, RoutedEventArgs e)
    {
      Result = MessageBoxResult.No;
      this.Close();
    }

    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
      Result = MessageBoxResult.Cancel;
      this.Close();
    }

    private void btnOk_Click(object sender, RoutedEventArgs e)
    {
      Result = MessageBoxResult.OK;
      this.Close();
    }

    #region Windows Drag Event
    private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      if (e.ButtonState == MouseButtonState.Pressed)
        this.DragMove();
    }
    #endregion

    #region Deactivated Event
    private void Window_Deactivated(object sender, EventArgs e)
    {
      // If only an OK button is displayed, 
      // allow the user to just move away from this dialog box
      if (Buttons == MessageBoxButton.OK)
        this.Close();
    }
    #endregion

    #region KeyUp Event
    private void Window_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.Key == Key.Y && (Buttons == MessageBoxButton.YesNo || Buttons == MessageBoxButton.YesNoCancel))
        btnYes_Click(this, new RoutedEventArgs());
      else if (e.Key == Key.N && (Buttons == MessageBoxButton.YesNo || Buttons == MessageBoxButton.YesNoCancel))
        btnNo_Click(this, new RoutedEventArgs());
      else if (e.Key == Key.O && (Buttons == MessageBoxButton.OK || Buttons == MessageBoxButton.OKCancel))
        btnOk_Click(this, new RoutedEventArgs());
      else if (e.Key == Key.C && (Buttons == MessageBoxButton.OK || Buttons == MessageBoxButton.OKCancel))
        btnCancel_Click(this, new RoutedEventArgs());
    }
    #endregion
  }
}
