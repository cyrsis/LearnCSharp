using System;

namespace AllCodeRush.Code.Methods.Parameters
{
  /* •———————————————————————————————————————————————————————•
      Feature: Convert to Tuple
          
      Use Case: Converts two or more adjacent parameters into 
      a single Tuple parameter.
           
      Available:  
        - When two adjacent double or int parameters are 
          selected.
          
      See also: Convert to Point, Introduce Parameter Object,
      Reorder Parameters
     •———————————————————————————————————————————————————————• */
  public enum Heading
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
  public class ConvertToTuple
  {
    private static void SetHeading(ref Heading heading, double degrees, int startAngle, Heading setting)
    {
      double half45 = 45 / 2.0;
      if (degrees >= startAngle - half45 && degrees < startAngle + half45)
        heading = setting;
    }

    public static void GetPolarCoordinates(double x, double y, out double radius, out double degrees, out Heading heading)
    {
      radius = Math.Sqrt((x * x) + (y * y));
      degrees = Math.Atan2(y, x) * 180 / Math.PI;
      heading = Heading.North;

      SetHeading(ref heading, degrees, 45, Heading.NorthEast);
      SetHeading(ref heading, degrees, 90, Heading.East);
      SetHeading(ref heading, degrees, 135, Heading.SouthEast);
      SetHeading(ref heading, degrees, 180, Heading.South);
      SetHeading(ref heading, degrees, 225, Heading.SouthWest);
      SetHeading(ref heading, degrees, 270, Heading.West);
      SetHeading(ref heading, degrees, 315, Heading.NorthWest);
    }
  }
}
