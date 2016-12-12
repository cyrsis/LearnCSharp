using System;
using System.Collections.Generic;

namespace AllCodeRush.Code.Methods.Parameters
{
  public class UndoEngine
  {
    private readonly Dictionary<string, FileAttributes> storedAttributes = new Dictionary<string, FileAttributes>();
    public void SavePreviousAttribute(string fullPathName, FileAttributes attributes)
    {
      storedAttributes.Add(fullPathName, attributes);
    }
  }
}
