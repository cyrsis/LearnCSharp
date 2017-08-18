using System.Diagnostics;
using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class CallerInfoAttributesExample
    {
        [TestMethod]
        public void ExampleFooMethod()
        {
            var c = new CallerInfoAttributeDemo();

            Debug.WriteLine(c.WhoCalledMe());

            Debug.WriteLine(c.WhatFileCalledMe());

            Debug.WriteLine(c.WhatLineCalledMe());
        }
    }
}