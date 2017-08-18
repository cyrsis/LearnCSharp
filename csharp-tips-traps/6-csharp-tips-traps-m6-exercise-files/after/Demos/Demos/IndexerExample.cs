using System.Collections.Generic;
using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class IndexerExample
    {

        [TestMethod]
        public void ExampleUseInFramework()
        {
            var names = new List<string>
                            {
                                "Sarah",
                                "Gentry"
                            };

            // get the second item in the list using List's indexer
            var gentry = names[1];
        }








        [TestMethod]
        public void UsingAnIndexer()
        {
            var bigFile = new DemoFileArray(@"c:\temp\largefile.bin");

            // get a byte value using the indexer
            byte valueAtOffset = bigFile[999999];
          
            valueAtOffset++; // assumes value will not exceed byte.MaxValue

            // set a byte value using the indexer
            bigFile[999999] = valueAtOffset;
        }











        [TestMethod]
        public void BadExample()
        {
            var sarah = new Student();

            var secondExamScore = sarah[1];
        }

    }
}
