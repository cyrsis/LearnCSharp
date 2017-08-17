using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PDSA.WPF
{
  [DefaultEvent("Click")]
  public partial class PDSAucTile : UserControl
  {
    #region Constructor
    public PDSAucTile()
    {
      InitializeComponent();

      this.DataContext = this;
    }
    #endregion

    #region Text Property
    public string Text
    {
      get { return (string)GetValue(TileTextProperty); }
      set { SetValue(TileTextProperty, value); }
    }

    // Using a DependencyProperty as the backing store for TileText.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty TileTextProperty =
        DependencyProperty.Register("TileText", typeof(string), typeof(PDSAucTile), null);
    #endregion

    #region ViewName
    public string ViewName
    {
      get { return (string)GetValue(ViewNameProperty); }
      set { SetValue(ViewNameProperty, value); }
    }

    // Using a DependencyProperty as the backing store for ViewName.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty ViewNameProperty =
        DependencyProperty.Register("ViewName", typeof(string), typeof(PDSAucTile), null);
    #endregion

    #region ImageUri Property
    public Uri ImageUri
    {
      get { return (Uri)GetValue(TileImageUriProperty); }
      set { SetValue(TileImageUriProperty, value); }
    }

    // Using a DependencyProperty as the backing store for TileImageUri.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty TileImageUriProperty =
        DependencyProperty.Register("TileImageUri", typeof(Uri), typeof(PDSAucTile), null);
    #endregion

    #region Click Event Procedure
    public delegate void TileClickEventHandler(object sender, PDSATileEventArgs e);
    public event TileClickEventHandler Click;

    protected void RaiseClick(PDSATileEventArgs e)
    {
      if (null != Click)
        Click(this, e);
    }

    private void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      PDSATileEventArgs args = new PDSATileEventArgs();

      args.Text = this.Text;
      args.ViewName = this.ViewName;
      args.ImageUri = this.ImageUri.ToString();

      RaiseClick(args);
    }
    #endregion

    #region Visual State Manager Events
    private void OnMouseEnter(object sender, MouseEventArgs e)
    {
      VisualStateManager.GoToState(this, "MouseEnter", true);
    }

    private void OnMouseLeave(object sender, MouseEventArgs e)
    {
      VisualStateManager.GoToState(this, "MouseLeave", true);
    }
    #endregion
  }
}
