using System;

namespace AllCodeRush.Code.Methods
{
  /* •————————————————————————————————————————————————————————•
      Feature: Safe Rename
              
      Use Case: Renames an externally-accessible member 
      without breaking external code. Useful when changes to 
      an API are needed, and that API is consumed by 
      developers outside your team or your company.
               
      Available: When the caret is at a public method 
      declaration.
     •————————————————————————————————————————————————————————• */
  public class SafeRename
  {
    public bool IsNotNullAndIsNotEmpty(Person person, AuthenticationCode code)
    {
      if (person == null)
        return false;
      if (code == null)
        return false;
      if (code.IsStale)
        return false;
      if (String.IsNullOrEmpty(person.First))
        return false;
      if (String.IsNullOrEmpty(person.Last))
        return false;
      if (String.IsNullOrEmpty(person.Address))
        return false;
      if (String.IsNullOrEmpty(person.Phone))
        return false;

      return true;
    }
  }
}
