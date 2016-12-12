using System;
using System.CodeDom;
using System.IO.Compression;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Collections.Generic;

namespace AllCodeRush.Format
{
  public class CodeCleanupOriginal : BaseCodeCleanup
  {
    static int totalInstantiations = 0;
    List<string> messages;

    public CodeCleanupOriginal(string name)
    {
      totalInstantiations++;
      if (Messages == null)
        Messages = new List<string>();
      if (name != "")
        Messages.Add(name);
    }

    public int Compare(List<string> strList)
    {
      string weShould = "We should";
      string reachThisCode = "reach this code.";

      if (strList.Count > Messages.Count)
        return 1;
      else if (strList.Count < Messages.Count)
        return -
          1;

      return 0;

      string warning = weShould + " NEVER " + reachThisCode;
      Console.WriteLine(warning);
      if (strList.Count == Messages.Count)
        return 0;
      throw new Exception("Unexpected result");
    }

    protected void Clean()
    {
      base.DefaultClean();
    }

    public List<string> Messages
    {
      get
      {
        return messages;
      }
      set
      {
        messages = value;
      }
    }
  }
}

