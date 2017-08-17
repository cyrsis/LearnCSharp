using System;
using System.Drawing;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Inline Temp
        
			Use Case: Replaces all references to a local 
			variable with its initial value.
         
			Available: When the caret is on the declaration or 
			reference of a local variable. The variable should have 
			been assigned a value only once.
        
			See also: Introduce Local
		 •———————————————————————————————————————————————————————• */

	public class InlineTemp
	{
    public double GetMarbleDisplacement(int radius, Rectangle floor)
    {
      int radiusSquared = radius * radius;
      double circleArea = Math.PI * radiusSquared;
      double floorArea = floor.Width * floor.Height;
      int maxMarblesOnFloor = (int)Math.Floor(floorArea / circleArea);

      int radiusCubed = radiusSquared * radius;
      double marbleVolume = 4 / 3 * radiusCubed * Math.PI;

      return marbleVolume * maxMarblesOnFloor;
    }
	}
}
