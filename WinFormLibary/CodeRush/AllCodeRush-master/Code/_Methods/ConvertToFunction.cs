using System;

namespace AllCodeRush.Code.Methods
{
  /* •———————————————————————————————————————————————————————•
  		Feature: Convert to Function
    
			Use Case: Converts a void proc (or a sub in VB) into a 
      function.
          
  		Available: When the caret is on the return keyword of a 
      return statement that returns a value.
  	 •———————————————————————————————————————————————————————• */
  public class ConvertToFunction
  {
    public static void GetFullName(string first, string last)
    {
      return first + " " + last;
    }
  }

  

}
