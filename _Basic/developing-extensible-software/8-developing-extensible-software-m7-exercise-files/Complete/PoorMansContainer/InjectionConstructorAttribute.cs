using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PoorMansContainer
{
    [AttributeUsage(AttributeTargets.Constructor)]
    public class InjectionConstructorAttribute : Attribute
    {

    }
}
