using System;
using EmptyStringGuard;

namespace Demo
{
    #region
    // [EmptyStringGuard(ValidationFlags.All)]
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
                if (value == "")
                {
                    throw new ArgumentException("FirstName cannot be empty");
                }

                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("LastName cannot be empty");
                } 
                
                _lastName = value;
            }
        }

        public string HomeTown
        {
            get { return _homeTown; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("HomeTown cannot be empty");
                }

                _homeTown = value;
            }
        }

        public void DoSomething(string someParameter)
        {
            if (someParameter == "")
            {
                throw new ArgumentException("someParameter cannot be empty");
            }

            // etc.
        }
    }
}
