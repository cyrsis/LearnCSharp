using System;
using System.Windows;

namespace AllCodeRush.Code.Methods.Parameters
{
  /* •———————————————————————————————————————————————————————•
      Feature: Convert to Point
          
      Use Case: Converts two adjacent numeric parameters into 
      a single Point parameter.
           
      Available:  
        - When two adjacent double or int parameters are 
          selected.
          
      See also: Convert to Tuple, Introduce Parameter Object
     •———————————————————————————————————————————————————————• */

  public class ConvertToPoint
  {
    public static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
      double deltaX = x1 - x2;
      double deltaY = y1 - y2;
      return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }

    public static void TestDistanceCalculations()
    {
      Point p1 = new Point(0, 0);
      Point p2 = new Point(3, 4);
      if (CalculateDistance(p1.X, p1.Y, p2.X, p2.Y) != 5)
      {
        // Handle error.
      }
    }
  }
}
