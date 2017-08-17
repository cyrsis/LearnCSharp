using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace WPFComponents
{
  public class DataType
  {
    public string Name { get; set; }

    public IEnumerable<DataType> GetDataTypes(string languageName)
    {
      XElement xe;
      IEnumerable<DataType> items = null;
       
      if (languageName == "C#")
        xe = XElement.Load(WPFCommon.GetCurrentDirectory() + @"\Xml\DataTypesCS.xml");
      else if (languageName == "VB.NET")
        xe = XElement.Load(WPFCommon.GetCurrentDirectory() + @"\Xml\DataTypesVB.xml");
      else
        xe = null;

      // Always check for null because of design time problem
      if (xe != null)
      {
        items = (from item in xe.Descendants("DataType")
                     select new DataType
                     {
                       Name = item.Element("Name").Value
                     });
      }

      return items;
    }
  }
}
