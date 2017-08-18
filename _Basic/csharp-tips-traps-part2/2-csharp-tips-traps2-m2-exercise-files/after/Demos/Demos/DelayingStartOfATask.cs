using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class DelayingStartOfATask
    {
        
        [TestMethod]
        public void Example()
        {
            Task.Delay(5000).GetAwaiter().OnCompleted(() => Debug.WriteLine("a"));
            
            Task.Delay(6000).GetAwaiter().OnCompleted(() => Debug.WriteLine("b"));           
            
            Task.Delay(7000).GetAwaiter().OnCompleted(() => Debug.WriteLine("c"));
            
            
            Thread.Sleep(10000);
        }          
    }   
}