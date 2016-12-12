using System;

namespace AllCodeRush.Code.DeadCode
{
	/* •———————————————————————————————————————————————————————•
		  Feature: Remove Redundant Constructor.
        
		  Use Case: Removes an empty constructor.

	    Available: When the caret is on a constructor declaration. 
	    Requires that the constructor is empty and has no 
	    parameters. 
	   •—————————————————————————————————————————————————————————• */

	public class RemoveRedundantConstructor
	{
		public RemoveRedundantConstructor()
		{
			// This constructor is equivalent to a default constructor.
			// It has no content and takes no arguments.
		}
	}
}
