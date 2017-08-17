using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Markup;
using System.IO;

namespace WPFComponents
{
  public class WPFCommon
  {
    public static void LoadSamplesResource(Window frm, string fileName)
    {
      ResourceDictionary dic = null;

      if (File.Exists(fileName))
      {
        using (FileStream fs = new FileStream(fileName, FileMode.Open))
        {
          dic = (ResourceDictionary)XamlReader.Load(fs);
          frm.Resources.MergedDictionaries.Add(dic);
        }
      }
      else
      {
        throw new ApplicationException("Can't open resource file: " + fileName + " in the method PDSASamples.LoadSamplesResource().");
      }
    }

    public static string GetCurrentDirectory()
    {
      string path = null;

      path = AppDomain.CurrentDomain.BaseDirectory;
      if (path.IndexOf(@"\bin") > 0)
      {
        path = path.Substring(0, path.LastIndexOf(@"\bin"));
      }

      return path;
    }
  }
}
