
namespace WPFTemplateApp
{
  public class Product : ObjectBase
  {
    #region Private Variables
    private int _ProductId = 0;
    private string _ProductName = string.Empty;
    private decimal _Price = 0;
    private bool _IsActive = true;
    #endregion

    #region Public Properties
    public int ProductId
    {
      get { return _ProductId; }
      set
      {
        if (_ProductId != value)
        {
          _ProductId = value;
          RaisePropertyChanged("ProductId");
        }
      }
    }

    public string ProductName
    {
      get { return _ProductName; }
      set
      {
        if (_ProductName != value)
        {
          _ProductName = value;
          RaisePropertyChanged("ProductName");
        }
      }
    }

    public decimal Price
    {
      get { return _Price; }
      set
      {
        if (_Price != value)
        {
          _Price = value;
          RaisePropertyChanged("Price");
        }
      }
    }

    public bool IsActive
    {
      get { return _IsActive; }
      set
      {
        if (_IsActive != value)
        {
          _IsActive = value;
          RaisePropertyChanged("IsActive");
        }
      }
    }
    #endregion
  }
}
