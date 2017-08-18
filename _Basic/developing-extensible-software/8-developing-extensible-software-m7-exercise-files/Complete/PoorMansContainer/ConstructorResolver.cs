using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PoorMansContainer
{
    public class ConstructorResolver
    {
        public virtual ConstructorInfo GetConstructor(ConstructorInfo[] constructors)
        {
            return constructors[0];
        }
    }
}
