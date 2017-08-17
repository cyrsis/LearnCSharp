using System;
using System.Diagnostics;

namespace Demos.DemoSupportCode
{
    class ExceptionRethrowWidget
    {
        public void NoStacktrace()
        {
            try
            {
                MethodA();
            }
            catch (Exception ex)
            {
                // do some logging, etc...
                Debug.WriteLine(ex);

                throw ex;
            }
        }


        public void WithStacktrace()
        {
            try
            {
                MethodA();
            }
            catch (Exception ex)
            {
                // do some logging, etc...
                Debug.WriteLine(ex);

                throw;
            }
        }


        private void MethodA()
        {
            MethodB();
        }

        private void MethodB()
        {
            MethodC();
        }

        private void MethodC()
        {
            throw new ApplicationException("This is a demo exception.");
        }
    }
}
