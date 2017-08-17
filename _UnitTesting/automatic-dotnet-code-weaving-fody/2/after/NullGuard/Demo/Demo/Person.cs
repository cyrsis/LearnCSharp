using System;
using NullGuard;

namespace Demo
{
    #region
    [NullGuard(ValidationFlags.All)]
    #endregion
    public class Person
    {
        [AllowNull]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string HomeTown { get; set; }

        public void DoSomething([AllowNull] string someParameter)
        {
            // etc.
        }
      
 
        [return: AllowNull]
        public string SomeMethod()
        {
            return null;
        }
        
    }
}
