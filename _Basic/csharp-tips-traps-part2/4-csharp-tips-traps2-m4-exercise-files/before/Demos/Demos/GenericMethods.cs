using System;
using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class GenericMethods
    {
        [TestMethod]
        public void Example()
        {
            var dw = new DebugWriter();

            var d = DateTime.Now;

            dw.WriteToDebug(d);

            var m = new Movie();

            dw.Write(m);

            // dw.Write(s); // string is not convertible to IExtraDebuggable           
        }
    }  
}