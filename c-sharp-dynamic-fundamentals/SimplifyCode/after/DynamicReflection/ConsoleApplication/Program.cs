using System.Reflection;
using System.Text;
using static System.Console;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            InvokeMethodUsingReflection();
            InvokeMethodUsingDynamic();

            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }

        private static void InvokeMethodUsingReflection()
        {
            StringBuilder sb = new StringBuilder();

            sb.GetType()
                .InvokeMember("AppendLine",
                    BindingFlags.InvokeMethod,
                    null,
                    sb,
                    new object[] {"Hello reflection!"});

            WriteLine(sb);
        }


        private static void InvokeMethodUsingDynamic()
        {
            StringBuilder sb = new StringBuilder();

            ((dynamic) sb).AppendLine("Hello dynamic!");

            WriteLine(sb);
        }
    }
  
}
