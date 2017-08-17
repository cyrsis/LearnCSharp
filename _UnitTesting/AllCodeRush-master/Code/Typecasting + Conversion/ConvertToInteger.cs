using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.TypecastingConversion
{
	/* •—————————————————————————————————————————————————————————•
			Feature: Convert To Integer
	         
			Use Case: Rounds the value of an expression at the caret
	    to an integer, using a call to one of several available 
	    methods, and generates an integer type-cast expression.
		 
			Available: When the caret is on an expression of decimal, 
	    Single, double, or float type.
		•—————————————————————————————————————————————————————————• */

	public static class Grader
	{
		private int GetApproxSphereVolume(double radius)
		{
			return Math.PI * Math.Pow(radius, 3);
		}
	}
}
