using System;
using System.Collections.Generic;

namespace AllCodeRush.Code.Methods.Parameters
{
  public class Folder
  {
    public Folder Parent { get; set; }
    public string Name { get; set; }
    private readonly List<File> files = new List<File>();
    private readonly List<Folder> folders = new List<Folder>();

    public void SetAttributes(FileAttributes fileAttributes)
    {
      foreach (Folder folder in folders)
        folder.SetAttributes(fileAttributes);
      foreach (File file in files)
        file.SetAttributes(fileAttributes);
    }

    public List<File> Files
    {
      get
      {
        return files;
      }
    }

    public string Path
    {
      get
      {
        if (Parent != null)
          return string.Format("{0}\\{1}", Parent.Path, Name);
        return Name;
      }
    }
    public List<Folder> Folders
    {
      get
      {
        return folders;
      }
    }
  }
}
