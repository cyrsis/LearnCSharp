using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
  public class Building
  {
    public int MaxOccupancy { get; set; }
    public string Name { get; set; }
    public int Sublevels { get; set; }
    public int Floors { get; set; }
    public ZoningArea Zone { get; set; }
  }
}
