using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFListBox
{
  public class AppConfig
  {
    protected static string GetConnectString(string key)
    {
      return ConfigurationManager.ConnectionStrings[key].ConnectionString;
    }

    public static string ConnectString
    {
      get { return GetConnectString("WPFComponents.Properties.Settings.AdventureWorksLTConnectionString"); }
    }
  }
}
