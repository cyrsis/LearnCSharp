using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Linq.Expressions;

namespace WPFComponents
{  
  public class Language
  {
    public string Name { get; set; }

    public IEnumerable<Language> GetLanguages()
    {
      XElement xe = null;
      IEnumerable<Language> items = null;

      try
      {
        xe = XElement.Load(
          WPFCommon.GetCurrentDirectory() + 
          @"\Xml\Languages.xml");
      }
      catch
      {
        // Ignore exceptions
      }

      // Always check for null because of design time problem
      if (xe != null)
      {
        items = (from item in xe.Descendants("Language")
                 select new Language
                 {
                   Name = item.Element("Name").Value
                 });
      }

      return items;
    }
  }
}
