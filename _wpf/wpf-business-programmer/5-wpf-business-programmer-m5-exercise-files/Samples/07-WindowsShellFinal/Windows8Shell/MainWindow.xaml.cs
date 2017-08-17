using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Effects;
using System.Windows.Threading;

using PDSA.MessageBroker;
using PDSA.WPF;

namespace Windows8Shell
{
  public partial class MainWindow : Window
  {
    #region Private Variables
    // Constant to control how much to scroll the tiles left and right
    private const double OFFSET = 1.15;

    // The following variables are used to maintain the state of the 
    // old values of the Margin and BorderEffect on the main window.
    // When you maximize the window you want these to be set to nothing
    // and then reset when the user goes back to normal window size.
    private Thickness _MainBorderMargin = new Thickness();
    private Effect _MainBorderEffect = null;

    // The timer is for showing the scrollbar only after the user pauses over the
    // content area for the specified amount of time
    private DispatcherTimer _Timer = new DispatcherTimer();
    #endregion

    #region Constructor
    public MainWindow()
    {
      InitializeComponent();
    }
    #endregion

    #region Window Loaded Event
    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      // Hook to the central message broker
      (Application.Current as App).MessageBroker.MessageReceived +=
        new MessageReceivedEventHandler(MessageBroker_MessageReceived);

      // Set the Interval to 1.5 seconds
      _Timer.Interval = TimeSpan.FromMilliseconds(1500);

      // Setup Timer for Showing Scroll bar
      _Timer.Tick += new EventHandler(_Timer_Tick);
    }
    #endregion

    #region Message Broker Event
    void MessageBroker_MessageReceived(object sender, PDSAMessageBrokerEventArgs e)
    {
      switch (e.MessageName)
      {
        case "ProductView":
          SetMainPageControls(false);
          LoadUserControl(new ucProductView());
          break;

        case "Editing":
          SetEditMode(true);
          break;

        case "Normal":
          SetEditMode(false);
          break;

        default:
          break;
      }
    }
    #endregion

    #region LoadUserControl
    private void LoadUserControl(UserControl ctl)
    {
      contentArea.Children.Clear();
      contentArea.Children.Add(ctl);
    }
    #endregion

    #region SetMainPageControls Method
    private void SetMainPageControls(bool isStartPage)
    {
      if (isStartPage)
      {
        // Unload previous user control
        contentArea.Children.Clear();
        btnBack.Visibility = Visibility.Hidden;
        btnLeft.Visibility = Visibility.Visible;
        btnRight.Visibility = Visibility.Visible;
        scrollTiles.Visibility = Visibility.Visible;
        contentArea.Visibility = Visibility.Hidden;
      }
      else
      {
        btnBack.Visibility = Visibility.Visible;
        btnLeft.Visibility = Visibility.Hidden;
        btnRight.Visibility = Visibility.Hidden;
        scrollTiles.Visibility = Visibility.Hidden;
        contentArea.Visibility = Visibility.Visible;
      }
    }
    #endregion

    #region SetEditMode Method
    private void SetEditMode(bool isEditMode)
    {
      if (isEditMode)
      {
        btnBack.IsEnabled = false;
        btnLeft.IsEnabled = false;
        btnRight.IsEnabled = false;
        btnMinimize.IsEnabled = false;
        btnMaximize.IsEnabled = false;
        btnClose.IsEnabled = false;
      }
      else
      {
        btnBack.IsEnabled = true;
        btnLeft.IsEnabled = true;
        btnRight.IsEnabled = true;
        btnMinimize.IsEnabled = true;
        btnMaximize.IsEnabled = true;
        btnClose.IsEnabled = true;
      }
    }
    #endregion

    #region Back Button Event
    private void btnBack_Click(object sender, RoutedEventArgs e)
    {
      SetMainPageControls(true);
    }
    #endregion

    #region Minimize Button
    private void btnMinimize_Click(object sender, RoutedEventArgs e)
    {
      this.WindowState = WindowState.Minimized;
    }
    #endregion

    #region Maximize Button
    private void btnMaximize_Click(object sender, RoutedEventArgs e)
    {
      ToggleWindowState();
    }
    #endregion

    #region Close Button
    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
      if (PDSAMessageBox.Show("Close this application?", "Close", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
        this.Close();
    }
    #endregion

    #region Window Double Click Event
    private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
      ToggleWindowState();
    }
    #endregion

    #region ToggleWindowState Method
    private void ToggleWindowState()
    {
      if (this.WindowState == WindowState.Normal)
      {
        _MainBorderEffect = brdMain.Effect;
        _MainBorderMargin = brdMain.Margin;
        brdMain.Effect = null;
        brdMain.Margin = new Thickness(0, 0, 0, 0);
        btnMaximize.ToolTip = "Restore Down";
        this.WindowState = WindowState.Maximized;
      }
      else
      {
        brdMain.Effect = _MainBorderEffect;
        brdMain.Margin = _MainBorderMargin;
        btnMaximize.ToolTip = "Maximize";
        this.WindowState = WindowState.Normal;
      }
    }
    #endregion

    #region Scroll Left/Right Button Click Events
    private void btnRight_Click(object sender, RoutedEventArgs e)
    {
      // Scroll right by using the current horizontal offset 
      // and adding 15% of the width
      scrollTiles.ScrollToHorizontalOffset(
        scrollTiles.HorizontalOffset +
        (scrollTiles.ActualWidth * OFFSET));
    }

    private void btnLeft_Click(object sender, RoutedEventArgs e)
    {
      // Scroll left by using the current horizontal offset 
      // and subtracting 15% of the width
      scrollTiles.ScrollToHorizontalOffset(
        scrollTiles.HorizontalOffset -
        (scrollTiles.ActualWidth * OFFSET));
    }
    #endregion

    #region Windows MouseLeftButtonDown Event
    private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      if (e.ButtonState == MouseButtonState.Pressed)
        this.DragMove();
    }
    #endregion

    #region Scrollbar Visibility Methods/Events
    private void scrollTiles_MouseEnter(object sender, MouseEventArgs e)
    {
      _Timer.Start();
    }

    void _Timer_Tick(object sender, EventArgs e)
    {
      scrollTiles.HorizontalScrollBarVisibility = ScrollBarVisibility.Visible;

      _Timer.Stop();
    }

    private void scrollTiles_MouseLeave(object sender, MouseEventArgs e)
    {
      _Timer.Stop();

      scrollTiles.HorizontalScrollBarVisibility = ScrollBarVisibility.Hidden;
    }
    #endregion

    #region Window Unloaded Event
    private void Window_Unloaded(object sender, RoutedEventArgs e)
    {
      // Remove Timer 'Tick' Event Handler for Showing Scroll bar
      _Timer.Tick -= _Timer_Tick;
      // Remove Message Broker 'MessageReceived' Event Handler
      (Application.Current as App).MessageBroker.MessageReceived -=
        MessageBroker_MessageReceived;
    }
    #endregion
  }
}
