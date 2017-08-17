using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using PDSA.Common;

namespace Windows8Shell
{
  public class ProductManager : PDSACommonBase
  {
    #region Constructors
    public ProductManager()
    {
      FullFileName =
        PDSAFileCommon.GetCurrentDirectory() +
           @"\Xml\Product.xml";
    }
    #endregion

    #region Private Properties
    public string FullFileName { get; set; }
    private string TopElementName = "Product";
    private XElement XmlObject = null;
    #endregion

    #region DataCollection Property
    private List<Product> _DataCollection = new List<Product>();

    public List<Product> DataCollection
    {
      get { return _DataCollection; }
      set
      {
        _DataCollection = value;
        RaisePropertyChanged("DataCollection");
      }
    }
    #endregion

    #region LoadAll Method
    public void LoadAll()
    {
      DataCollection = new List<Product>();
      try
      {
        // Retrieve Data from Xml File
        XmlObject = XElement.Load(FullFileName);

        // Create list of Product objects
        var products =
          from prod in XmlObject.Descendants("Product")
          orderby prod.Attribute("ProductName").Value
          select new Product
          {
            ProductId = Convert.ToInt32(prod.Attribute("ProductId").Value),
            ProductName = prod.Attribute("ProductName").Value,
            IntroductionDate = Convert.ToDateTime(prod.Attribute("IntroductionDate").Value),
            Price = Convert.ToDecimal(prod.Attribute("Price").Value)
          };

        DataCollection = products.ToList();
      }
      catch
      {
        // Ignore design time exceptions here
      }
    }
    #endregion

    #region Insert Method
    public bool Insert(Product entity)
    {
      // Create new Product element
      var newElem = new XElement(TopElementName,
        new XAttribute("ProductId", entity.ProductId),
        new XAttribute("ProductName", entity.ProductName),
        new XAttribute("IntroductionDate", entity.IntroductionDate),
        new XAttribute("Price", entity.Price));

      // Add to element collection
      XmlObject.Add(newElem);

      // Save the file
      Save(XmlObject);

      return true;
    }
    #endregion

    #region Update Method
    public bool Update(Product entity)
    {
      // Find the product element
      var XElem = (from elem in XmlObject.Descendants(TopElementName)
                   where elem.Attribute("ProductId").Value == entity.ProductId.ToString()
                   select elem).SingleOrDefault();

      // Update the data
      XElem.Attribute("ProductName").Value = entity.ProductName;
      XElem.Attribute("IntroductionDate").Value = entity.IntroductionDate.ToString();
      XElem.Attribute("Price").Value = entity.Price.ToString();

      // Save the file
      Save(XmlObject);

      return true;
    }
    #endregion

    #region Delete Method
    public bool Delete(Product entity)
    {
      // Find the product element
      var XElem = (from elem in XmlObject.Descendants(TopElementName)
                   where elem.Attribute("ProductId").Value == entity.ProductId.ToString()
                   select elem).SingleOrDefault();
      // Delete the element
      XElem.Remove();

      // Save the file
      Save(XmlObject);

      return true;
    }
    #endregion

    public void Save(XElement xmlToWrite)
    {
      if (xmlToWrite != null)
      {
        // Make sure the directory exists
        if (!Directory.Exists(Path.GetDirectoryName(FullFileName)))
          Directory.CreateDirectory(Path.GetDirectoryName(FullFileName));

        File.WriteAllText(FullFileName, xmlToWrite.ToString());
      }
    }

    #region GetNextProductId Method
    public int GetNextProductId()
    {
      // Get The last id
      var MaxID = (from elem in XmlObject.Descendants(TopElementName)
                   select Convert.ToInt32(elem.Attribute("ProductId").Value)).Max();

      return MaxID + 1;
    }
    #endregion
  }
}