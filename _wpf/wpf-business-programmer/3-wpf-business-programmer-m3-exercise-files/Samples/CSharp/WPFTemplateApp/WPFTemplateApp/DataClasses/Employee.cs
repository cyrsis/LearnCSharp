
namespace WPFTemplateApp
{
  public class Employee : ObjectBase
  {
    #region Private Variables
    private int _EmployeeNumber = 0;
    private string _FirstName = string.Empty;
    private string _LastName = string.Empty;
    private string _SSN = string.Empty;
    #endregion

    #region Public Properties
    public int EmployeeNumber
    {
      get { return _EmployeeNumber; }
      set
      {
        if (_EmployeeNumber != value)
        {
          _EmployeeNumber = value;
          RaisePropertyChanged("EmployeeNumber");
        }
      }
    }

    public string FirstName
    {
      get { return _FirstName; }
      set
      {
        if (_FirstName != value)
        {
          _FirstName = value;
          RaisePropertyChanged("FirstName");
        }
      }
    }
    
    public string LastName
    {
      get { return _LastName; }
      set
      {
        if (_LastName != value)
        {
          _LastName = value;
          RaisePropertyChanged("LastName");
        }
      }
    }

    public string SSN
    {
      get { return _SSN; }
      set
      {
        if (_SSN != value)
        {
          _SSN = value;
          RaisePropertyChanged("SSN");
        }
      }
    }
    #endregion
  }
}
