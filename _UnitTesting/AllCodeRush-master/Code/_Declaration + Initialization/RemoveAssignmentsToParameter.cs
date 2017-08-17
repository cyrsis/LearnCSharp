using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
  /* •———————————————————————————————————————————————————————•
      Feature: Remove Assignments to Parameter
        
      Use Case: Prevents input parameters from being modified, 
      which can lead to code that is easier to read and 
      easier to refactor.
        
      Available: When the caret is on a parameter declaration 
      or reference provided that the parameter has an assignment 
      within the method's body.
     •———————————————————————————————————————————————————————• */

  public class RemoveAssignmentsToParameter
	{
    public string GetFullName(string first, string last)
		{
      if (!String.IsNullOrEmpty(first) && !String.IsNullOrEmpty(last))
        first = first + " " + last;
      else if (String.IsNullOrEmpty(first))
        first = last;

			return first;
		}
	}
}
