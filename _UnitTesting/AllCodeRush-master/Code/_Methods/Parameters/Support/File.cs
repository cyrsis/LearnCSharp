using System;

namespace AllCodeRush.Code.Methods.Parameters
{
  public class File
  {
    private FileAttributes attributes;
    public string Name { get; set; }
    public Folder Parent { get; set; }

    public void SetAttributes(FileAttributes fileAttributes)
    {
      // TODO: Use the new undo engine here.
      attributes = fileAttributes;
    }

    public string FullPathName
    {
      get
      {
        if (Parent != null)
          return string.Format("{0}\\{1}", Parent.Path, Name);
        return Name;
      }
    }

  }
}
