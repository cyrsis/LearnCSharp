Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media
Imports System.Windows.Media.Animation

Partial Public Class winMain
  Inherits Window
  Private Const ANIMATION_TIME As Integer = 500
  Private aniCurrent As DoubleAnimation = Nothing
  Private aniNew As DoubleAnimation = Nothing
  Private currentControl As UserControl = Nothing
  Private newControl As UserControl = Nothing

  Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Init()
  End Sub

  Private Sub Init()
    ' Do any initialization here
  End Sub

  Private Sub btnEmployee_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    newControl = New ucEmployee()
    PrepareNew()
    PrepareCurrent()
    AnimateControls()
  End Sub

  Private Sub btnProduct_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    newControl = New ucProduct()
    PrepareNew()
    PrepareCurrent()
    AnimateControls()
  End Sub

  Private Sub btnProductWithImages_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    newControl = New ucProductWithImages()
    PrepareNew()
    PrepareCurrent()
    AnimateControls()
  End Sub

  Private Sub btnProductDetail_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    newControl = New ucProductList()
    PrepareNew()
    PrepareCurrent()
    AnimateControls()
  End Sub

#Region "Setup New Control's Transform"
  Private Sub PrepareNew()
    newControl.RenderTransformOrigin = New Point(contentArea.ActualWidth + 1, 0)
    Dim trans As New TranslateTransform()
    newControl.RenderTransform = trans

    aniNew = New DoubleAnimation(contentArea.ActualWidth + 1, contentArea.RenderTransformOrigin.X, TimeSpan.FromMilliseconds(ANIMATION_TIME), FillBehavior.[Stop])

    ' Setup the event handler for the complete event on the new animation
    AddHandler aniNew.Completed, AddressOf aniNew_Completed

    contentArea.Children.Add(newControl)
  End Sub
#End Region

#Region "Setup Current Control's Transform"
  Private Sub PrepareCurrent()
    If currentControl IsNot Nothing Then
      Dim trans As New TranslateTransform()
      currentControl.RenderTransform = trans

      aniCurrent = New DoubleAnimation(0, -(contentArea.ActualWidth + 1), TimeSpan.FromMilliseconds(ANIMATION_TIME), FillBehavior.[Stop])

      ' Setup the event handler for the complete event on the current animation
      AddHandler aniCurrent.Completed, AddressOf aniCurrent_Completed
    End If
  End Sub
#End Region

#Region "Animate the Controls"
  Private Sub AnimateControls()
    If currentControl IsNot Nothing Then
      DirectCast(currentControl.RenderTransform, TranslateTransform).BeginAnimation(TranslateTransform.XProperty, aniCurrent, HandoffBehavior.Compose)
    End If
    If newControl IsNot Nothing Then
      DirectCast(newControl.RenderTransform, TranslateTransform).BeginAnimation(TranslateTransform.XProperty, aniNew, HandoffBehavior.Compose)
    End If
  End Sub
#End Region

#Region "Animation Completed Events"
  Private Sub aniNew_Completed(ByVal sender As Object, ByVal e As EventArgs)
    If newControl IsNot Nothing Then
      ' As soon as you assign a newControl to the currentControl
      ' the currentControl is unloaded.
      System.Diagnostics.Debug.WriteLine("Assigning newControl to currentControl")
      currentControl = newControl
    End If
    AddHandler aniNew.Completed, AddressOf aniNew_Completed
  End Sub

  Private Sub aniCurrent_Completed(ByVal sender As Object, ByVal e As EventArgs)
    System.Diagnostics.Debug.WriteLine("Unloading aniCurrent_Completed")
    ' When you remove a control from the Visual Tree, it will be unloaded
    contentArea.Children.Remove(currentControl)
    AddHandler aniCurrent.Completed, AddressOf aniCurrent_Completed
  End Sub
#End Region

End Class