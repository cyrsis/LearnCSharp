using System;
using System.IO;

namespace AllCodeRush.Code.DeclarationInitialization
{
  /* •———————————————————————————————————————————————————————•
      Feature: Make Explicit
        
      Use Case: Converts an implicitly-typed local variable 
      to a variable declared with an explicit type.
         
      Available: When the caret is on an implicit variable 
      declaration.
        
      See also: Make Implicit, Make Explicit (and Name 
      Anonymous Type)
     •———————————————————————————————————————————————————————• */

  public class MakeExplicit
	{
    public string GetParentFolder(string fileName)
    {
      var parent = Directory.GetParent(Path.GetFullPath(fileName));

      return parent.FullName;
    }
	}
}
