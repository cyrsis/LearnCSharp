using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.Types.AddToInterface
{
	/* •—————————————————————————————————————————————————————————•
	    Feature: Add to Interface
         
	    Use Case: Adds a method to an interface implemented by 
	    the current class.
	 
			Available: When the cursor is on a method name within the 
	    method declaration, provided that the current class 
	    implements an interface that does not include the method. 
		 •—————————————————————————————————————————————————————————• */
	public interface ILogger
	{
		void Log(string Message);
	}
	public class MySpecialLogger : ILogger
	{
		public void Log(string Message)
		{
		}
		public void Log(string Message, DateTime TimeStamp)
		{
		}
	}
}
