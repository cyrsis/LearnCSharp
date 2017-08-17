using System;
using EmptyStringGuard;

namespace Demo
{
    #region
    [EmptyStringGuard(ValidationFlags.Methods)]
    #endregion
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string HomeTown { get; set; }

        public void DoSomething(string someParameter)
        {
            // etc.
        }
    }
}
