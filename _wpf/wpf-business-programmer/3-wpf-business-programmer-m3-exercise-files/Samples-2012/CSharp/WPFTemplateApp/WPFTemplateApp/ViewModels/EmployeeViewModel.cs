using System.Collections.ObjectModel;
using System.Windows;

namespace WPFTemplateApp
{
  public class EmployeeViewModel : ViewModelBase
  {
    #region Constructor
    public EmployeeViewModel()
    {
      // Make sure GetEmployees has great exception handling!
      DataCollection = _DataManager.GetEmployees();
    }
    #endregion

    #region Private Variables
    EmployeeManager _DataManager = new EmployeeManager();
    #endregion

    #region DataCollection Property
    public ObservableCollection<Employee> DataCollection
    {
      get { return (ObservableCollection<Employee>)GetValue(DataCollectionProperty); }
      set { SetValue(DataCollectionProperty, value); }
    }

    public static readonly DependencyProperty DataCollectionProperty =
        DependencyProperty.Register("DataCollection", typeof(ObservableCollection<Employee>), typeof(EmployeeViewModel), new UIPropertyMetadata(null));
    #endregion
    
    #region DetailData Property
    public Employee DetailData
    {
      get { return (Employee)GetValue(DetailDataProperty); }
      set { SetValue(DetailDataProperty, value); }
    }

    public static readonly DependencyProperty DetailDataProperty =
        DependencyProperty.Register("DetailData", typeof(Employee), typeof(EmployeeViewModel), new UIPropertyMetadata(null));
    #endregion

    #region AddRecord Method
    public void AddRecord()
    {
      SetViewStateMode(UIStateMode.Add);

      // Create Empty Object for UI to Display
      DetailData = new Employee();
    }
    #endregion

    #region CancelEdit Method
    public void CancelEdit()
    {
      SetViewStateMode(UIStateMode.Cancel);

      // TODO: Write Code to Undo Here
    }
    #endregion

    #region SaveData Method
    public void SaveData()
    {
      if (IsAddMode)
      {
        _DataManager.Insert(DetailData);
        DataCollection.Add(DetailData);
        SetViewStateMode(UIStateMode.Normal);
      }
      else
      {
        _DataManager.Update(DetailData);
        SetViewStateMode(UIStateMode.Normal);
      }
    }
    #endregion

    #region DeleteData Method
    public void DeleteData()
    {
      _DataManager.Delete(DetailData);
      DataCollection.Remove(DetailData);
      SetViewStateMode(UIStateMode.Normal);
    }
    #endregion
  }
}
