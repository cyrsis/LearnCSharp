using System;

namespace AllCodeRush.Code.Expressions
{
  /* •———————————————————————————————————————————————————————•
      Feature: Replace With Constant
          
      Use Case: Replaces an expression with a reference 
      to a constant with the same value.
           
      Available: When the caret is on a primitive and the 
      active type declares a constant initialized to the 
      same value.
          
      See also: Replace With Local, Introduce Constant
     •———————————————————————————————————————————————————————• */

  public class ReplaceWithConstant
	{
    const string STR_Settings = "Settings";

    public void SaveStr(string key, string value)
		{
      Storage.SaveString("Settings", key, value);
		}

    public string GetStr(string key)
    {
      return Storage.GetString("Settings", key);
    }
	}
}
