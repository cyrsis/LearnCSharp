using System;

namespace AllCodeRush.Code.DeadCode
{
	/* •———————————————————————————————————————————————————————•
		  Feature: Remove Redundant Destructor.
        
		  Use Case: Removes an empty destructor.

	    Available: When the caret is at an empty destructor 
      declaration.
	   •—————————————————————————————————————————————————————————• */
	public class RemoveRedundantDestructor
	{
		~RemoveRedundantDestructor()
		{
			// This destructor serves no purpose.
		}
	}
}
