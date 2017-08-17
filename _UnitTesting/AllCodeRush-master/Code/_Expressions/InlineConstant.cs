using System;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Inline Constant
        
			Use Case: Replaces a constant reference with its 
			defined value, removing the constant declaration if there 
			are no other references to it.
         
			Available: When the caret is on a constant reference.
        
			See also: Introduce Constant, Introduce Constant (Local)
		 •———————————————————————————————————————————————————————• */

	public class InlineConstant
	{
    const double pi = Math.PI;

    public static TimeSpan GetLightSpan(double meters)
    {
      const double LIGHTSPEED = 2.9979e10;
      return TimeSpan.FromSeconds(meters / LIGHTSPEED);
    }

    public static double GetSphereVolume(int radius)
    {
      return 4 / 3 * pi * Math.Pow(radius, 3);
    }
	}
}
