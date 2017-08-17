using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WPFComponents
{
  public class LanguageDataType
  {
    public string Name { get; set; }
    public ObservableCollection<DataType> LanguageDataTypes { get; set; }

    public LanguageDataType()
    {
    }

    // Constructor with Param Array
    public LanguageDataType(string name, params DataType[] dataType)
    {
      this.Name = name;

      LanguageDataTypes = new ObservableCollection<DataType>();
      foreach (DataType dt in dataType)
      {
        LanguageDataTypes.Add(dt);
      }
    }

    public ObservableCollection<LanguageDataType> CreateLanguageData()
    {
      ObservableCollection<LanguageDataType> langDataType = new ObservableCollection<LanguageDataType>();

      langDataType.Add(new LanguageDataType("C#",
          new DataType() { Name = "object" },
          new DataType() { Name = "bool" },
          new DataType() { Name = "string" },
          new DataType() { Name = "int" }));

      langDataType.Add(new LanguageDataType("VB.NET",
          new DataType() { Name = "String" },
          new DataType() { Name = "Integer" },
          new DataType() { Name = "Decimal" },
          new DataType() { Name = "Object" }));

      return langDataType;
    }
  }
}
