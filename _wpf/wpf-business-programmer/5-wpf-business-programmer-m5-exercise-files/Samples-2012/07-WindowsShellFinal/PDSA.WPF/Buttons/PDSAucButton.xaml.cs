using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace PDSA.WPF
{
  [DefaultEvent("Click")]
  public partial class PDSAucButton : UserControl
  {
    public PDSAucButton()
    {
      InitializeComponent();

      this.DataContext = this;
    }

    #region Private Variables
    private Brush _TextBrush;
    #endregion

    #region Text Property
    public string Text
    {
      get { return (string)GetValue(TextProperty); }
      set { SetValue(TextProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register("Text", typeof(string), typeof(PDSAucButton), null);
    #endregion

    #region Mouse Events
    // NOTE: You must use the FindResource() method and not the Resources[] collection
    // because we are using Dynamic styles that may be set at the application level
    private void pdsaButtonBorderStyle_MouseEnter(object sender, MouseEventArgs e)
    {
      pdsaButtonBorderStyle.Background = (Brush)this.FindResource("pdsaButtonOverStyle");
    }

    private void pdsaButtonBorderStyle_MouseLeave(object sender, MouseEventArgs e)
    {
      pdsaButtonBorderStyle.Background = (Brush)this.FindResource("pdsaButtonNormalStyle");
    }

    private void pdsaButtonBorderStyle_MouseDown(object sender, MouseButtonEventArgs e)
    {
      // Save old Foreground Brush
      _TextBrush = tbText.Foreground;

      pdsaButtonBorderStyle.Background = (Brush)this.FindResource("pdsaButtonPressedStyle");
      tbText.Foreground = (SolidColorBrush)this.FindResource("pdsaButtonTextBlockStylePressed");

      RaiseClick(e);
    }

    private void pdsaButtonBorderStyle_MouseUp(object sender, MouseButtonEventArgs e)
    {
      RestoreNormal();
    }

    private void RestoreNormal()
    {
      pdsaButtonBorderStyle.Background = (Brush)this.FindResource("pdsaButtonNormalStyle");

      tbText.Foreground = _TextBrush;
    }
    #endregion

    #region Click Event Procedure
    public delegate void ClickEventHandler(object sender, RoutedEventArgs e);
    public event ClickEventHandler Click;

    protected void RaiseClick(RoutedEventArgs e)
    {
      if (null != Click)
        Click(this, e);

      RestoreNormal();
    }
    #endregion
  }
}
