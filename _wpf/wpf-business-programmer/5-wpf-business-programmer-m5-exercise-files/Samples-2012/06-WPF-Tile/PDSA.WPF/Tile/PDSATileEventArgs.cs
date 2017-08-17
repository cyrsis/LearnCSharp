using System;

namespace PDSA.WPF
{
  public class PDSATileEventArgs : EventArgs
  {
    public PDSATileEventArgs()
      : base()
    {
      ViewName = string.Empty;
      Text = string.Empty;
      ImageUri = string.Empty;
      ToolTip = string.Empty;
    }

    public string ViewName { get; set; }
    public string Text { get; set; }
    public string ImageUri { get; set; }
    public string ToolTip { get; set; }
  }
}
