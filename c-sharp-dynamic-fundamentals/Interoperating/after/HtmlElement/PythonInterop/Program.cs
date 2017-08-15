using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDynamic;
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


            HtmlElement image = new HtmlElement("img");


            ScriptScope scope = engine.CreateScope();
            scope.SetVariable("image", image);

            ScriptSource source = engine.CreateScriptSourceFromFile("SetImageAttributes.py");


            WriteLine($"image before Python execution: {image}");

            source.Execute(scope);

            WriteLine($"image after Python execution: {image}");




            WriteLine("Press enter to exit");
            ReadLine();
        }
    }
}
