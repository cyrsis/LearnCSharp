using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.IO;

namespace WPFComponents
{
  public class Product
  {
    #region Public Properties
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public string Logo { get; set; }
    #endregion

    public IEnumerable<Product> GetProductCollection()
    {
      IEnumerable<Product> ret = null;
      string fileName;

      fileName = WPFCommon.GetCurrentDirectory() +
        @"\Xml\Product.xml";

      if (File.Exists(fileName))
        ret = Product.GetProducts(fileName);

      return ret;
    }

    public static IEnumerable<Product> GetProducts(string fileName)
    {
      XElement elem = XElement.Load(fileName);

      var items = from prod in elem.Descendants("Product")
                  select new Product
                  {
                    ProductId = Convert.ToInt32(prod.Element("ProductId").Value),
                    ProductName = prod.Element("ProductName").Value,
                    Price = Convert.ToDecimal(prod.Element("Price").Value),
                    Logo = prod.Element("Logo").Value
                  };

      return items;
    }
  }
}
