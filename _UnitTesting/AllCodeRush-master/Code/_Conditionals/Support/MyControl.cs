using System;

namespace AllCodeRush.Code.Conditionals
{
  public class MyControl
  {
    public bool Visible { get; set; }
    public bool Checked { get; set; }
    public bool Enabled { get; set; }
    public bool Sorted { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int Count { get; set; }
    public int Length { get; set; }
    public int Top { get; set; }
    public int Left { get; set; }
    public int Right { get; set; }
    public int Bottom { get; set; }
    public MyControl Parent { get; set; }
    public System.Drawing.Rectangle ClientRectangle { get; set; }
    public string Name { get; set; }
    public string Text { get; set; }
    public object Size { get; set; }

    public void Clear()
    {

    }
    public void Dispose()
    {

    }
    public void Close()
    {

    }
  }
}
