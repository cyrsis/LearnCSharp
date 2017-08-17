using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
  /* •———————————————————————————————————————————————————————•
      Feature: Declare Local (implicit)
        
      Use Case: Consume-first declares undeclared local 
      variables.
         
      Available: When the caret is on an undeclared variable 
      reference or expression.
   
      Related Features: Remove Type Qualifier
     •———————————————————————————————————————————————————————• */

  public class DeclareLocalImplicit
  {
    public void GetFolders(string path)
    {
      // Use Intellisense to get you this: "System.IO.Directory.GetDirectories(path)"
    }
  }

}
