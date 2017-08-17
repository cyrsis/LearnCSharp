using System;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Introduce Result Variable
        
			Use Case: Introduces a variable to accept a 
			value, replacing early-exit return statements with 
			assignments to the variable and consolidating multiple 
			method exit points into a single exit point.
         
			Available: When the caret is on a return statement.
        
			See also: Inline Result
		 •———————————————————————————————————————————————————————• */

	public class IntroduceResultVariable
	{
    public enum NamePart
    {
      Given,
      Surname,
    }

    public string GetName(string fullName, NamePart namePart, bool allUpper)
		{
      int spacePos = fullName.IndexOf(' ');

      switch (namePart)
      {
        case NamePart.Surname:
          return fullName.Substring(spacePos + 1);
        default:
          return fullName.Substring(0, spacePos);
      }
		}
	}
}
