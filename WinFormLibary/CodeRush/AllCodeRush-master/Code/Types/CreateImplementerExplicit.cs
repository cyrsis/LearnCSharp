using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.Types.CreateImplementerImplicit
{
	/* •—————————————————————————————————————————————————————————•
	    Feature: Create Implementer (Implicit)
         
	    Use Case: Creates a class implicitly implementing a 
	    current interface.
	 
			Available: When the caret is on an interface name within 
	    an interface declaration.  
		 •—————————————————————————————————————————————————————————• */
	public interface ILogger
	{
		void Log(string Message);
		bool Enabled { get; set; }
	}
}
