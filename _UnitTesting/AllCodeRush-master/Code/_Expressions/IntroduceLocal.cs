using System;
using System.Drawing;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Introduce Local
        
			Use Case: Creates a new local variable 
			initialized with the selected expression.
         
			Available: When an expression is selected.
        
			See also: Inline Local, Introduce Local (Replace All)
		 •———————————————————————————————————————————————————————• */

	public class IntroduceLocal
	{
		public double GetDistanceBetweenPoints(Point pt1, Point pt2)
		{
      return Math.Sqrt(Math.Pow(pt2.X - pt1.X, 2) + Math.Pow(pt2.Y - pt1.Y, 2));
		}
	}
}
