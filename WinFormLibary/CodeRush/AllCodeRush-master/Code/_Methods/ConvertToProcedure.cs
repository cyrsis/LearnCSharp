using System;

namespace AllCodeRush.Code.Methods
{
  /* •———————————————————————————————————————————————————————•
    	Feature: Convert to Procedure

      Use Case: Converts a function into a void proc (or a 
      sub in VB).
            
    	Available: When the caret is on the name of a function.
   
      See also: Convert to Function, Reorder Parameters
     •———————————————————————————————————————————————————————• */
  public class ConvertToProcedure
  {
    private string Delimit(string[] args, char delimiter, out string result)
    {
      result = string.Empty;
      foreach (string arg in args)
        result += arg + delimiter;
      result.Trim(delimiter);
      return result;
    }

    public string CommaDelimit(string[] args)
    {
      string result;
      Delimit(args, ',', out result);
      return result;
    }
  }
}
