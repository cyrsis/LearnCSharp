using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.Types.CreateImplementerExplicit
{
	/* •—————————————————————————————————————————————————————————•
	    Feature: Create Implementer (Explicit)
         
	    Use Case: Creates a class explicitly implementing a 
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
