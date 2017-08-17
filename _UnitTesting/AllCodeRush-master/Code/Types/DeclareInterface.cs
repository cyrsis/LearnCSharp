using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.Types.DeclareInterface
{
	/* •—————————————————————————————————————————————————————————•
			Feature: Declare Interface
         
			Use Case: Generates an interface for the current type 
	    reference.  
	 
			Available: When the edit cursor or caret is on a type 
	    reference whose name begins with I.
		 •—————————————————————————————————————————————————————————• */
	public class DeclareInterface
	{
		public DeclareInterface()
		{
			ILogger Logger = new Logger();
			Logger.Log("Starting");
			Process1();
			Logger.Log("Stage 1 Complete");
			try
			{
				UnreliableProcess();
			}
			catch (Exception ex)
			{
				Logger.Error("Error during Stage 2", ex);
				throw;
			}
			Logger.Log("Stage 2 Complete");
			Logger.Log("Finished");
		}

		#region Support
		private void Process1()
		{
			throw new NotImplementedException();
		}
		private void Process2()
		{
			throw new NotImplementedException();
		}
		private void UnreliableProcess()
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
