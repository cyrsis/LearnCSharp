namespace Demos.DemoSupportCode
{
    class SomeClass : ISomeInterface
    {
        // Implicitly implemented
        public void MethodA()
        {            
        }

        // Explicitly implemented
        void ISomeInterface.MethodB()
        {            
        }
    }
}