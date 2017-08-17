using System;

namespace AllCodeRush.Code.Methods.Parameters
{
  public class Drive
  {
    public string Name { get; set; }
    public Folder RootFolder { get; set; }

    public void SetAttributes(FileAttributes fileAttributes)
    {
      RootFolder.SetAttributes(fileAttributes);
    }
  }
}
