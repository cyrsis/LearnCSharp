using System;
using System.Collections.Generic;

namespace AllCodeRush.Code.DeclarationInitialization
{
  /* •———————————————————————————————————————————————————————•
      Feature: Declare Local
        
      Use Case: Consume-first declares undeclared local 
      variables.
         
      Available: When the caret is on an undeclared variable 
      reference or expression.
   
      Related Features: Remove Type Qualifier
     •———————————————————————————————————————————————————————• */

  public class DeclareLocal
	{
    public double CalculateCircleArea(double radius)
		{
      return radius * radius * pi;
		}

    public void GetFiles(string path)
    {
      // Use Intellisense to get you this: "System.IO.Directory.EnumerateFiles(path)"
    }
	}
}
