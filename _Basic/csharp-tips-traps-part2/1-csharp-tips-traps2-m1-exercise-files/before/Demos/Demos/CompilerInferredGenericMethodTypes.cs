using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class CompilerInferredGenericMethodTypes
    {
        [TestMethod]
        public void Example()
        {
            const string name = "Sarah";
            const int age = 42;


            WriteToDebug<string>(name);
            WriteToDebug<int>(age);
        }


        void WriteToDebug<T>(T obj)
        {
            Debug.WriteLine(obj);
        }


        //void WriteToDebug(string s)
        //{
        //    Debug.WriteLine(s);
        //}

    }
}