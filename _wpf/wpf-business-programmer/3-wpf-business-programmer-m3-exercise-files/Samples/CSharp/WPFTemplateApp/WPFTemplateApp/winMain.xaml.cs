using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WPFTemplateApp
{
  /// <summary>
  /// Interaction logic for winMain.xaml
  /// </summary>
  public partial class winMain : Window
  {
    private const int ANIMATION_TIME = 500;
    DoubleAnimation aniCurrent = null;
    DoubleAnimation aniNew = null;
    private UserControl currentControl = null;
    private UserControl newControl = null;

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      Init();
    }

    private void Init()
    {
      // Do any initialization here
    }

    private void btnEmployee_Click(object sender, RoutedEventArgs e)
    {
      newControl = new ucEmployee();
      PrepareNew();
      PrepareCurrent();
      AnimateControls();
    }

    private void btnProduct_Click(object sender, RoutedEventArgs e)
    {
      newControl = new ucProduct();
      PrepareNew();
      PrepareCurrent();
      AnimateControls();
    }

    private void btnProductWithImages_Click(object sender, RoutedEventArgs e)
    {
      newControl = new ucProductWithImages();
      PrepareNew();
      PrepareCurrent();
      AnimateControls();
    }

    private void btnProductDetail_Click(object sender, RoutedEventArgs e)
    {
      newControl = new ucProductList();
      PrepareNew();
      PrepareCurrent();
      AnimateControls();      
    }
  
    #region Setup New Control's Transform
    private void PrepareNew()
    {
      newControl.RenderTransformOrigin = new Point(contentArea.ActualWidth + 1, 0);
      TranslateTransform trans = new TranslateTransform();
      newControl.RenderTransform = trans;

      aniNew = new DoubleAnimation(contentArea.ActualWidth + 1, contentArea.RenderTransformOrigin.X,
        TimeSpan.FromMilliseconds(ANIMATION_TIME), FillBehavior.Stop);

      // Setup the event handler for the complete event on the new animation
      aniNew.Completed += new EventHandler(aniNew_Completed);

      contentArea.Children.Add(newControl);
    }
    #endregion

    #region Setup Current Control's Transform
    private void PrepareCurrent()
    {
      if (currentControl != null)
      {
        TranslateTransform trans = new TranslateTransform();
        currentControl.RenderTransform = trans;

        aniCurrent = new DoubleAnimation(0, -(contentArea.ActualWidth + 1),
          TimeSpan.FromMilliseconds(ANIMATION_TIME), FillBehavior.Stop);

        // Setup the event handler for the complete event on the current animation
        aniCurrent.Completed += new EventHandler(aniCurrent_Completed);
      }
    }
    #endregion

    #region Animate the Controls
    private void AnimateControls()
    {
      if (currentControl != null)
      {
        ((TranslateTransform)currentControl.RenderTransform).
          BeginAnimation(TranslateTransform.XProperty, aniCurrent,
          HandoffBehavior.Compose);
      }
      if (newControl != null)
      {
        ((TranslateTransform)newControl.RenderTransform).
          BeginAnimation(TranslateTransform.XProperty, aniNew,
          HandoffBehavior.Compose);
      }
    }
    #endregion

    #region Animation Completed Events
    void aniNew_Completed(object sender, EventArgs e)
    {
      if (newControl != null)
      {
        // As soon as you assign a newControl to the currentControl
        // the currentControl is unloaded.
        System.Diagnostics.Debug.WriteLine("Assigning newControl to currentControl");
        currentControl = newControl;
      }
      aniNew.Completed -= new EventHandler(aniNew_Completed);
    }

    void aniCurrent_Completed(object sender, EventArgs e)
    {
      System.Diagnostics.Debug.WriteLine("Unloading aniCurrent_Completed");
      // When you remove a control from the Visual Tree, it will be unloaded
      contentArea.Children.Remove(currentControl);
      aniCurrent.Completed -= new EventHandler(aniCurrent_Completed);
    }
    #endregion

  }
}
