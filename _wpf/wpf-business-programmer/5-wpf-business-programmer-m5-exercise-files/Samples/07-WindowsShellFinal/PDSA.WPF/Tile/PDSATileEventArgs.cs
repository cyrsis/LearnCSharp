using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDSA.WPF
{
  public class PDSATileEventArgs : EventArgs
  {
    public string ViewName { get; set; }
    public string Text { get; set; }
    public string ImageUri { get; set; }
  }
}
