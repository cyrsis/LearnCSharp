using System;
using System.Diagnostics;
using Fixie;

namespace DemoCode.Tests
{
    internal class CustomConvention : Convention
    {
        public CustomConvention()
        {
            Classes.NameEndsWith("Checks");

            Methods.Where(method => method.IsPublic || method.IsAsync());

          
        }
    }
}