using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class MulticastDelegates
    {
        private delegate void ProgessChangeNotifier(int percent);

        void WriteToDebug(int percent)
        {
            Debug.WriteLine(percent);
        }

        void WriteToDebugWithMessage(int percent)
        {
            Debug.WriteLine("Progress now at: " + percent);
        }


        [TestMethod]
        public void MulticastExample()
        {
            var progressDelegate = new ProgessChangeNotifier(WriteToDebug);
            Debug.WriteLine("Invoking delegate with a single target method assigned");
            progressDelegate(50);


            progressDelegate += WriteToDebugWithMessage;
            Debug.WriteLine("Invoking delegate with two target methods assigned");
            progressDelegate(50);


            progressDelegate -= WriteToDebug;
            Debug.WriteLine("Invoking delegate with first target method removed");
            progressDelegate(50);
        }









        private delegate int MathOperation(int a, int b);
        
        private int Add(int a, int b)
        {
            Debug.WriteLine("Add called");
            return a + b;
        }
        
        private int Multiply(int a, int b)
        {
            Debug.WriteLine("Multiply called");
            return a * b;
        }


        [TestMethod]
        public void MulticastReturnValues()
        {
            var mathDelegate = new MathOperation(Add);

            mathDelegate += Multiply;

            var result = mathDelegate(10, 10);
        }
        
   
    }   
}