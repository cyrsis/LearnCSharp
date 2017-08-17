using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace WPFTemplateApp
{
  public class ProductManager
  {
    #region GetProducts Methods
    public ObservableCollection<Product> GetProducts()
    {
      ObservableCollection<Product> ret;
      string fileName;

      try
      {
        fileName = WPFCommon.GetCurrentDirectory() +
          @"\Xml\Product.xml";

        if (File.Exists(fileName))
          ret = GetProducts(fileName);
        else
          ret = GetProductMocks();
      }
      catch (Exception ex)
      {
        Debug.WriteLine(ex.ToString());
        // Still return some data
        ret = GetProductMocks();
      }

      return ret;
    }

    protected ObservableCollection<Product> GetProducts(string fileName)
    {
      ObservableCollection<Product> ret;
      XElement elem = XElement.Load(fileName);

      var items = 
        from prod in elem.Descendants("Product")
        select new Product
        {
         ProductId = Convert.ToInt32(prod.Element("ProductId").Value),
         ProductName = prod.Element("ProductName").Value,
         Price = Convert.ToDecimal(prod.Element("Price").Value),
         IsActive = Convert.ToBoolean(prod.Element("IsActive").Value)
        };

      ret = new ObservableCollection<Product>(items);

      return ret;
    }
    #endregion

    #region Insert Method
    public int Insert(Product entity)
    {
      int ret = 0;

      // TODO: Insert Data Here

      return ret;
    }
    #endregion

    #region Update Method
    public int Update(Product entity)
    {
      int ret = 0;

      // TODO: Update Data Here

      return ret;
    }
    #endregion

    #region Delete Method
    public int Delete(Product entity)
    {
      int ret = 0;

      // TODO: Delete Data Here

      return ret;
    }
    #endregion

    #region Mock Data
    protected virtual ObservableCollection<Product> GetProductMocks()
    {
      Product entity;
      ObservableCollection<Product> ret = new ObservableCollection<Product>();

      entity = new Product();
      entity.ProductId = 1;
      entity.ProductName = "(Mock) Product 1";
      entity.Price = 100;
      entity.IsActive = true;
      ret.Add(entity);

      entity = new Product();
      entity.ProductId = 2;
      entity.ProductName = "(Mock) Product 2";
      entity.Price = 200;
      entity.IsActive = true;
      ret.Add(entity);

      entity = new Product();
      entity.ProductId = 3;
      entity.ProductName = "(Mock) Product 3";
      entity.Price = 300;
      entity.IsActive = false;
      ret.Add(entity);

      return ret;
    }
    #endregion
  }
}
