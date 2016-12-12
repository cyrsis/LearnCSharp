using System;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Inline Recent Assignment
        
			Use Case: Replaces the identifier at the caret 
			with its most recent assignment.
         
			Available: When the caret is on an variable or a property
      that has been previously assigned in the method body.
   
      See also: Inline Temp
		 •———————————————————————————————————————————————————————• */

	public class InlineRecentAssignment
	{
		private void TestMethod()
		{
      string command;

      if (!NewCommandExists)
        return;

      command = GetActiveCommand();

      if (String.IsNullOrEmpty(command))
        return;
			
			Execute(command);
		}

		#region Support
    public bool NewCommandExists { get; set; }
    private string GetActiveCommand()
		{
			return string.Empty;
		}
		private void Execute(string Command)
		{
			// Execute command here
		}
		#endregion
	}
}
