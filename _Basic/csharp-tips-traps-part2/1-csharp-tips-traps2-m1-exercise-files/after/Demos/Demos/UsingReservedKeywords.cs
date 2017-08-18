using Microsoft.VisualStudio.TestTools.UnitTesting;
using VBClassLibrary;

namespace Demos
{
    [TestClass]
    public class UsingReservedKeywords
    {
        
        [TestMethod]
        public void AsVariableNames()
        {
            var @namespace = "hello";

            @namespace += " world";
        }











        [TestMethod]
        public void InteropWithOtherLanguages()
        {
            var a = new @abstract();

            a.@foreach = "hello";

            a.@foreach += " world";
        }

    }   
}