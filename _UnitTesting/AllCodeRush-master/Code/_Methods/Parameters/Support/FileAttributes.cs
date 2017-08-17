using System;

namespace AllCodeRush.Code.Methods.Parameters
{
  [Flags]
  public enum FileAttributes
  {
    ReadOnly = 1,
    Archive = 2,
    Compressed = 4,
    System = 8
  }
}
