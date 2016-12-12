using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.Types
{
	/* •—————————————————————————————————————————————————————————•
	    Feature: Create Descendant (With Virtual Overrides)
         
	    Use Case: Creates a descendant class, providing 
	    implementation stubs for abstract members of a base class. 
	 
			Available: When the caret is on a class name within its 
	    declaration.  
		 •—————————————————————————————————————————————————————————• */

	// Note: Change settings to generate class in same file for this demo.

	public class CreateDescendantWithVirtualOverrides
	{
		public virtual void Method1()
		{
		}
		public virtual void Method2()
		{
		}
	}
}
