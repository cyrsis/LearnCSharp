using System;
using System.IO;
using System.Linq;

namespace AllCodeRush.Format
{
  class CodeFormat
  {
    public static void CountFilesByExtension()
    {
      string[] files = Directory.GetFiles("C:\\");
      Func<string, string> getLowerExt = file => Path.GetExtension(file).TrimStart('.').ToLower();
      var selectedFiles = files.Select(getLowerExt);
      var extensionGroups = selectedFiles.GroupBy(x => x, (ext, extCnt) => new
      {
        Extension = ext,
        Count = extCnt.Count()
      });
      foreach (var extensionSummary in extensionGroups)
        Console.WriteLine("{0} File(s) with {1} Extension ", extensionSummary.Count, extensionSummary.Extension);
    }
  }
}
