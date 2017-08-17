using System.Collections.ObjectModel;
using System.Windows;

namespace WPFTemplateApp
{
  public class ProductViewModel : ViewModelBase
  {
    #region Constructor
    public ProductViewModel()
    {
      // Make sure GetProducts has great exception handling!
      DataCollection = _DataManager.GetProducts();
    }
    #endregion

    #region Private Variables
    ProductManager _DataManager = new ProductManager();
    #endregion

    #region DataCollection Property
    public ObservableCollection<Product> DataCollection
    {
      get { return (ObservableCollection<Product>)GetValue(DataCollectionProperty); }
      set { SetValue(DataCollectionProperty, value); }
    }

    public static readonly DependencyProperty DataCollectionProperty =
        DependencyProperty.Register("DataCollection", typeof(ObservableCollection<Product>), typeof(ProductViewModel), new UIPropertyMetadata(null));
    #endregion
    
    #region DetailData Property
    public Product DetailData
    {
      get { return (Product)GetValue(DetailDataProperty); }
      set { SetValue(DetailDataProperty, value); }
    }

    public static readonly DependencyProperty DetailDataProperty =
        DependencyProperty.Register("DetailData", typeof(Product), typeof(ProductViewModel), new UIPropertyMetadata(null));
    #endregion

    #region AddRecord Method
    public void AddRecord()
    {
      SetViewStateMode(UIStateMode.Add);

      // Create Empty Object for UI to Display
      DetailData = new Product();
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
