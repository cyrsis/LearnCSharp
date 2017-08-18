using System;
using System.Collections.Generic;

namespace MyComponent
{
    public sealed class Class1
    {
        public IList<string> GetStuff()
        {
            return new[] { "bar", "foo" };
        }
    }
}
