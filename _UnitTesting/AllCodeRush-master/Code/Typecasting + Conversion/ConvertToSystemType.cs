using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.TypecastingConversion
{
	/* •—————————————————————————————————————————————————————————•
			Feature: Convert To System Type
	         
			Use Case: Replaces a language-specific type identifier to 
	    the corresponding .NET Framework type.
	    For example, this refactoring will convert int (or Integer
	    in VB) to System.Int32 in C#.
		 
			Available: When the caret is on a language-specific type 
	    identifier.
		•—————————————————————————————————————————————————————————• */

	// Does not seem to be available here.
	public class ConvertToSystemType
	{
		public int CalculateLevelScore(int BaseScore, int Level)
		{
			return Level * BaseScore;
		}
		private string GetName(string Firstname, string Lastname)
		{
			return Firstname + ' ' + Lastname;
		}
	}
}
