using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class CompatibilityAndEqualityOfDelegates
    {
        private delegate void ADelegateWithAnInt(int i);
        private delegate void AnotherDelegateWithAnInt(int i);

        void WriteToDebug(int percent)
        {            
        }

        void WriteToDebugWithMessage(int percent)
        {
        }





        [TestMethod]
        public void CompatibilityOfDelegateTypes()
        {
            //ADelegateWithAnInt a = new ADelegateWithAnInt(WriteToDebug);            
            ADelegateWithAnInt a = WriteToDebug;

            AnotherDelegateWithAnInt b;


            // This will not compile
            // b = a; 

            // nor this
            // b = (AnotherDelegateWithAnInt) a;

            b = new AnotherDelegateWithAnInt(a);
        }









        [TestMethod]
        public void EqualityOfDelegateInstances()
        {            
            ADelegateWithAnInt a = WriteToDebug;            
            ADelegateWithAnInt b = WriteToDebug;            
            ADelegateWithAnInt c = WriteToDebugWithMessage; 

            var isInstanceAEqualToB = a == b;

            var isInstanceAEqualToC = a == c;       
        }              
    }   
}