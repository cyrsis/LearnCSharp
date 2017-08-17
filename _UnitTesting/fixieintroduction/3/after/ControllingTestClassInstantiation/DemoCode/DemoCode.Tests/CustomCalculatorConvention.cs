using Fixie;

namespace DemoCode.Tests
{
    class CustomConvention : Convention
    {
        public CustomConvention()
        {
            Classes.NameEndsWith("Checks");


            //ClassExecution.CreateInstancePerCase(); // This is default
            
            ClassExecution.CreateInstancePerClass();



            Methods.Where(method => method.IsPublic || method.IsAsync());           
        }
    }         
}
