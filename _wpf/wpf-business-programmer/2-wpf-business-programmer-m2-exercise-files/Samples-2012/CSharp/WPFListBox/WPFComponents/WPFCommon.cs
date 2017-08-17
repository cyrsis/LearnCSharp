using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFComponents
{
  public class WPFCommon
  {
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
