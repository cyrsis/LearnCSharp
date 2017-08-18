using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using componentModel = System.ComponentModel;

namespace Sixeyed.ExtensionLibrary.Tests.Demo1
{
    [TestClass]
    public class EnumExtensionsTests
    {
        [TestMethod]
        public void GetName()
        {
            var intro = Module.Intro;
            Assert.AreEqual("Intro", intro.ToString());
            Assert.AreEqual("Intro", Enum.GetName(typeof(Module), intro));
        }

        public enum Module
        {
            [componentModel.Description("Introducing Extension Methods")]
            Intro,
            Advanced, 
            Library
        }
    }
}
