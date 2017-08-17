using System;

namespace AllCodeRush.Code.Methods
{
  /* •———————————————————————————————————————————————————————•
      Feature: Declare Method (Abstract)
        
      Use Case: Lets you generate an abstract method where 
      none exists, based on an existing call to that method.
         
      Available: When the caret is on a statement calling an 
      undeclared method.
        
      See also: Declare Method
     •———————————————————————————————————————————————————————• */

  public abstract class Prism
	{
    protected double depth;
    public double CalculateVolume(double containingWidth, double containingHeight)
		{
			return CalculateBase(containingWidth, containingHeight) * depth;
		}
	}
}
