using System;

namespace AllCodeRush.Code.EventsDelegates
{
  public struct Point3D
  {
    private double _X;
    private double _Y;
    private double _Z;
    /// <summary>
    /// Summary for Point3D
    /// </summary>
    public Point3D(double x, double y, double z)
    {
      _X = x;
      _Y = y;
      _Z = z;
    }
    public double X
    {
      get
      {
        return _X;
      }
    }
    public double Y
    {
      get
      {
        return _Y;
      }
    }
    public double Z
    {
      get
      {
        return _Z;
      }
    }
  }
}
