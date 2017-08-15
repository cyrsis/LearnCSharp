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

            string tupleStatement = "customer = ('Sarah', 42 , 200)";

            ScriptScope scope = engine.CreateScope();
            ScriptSource source =
                engine.CreateScriptSourceFromString(tupleStatement, SourceCodeKind.SingleStatement);

            source.Execute(scope);

            dynamic pythonTuple = scope.GetVariable("customer");

            WriteLine(
                $"Name = {pythonTuple[0]} Age = {pythonTuple[1]} Height = {pythonTuple[2]}");




            WriteLine("Press enter to exit");
            ReadLine();
        }
    }
}
