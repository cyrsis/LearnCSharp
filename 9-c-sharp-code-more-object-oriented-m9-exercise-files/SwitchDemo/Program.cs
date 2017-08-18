using System;
using SwitchDemo.Common;
using SwitchDemo.Common.Interfaces;

namespace SwitchDemo
{
    class Program
    {

        static void Main(string[] args)
        {

            IOption<string> name = Option<string>.Some("something");

            name
                .When(s => s.Length > 3).Do(s => Console.WriteLine($"{s} long"))
                .WhenSome().Do(s => Console.WriteLine($"{s} short"))
                .WhenNone().Do(() => Console.WriteLine("missing"))
                .Execute();

            string label =
                name
                    .When(s => s.Length > 3).MapTo(s => s.Substring(0, 3) + ".")
                    .WhenSome().MapTo(s => s)
                    .WhenNone().MapTo(() => "<empty>")
                    .Map();

            Console.WriteLine(label);

            Console.ReadLine();

        }
    }
}
