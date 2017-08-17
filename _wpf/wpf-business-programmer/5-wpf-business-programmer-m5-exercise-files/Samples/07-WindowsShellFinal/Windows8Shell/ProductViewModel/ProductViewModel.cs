using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PDSA.Common;

namespace Windows8Shell
{
  public class ProductViewModel : PDSAViewModelBase
  {
    #region Private Variables
    private Product _OriginalData = null;
    private ProductManager _ManagerObject = null;
    private Product _DetailData = null;
    private ObservableCollection<Product> _DataCollection = new ObservableCollection<Product>();
    #endregion

    #region Public Properties
    public ProductManager ManagerObject
    {
      get { return _ManagerObject; }
      set
      {
        _ManagerObject = value;
        RaisePropertyChanged("ManagerObject");
      }
    }

    public Product DetailData
    {
      get { return _DetailData; }
      set
      {
        _DetailData = value;
        RaisePropertyChanged("DetailData");
      }
    }

    public ObservableCollection<Product> DataCollection
    {
      get { return _DataCollection; }
      set
      {
        _DataCollection = value;
        RaisePropertyChanged("DataCollection");
      }
    }
    #endregion

    #region CreateOrGetManagerObject Method
    protected void CreateOrGetManagerObject()
    {
      // Maybe implement some caching here
      if (ManagerObject == null)
        ManagerObject = new ProductManager();
    }
    #endregion

    #region LoadAll Method
    public void LoadAll()
    {
      // Create or Get Manager Object
      CreateOrGetManagerObject();
      // Load all Records from Data Store
      ManagerObject.LoadAll();
      // Convert Generic List<> to an Observable Collection for WPF/Silverlight
      DataCollection = new ObservableCollection<Product>(ManagerObject.DataCollection);
      // Set Total # of Records Read
      TotalRecords = DataCollection.Count;

      // Check for XML records, could mean the file does not exist
      if (TotalRecords == 0)
      {
        SetUIState(PDSAEditUIState.Exception);
        LastExceptionMessage = "No XML Records. This could mean the XML file " + ManagerObject.FullFileName + " does not exist in the User's Local Data Storage, or there are just no records in the XML file.";
      }
      else
        SetUIState(PDSAEditUIState.Normal);
    }
    #endregion

    #region Save Method
    public void Save()
    {
      if (IsAddMode)
        Insert();
      else
        Update();
    }
    #endregion

    #region Insert Method
    public void Insert()
    {
      if (ManagerObject.Insert(DetailData))
      {
        DataCollection.Add(DetailData);
        SetUIState(PDSAEditUIState.Normal);
        TotalRecords = DataCollection.Count;
      }
    }
    #endregion

    #region Update Method
    public void Update()
    {
      if (ManagerObject.Update(DetailData))
      {
        SetUIState(PDSAEditUIState.Normal);
      }
    }
    #endregion

    #region Delete Method
    public void Delete()
    {
      if (ManagerObject.Delete(DetailData))
      {
        DataCollection.Remove(DetailData);
        if (DataCollection.Count > 0)
        {
          if (SelectedIndex != DataCollection.Count - 1)
            SelectedIndex--;
          if (SelectedIndex < 0)
            SelectedIndex = 0;

          DetailData = DataCollection[SelectedIndex];
        }
      }

      TotalRecords = DataCollection.Count;
    }
    #endregion

    #region AddData Method
    public void AddData()
    {
      // Create or Get the Manager Object
      CreateOrGetManagerObject();

      // Set any defaults here
      DetailData = new Product();
      DetailData.ProductId = ManagerObject.GetNextProductId();
      DetailData.IntroductionDate = DateTime.Now;

      // Set the IsAddMode flag
      IsAddMode = true;
      // Set UI State to Edit Mode
      SetUIState(PDSAEditUIState.Edit);
    }
    #endregion

    #region EditData Method
    public void EditData()
    {
      // Clone current object in case we need to undo changes
      CloneCurrent();
      IsAddMode = false;
      SetUIState(PDSAEditUIState.Edit);
    }
    #endregion

    #region CancelEdit Method
    public void CancelEdit()
    {
      Undo();
      SetUIState(PDSAEditUIState.Normal);
    }
    #endregion

    #region CloneCurrent Method
    public void CloneCurrent()
    {
      if (DetailData != null)
      {
        _OriginalData = new Product();

        _OriginalData.ProductId = DetailData.ProductId;
        _OriginalData.ProductName = DetailData.ProductName;
        _OriginalData.IntroductionDate = DetailData.IntroductionDate;
        _OriginalData.Price = DetailData.Price;
      }
    }
    #endregion

    #region Undo Method
    public void Undo()
    {
      if (_OriginalData != null)
      {
        DetailData.ProductId = _OriginalData.ProductId;
        DetailData.ProductName = _OriginalData.ProductName;
        DetailData.IntroductionDate = _OriginalData.IntroductionDate;
        DetailData.Price = _OriginalData.Price;
      }
    }
    #endregion
  }
}
