using System;

namespace AllCodeRush.Code.Methods.Parameters
{
  public enum Direction
  {
    North,
    NorthEast,
    East,
    SouthEast,
    South,
    SouthWest,
    West,
    NorthWest
  }
  /* •———————————————————————————————————————————————————————•
      Feature: Reorder Parameters
          
      Use Case: Reorders method parameters, updating all 
      calls throughout the solutoin as needed.
           
      Available:  
        - When the caret is on a parameter in a method that 
          has two or more parameters (or at least one out 
          parameter).
     •———————————————————————————————————————————————————————• */

  public class ReorderParameters
  {
    private static void SetDirection(int startAngle, double degrees, Direction setting, ref Direction direction)
    {
      double half45 = 45 / 2.0;
      if (degrees >= startAngle - half45 && degrees < startAngle + half45)
        direction = setting;
    }

    public static void GetPolarCoordinates(out double radius, out double degrees,
                                           double y, double x,
                                           out Direction direction)
    {
      radius = Math.Sqrt((x * x) + (y * y));
      degrees = Math.Atan2(y, x) * 180 / Math.PI;
      direction = Direction.North;

      SetDirection(45, degrees, Direction.NorthEast, ref direction);
      SetDirection(90, degrees, Direction.East, ref direction);
      SetDirection(135, degrees, Direction.SouthEast, ref direction);
      SetDirection(180, degrees, Direction.South, ref direction);
      SetDirection(225, degrees, Direction.SouthWest, ref direction);
      SetDirection(270, degrees, Direction.West, ref direction);
      SetDirection(315, degrees, Direction.NorthWest, ref direction);
    }
  }

}
