using System;
using PDSA.Common;

namespace Windows8Shell
{
  public class Product : PDSACommonBase
  {
    #region Private Variables
    private string _ProductName;
    private int _ProductId;
    private DateTime _IntroductionDate;
    private decimal _Price;
    #endregion

    #region Public Properties
    public string ProductName
    {
      get { return _ProductName; }
      set
      {
        _ProductName = value;
        RaisePropertyChanged("ProductName");
      }
    }

    public int ProductId
    {
      get { return _ProductId; }
      set
      {
        _ProductId = value;
        RaisePropertyChanged("ProductId");
      }
    }

    public DateTime IntroductionDate
    {
      get { return _IntroductionDate; }
      set
      {
        _IntroductionDate = value;
        RaisePropertyChanged("IntroductionDate");
      }
    }

    public decimal Price
    {
      get { return _Price; }
      set
      {
        _Price = value;
        RaisePropertyChanged("Price");
      }
    }
    #endregion

    #region ToString Override
    public override string ToString()
    {
      return ProductName;
    }
    #endregion
  }
}
