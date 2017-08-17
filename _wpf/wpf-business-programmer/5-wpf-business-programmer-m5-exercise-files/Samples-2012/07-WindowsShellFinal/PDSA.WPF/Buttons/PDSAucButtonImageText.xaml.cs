using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PDSA.WPF
{
  [DefaultEvent("Click")]
  public partial class PDSAucButtonImageText : UserControl
  {
    public PDSAucButtonImageText()
    {
      InitializeComponent();

      this.DataContext = this;
    }

    #region Text Property
    public string Text
    {
      get { return (string)GetValue(TextProperty); }
      set { SetValue(TextProperty, value);
      if (string.IsNullOrEmpty(value))
        tbText.Visibility = Visibility.Collapsed;
      }
    }

    // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register("Text", typeof(string), typeof(PDSAucButtonImageText), null);
    #endregion

    #region ImageUri Property
    public Uri ImageUri
    {
      get { return (Uri)GetValue(ImageUriProperty); }
      set { SetValue(ImageUriProperty, value); }
    }

    // Using a DependencyProperty as the backing store for ImageUri.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty ImageUriProperty =
        DependencyProperty.Register("ImageUri", typeof(Uri), typeof(PDSAucButtonImageText), null);
    #endregion

    #region MouseLeftDown Event
    private void borMain_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      RaiseClick(e);
    }
    #endregion

    #region Click Event Procedure
    public delegate void ClickEventHandler(object sender, RoutedEventArgs e);
    public event ClickEventHandler Click;

    protected void RaiseClick(RoutedEventArgs e)
    {
      if (null != Click)
        Click(this, e);
    }
    #endregion

    #region Visual State Animations
    private void borMain_MouseEnter(object sender, MouseEventArgs e)
    {
      VisualStateManager.GoToElementState(borMain, "MouseEnter", true);
    }

    private void borMain_MouseLeave(object sender, MouseEventArgs e)
    {
      VisualStateManager.GoToElementState(borMain, "MouseLeave", true);
    }
    #endregion
  }
}
