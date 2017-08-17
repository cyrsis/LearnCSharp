using System.Windows;

namespace WPFBusinessSamples
{
  /// <summary>
  /// Interaction logic for winMain.xaml
  /// </summary>
  public partial class winMain : Window
  {
    public winMain()
    {
      InitializeComponent();
    }

    private void btnMenus_Click(object sender, RoutedEventArgs e)
    {
      winMenus win = new winMenus();

      win.Show();
    }

    private void btnAbout_Click(object sender, RoutedEventArgs e)
    {
      winAbout win = new winAbout();

      win.Show();
    }

    private void btnLogin_Click(object sender, RoutedEventArgs e)
    {
      winLogin win = new winLogin();

      win.Owner = this;
      win.ShowDialog();
      if (win.DialogResult.HasValue && win.DialogResult.Value)
        MessageBox.Show("User Logged In");
      else
        MessageBox.Show("User Clicked Cancel");
    }

    private void btnToolbar_Click(object sender, RoutedEventArgs e)
    {
      winToolbar win = new winToolbar();

      win.Show();
    }

    private void btnStatusbar_Click(object sender, RoutedEventArgs e)
    {
      winStatusBar win = new winStatusBar();

      win.Show();
    }

    private void btnStatusbarPanels_Click(object sender, RoutedEventArgs e)
    {
      winStatusBarPanels win = new winStatusBarPanels();

      win.Show();
    }

    private void btnTooltip_Click(object sender, RoutedEventArgs e)
    {
      winTooltips win = new winTooltips();

      win.Show();
    }


    private void btnHyperlink_Click(object sender, RoutedEventArgs e)
    {
      winHyperlink win = new winHyperlink();

      win.Show();
    }

    private void btnDockPanelLayout_Click(object sender, RoutedEventArgs e)
    {
      winDockPanelLayout win = new winDockPanelLayout();

      win.Show();
    }

    private void btnGridLayout_Click(object sender, RoutedEventArgs e)
    {
      winGridLayout win = new winGridLayout();

      win.Show();
    }

    private void btnGridLayout2_Click(object sender, RoutedEventArgs e)
    {
      winGridLayout2 win = new winGridLayout2();

      win.Show();
    }

    private void btnLogin2_Click(object sender, RoutedEventArgs e)
    {
      winLogin2 win = new winLogin2();

      win.Owner = this;
      win.ShowDialog();
      if (win.DialogResult.HasValue && win.DialogResult.Value)
        MessageBox.Show("User Logged In");
      else
        MessageBox.Show("User Clicked Cancel");
    }


    private void btnAddressUserControl_Click(object sender, RoutedEventArgs e)
    {
      winAddress win = new winAddress();

      win.Show();
    }

    private void btnLoadUserControl_Click(object sender, RoutedEventArgs e)
    {
      winLoadUserControl win = new winLoadUserControl();

      win.Show();
    }

    private void btnMenusOnLeft_Click(object sender, RoutedEventArgs e)
    {
      winMenuOnLeft win = new winMenuOnLeft();

      win.Show();
    }

    private void btnWinNoBorder_Click(object sender, RoutedEventArgs e)
    {
      winWindowNoBorder win = new winWindowNoBorder();

      win.Show();
    }

    private void btnWinEllipse_Click(object sender, RoutedEventArgs e)
    {
      winWindowEllipse win = new winWindowEllipse();

      win.Show();
    }
  }
}