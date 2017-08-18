using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.ExtensionLibrary.Tests.Stubs.WcfService;
using System;
using System.Diagnostics;

namespace Sixeyed.ExtensionLibrary.Tests.Demo4
{
    [TestClass]
    public class WcfClientTests
    {
        [TestMethod]
        public void Call()
        {
            var response = string.Empty;
            using (var client = new Service1Client())
            {
                response = client.GetData(10);
            }
            Assert.AreEqual("You entered: 10", response);
        }

        [TestMethod]
        public void CallWithException_InUsingBlock()
        {
            var response = new CompositeType();
            using (var client = new Service1Client())
            {
                try
                {
                    response = client.GetDataUsingDataContract(null);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.FullMessage());
                }

            }
        }

        [TestMethod]
        public void CallWithException()
        {
            var response = new CompositeType();
            var client = new Service1Client();
            try
            {
                response = client.GetDataUsingDataContract(null);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.FullMessage());
            }
            finally
            {
                ((IDisposable)client).Dispose();
            }
        }

        [TestMethod]
        public void CallWithDisposeSafely()
        {
            var response = new CompositeType();
            var client = new Service1Client();
            try
            {
                response = client.GetDataUsingDataContract(null);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.FullMessage());
            }
            finally
            {
                client.DisposeSafely();
            }
        }
    }
}
