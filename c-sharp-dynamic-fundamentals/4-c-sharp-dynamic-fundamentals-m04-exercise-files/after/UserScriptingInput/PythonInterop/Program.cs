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

            int customerAge = 42;

            WriteLine("Please enter an expression (use token 'a' for customer age) and press enter");
            string expression = ReadLine();

            ScriptScope scope = engine.CreateScope();
            scope.SetVariable("a", customerAge);

            ScriptSource source = 
                engine.CreateScriptSourceFromString(expression, SourceCodeKind.Expression);

            dynamic dynamicResult = source.Execute(scope);
            //int typedResult = engine.Execute<int>(simpleExpression);

            WriteLine($"Expression result: {dynamicResult}");




            WriteLine("Press enter to exit");
            ReadLine();
        }
    }
}
