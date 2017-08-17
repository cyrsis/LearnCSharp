using System;
using NullGuard;

namespace Demo
{
    #region
    // [NullGuard(ValidationFlags.All)]
    #endregion
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _homeTown;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("FirstName");
                }

                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("LastName");
                }
                
                _lastName = value;
            }
        }

        public string HomeTown
        {
            get { return _homeTown; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("HomeTown");
                }

                _homeTown = value;
            }
        }

        public void DoSomething(string someParameter)
        {
            if (someParameter == null)
            {
                throw new ArgumentNullException("someParameter cannot be null");
            }

            // etc.
        }
      
 
        //[return: AllowNull]
        public string SomeMethod()
        {
            return null;
        }
        
    }
}
