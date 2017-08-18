using System.Diagnostics;

namespace Demos.DemoSupportCode
{
    [DebuggerDisplay("This person is called {Name} and is {AgeInYears} years old")]
    class PersonWithDebuggerDisplay
    {
        [DebuggerDisplay("{AgeInYears} years old")]
        public int AgeInYears { get; set; }
       
        public string Name { get; set; }
    }
}
