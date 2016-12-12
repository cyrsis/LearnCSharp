using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.Types
{
	/* •—————————————————————————————————————————————————————————•
			Feature: Seal Class
	         
			Use Case: Makes the current class sealed (uninheritable).
		 
			Available: When the caret is on a class declaration. 
	    Unavailable if class is an ancestor of another class.
		•—————————————————————————————————————————————————————————• */

	// This class can be sealed.
	public class SimpleClass : Ancestor
  {

	}

	// This class cannot be sealed.
	public class Ancestor
	{
		
	}
}
