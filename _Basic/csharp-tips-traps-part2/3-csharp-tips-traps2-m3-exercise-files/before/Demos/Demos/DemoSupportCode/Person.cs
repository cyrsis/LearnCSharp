using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Demos.DemoSupportCode
{
    // [DebuggerTypeProxy(typeof (PersonDebugProxy))]
    public class Person
    {
        private readonly string _name;

        public Person(string name)
        {
            _name = name;
            FavouriteColors = new SortedList<int, string>();
        }

        public int Age { get; set; }
        public SortedList<int, string> FavouriteColors { get; set; }

        // Internal nested class so we can access the internals of the object being proxied
        private class PersonDebugProxy
        {
            private readonly Person _objectToProxy;

            public PersonDebugProxy(Person objectToProxy)
            {
                _objectToProxy = objectToProxy;
            }

            public string PersonalDetails
            {
                get
                {
                    return string.Format("{0}, {1} years old",
                                                    _objectToProxy._name,
                                                    _objectToProxy.Age);
                }
            }

            public string MostFavouriteColor
            {
                get
                {
                    if (_objectToProxy.FavouriteColors.Any())
                    {
                        return _objectToProxy.FavouriteColors.First().Value;
                    }

                    return "No favourite colors";
                }
            }
        }
    }
}