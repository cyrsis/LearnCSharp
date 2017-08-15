using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;


namespace PythonInterop
{
    class Program
    {
        static void Main(string[] args)
        {
            ScriptEngine engine = Python.CreateEngine();

            string simpleExpression = "2 + 2";

            dynamic dynamicResult = engine.Execute(simpleExpression);
            //int typedResult = engine.Execute<int>(simpleExpression);

            WriteLine($"Expression result: {dynamicResult}");




            WriteLine("Press enter to exit");
            ReadLine();
        }
    }
}
