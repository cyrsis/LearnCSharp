using System;

namespace AllCodeRush.Code.Methods
{
  /* •———————————————————————————————————————————————————————•
      Feature: Inline Method
        
      Use Case: Replaces a method call with the contents of 
      that method.
         
      Available: When the caret is on a method call or its 
      declaration (use this latter availability to inline 
      the method everywhere it's called).
        
      See also: Extract Method, Inline Method (and delete)
     •———————————————————————————————————————————————————————• */

  public class InlineMethod
	{
    private static double GetAreaOfCircle(int radius)
    {
      return radius * radius * Math.PI;
    }

    public double GetVolumeOfSphere(int radius)
    {
      return 4 / 3 * radius * GetAreaOfCircle(radius);
    }

    public double GetVolumeOfCylinder(int radius, int height)
		{
			return GetAreaOfCircle(radius) * height;
		}

		public double GetSurfaceAreaOfSphere(int radius)
    {
      return GetAreaOfCircle(radius) * 4;
    }
	}
}
