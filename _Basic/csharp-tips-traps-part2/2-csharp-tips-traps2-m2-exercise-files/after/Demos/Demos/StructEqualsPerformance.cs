using System.Diagnostics;
using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class StructEqualsPerformance
    {
        
        [TestMethod]
        public void ReferenceTypeMembersAndEqualsPerformance()
        {
            var nr1 = new NoRefNoOverride { X = 1, Y = 2 };
            var nr2 = new NoRefNoOverride { X = 1, Y = 2 };

            var wr1 = new WithRefNoOverride { X = 1, Y = 2, Description = "struct wr1" };
            var wr2 = new WithRefNoOverride { X = 1, Y = 2, Description = "struct wr2" };
            

            var timeWithoutReferenceMember = CalculateEqualsPerformance(nr1, nr2);
            var timeWithReferenceMember = CalculateEqualsPerformance(wr1, wr2);
        }

        // MSDN: "If none of the fields of the current instance and obj are reference types, 
        // the Equals method performs a byte-by-byte comparison of the two objects 
        // in memory. Otherwise, it uses reflection to compare the corresponding fields 
        // of obj and this instance." 
        // - http://bit.ly/pscsequals








        [TestMethod]
        public void ReferenceTypeMembersAndOverriddenEquals()
        {
            var wo1 = new WithRefNoOverride { X = 1, Y = 2, Description = "struct wo1" };
            var wo2 = new WithRefNoOverride { X = 1, Y = 2, Description = "struct wo2" };

            var w1 = new WithRefWithOverride { X = 1, Y = 2, Description = "struct w1" };
            var w2 = new WithRefWithOverride { X = 1, Y = 2, Description = "struct w2" };


            var timeWithNoOverriddenEquals = CalculateEqualsPerformance(wo1, wo2);
            var timeWithOverriddenEquals = CalculateEqualsPerformance(w1, w2);
        }


        // MSDN: "Particularly if your value type contains fields that are reference types, 
        // you should override the Equals(Object) method. This can improve performance 
        // and enable you to more closely represent the meaning of equality for the type."
        // - http://bit.ly/pscsequals







        private long CalculateEqualsPerformance(object p1, object p2)
        {
            var sw = Stopwatch.StartNew();
            
            for (var i = 0; i < 10000000; i++)
            {
                p1.Equals(p2);
            }

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }
    }   
}