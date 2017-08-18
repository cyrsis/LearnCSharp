using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class ParamsExample
    {

        private void WriteDebug(string message, params object[] objects)
        {
            Debug.WriteLine(message);

            foreach (var o in objects)
            {
                Debug.WriteLine(o);
            }
        }

        
        [TestMethod]
        public void WriteDebugExample()
        {
            WriteDebug("* Some different objects *", 42, new Uri("http://pluralsight.com"), true);

            WriteDebug("* No objects *");
        }



        private IEnumerable<int> CalcStringLengths(params string[] strings)
        {
            foreach (var s in strings)
            {
                yield return s.Length;
            }
        }


        [TestMethod]
        public void CalcStringLengthsExample()
        {
            foreach (var len in CalcStringLengths("a", "aa", "aaa"))
            {
                Debug.WriteLine(len);
            }
        }



        [TestMethod]
        public void CalcStringLengthsExampleWithArray()
        {
            var names = new[] { "Sarah", "Gentry", "Angelina" };

            foreach (var len in CalcStringLengths(names))
            {
                Debug.WriteLine(len);
            }
        }

    }
}
