using System.ComponentModel;
using System.Windows;

namespace WPFTemplateApp
{
  public class ObjectBase : DependencyObject, INotifyPropertyChanged
  {
    #region INotifyPropertyChanged
    public event PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
    {
      if (PropertyChanged != null)
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion
  }
}
