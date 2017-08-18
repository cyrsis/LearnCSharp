// Download IronPython from http://ironpython.net
using IronPython.Hosting;
using System;

namespace PythonInterop
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = Python.CreateEngine();

            var python =
@"
def Add(a, b):
  return a + b;
";

            var source = engine.CreateScriptSourceFromString(python);

            var scope = engine.CreateScope();

            source.Execute(scope);

            dynamic scope2 = scope;

            var x = scope2.Add(1, 2);
            var y = scope2.Add("Hello, ", "World");
            var z = scope2.Add(DateTime.Now, TimeSpan.FromHours(1));

            var v = scope2.Add(new Vector(), new Vector());
        }
    }

    public class Vector
    {
        public static Vector operator +(Vector v1, Vector v2)
        {
            return v1;
        }
    }
}
