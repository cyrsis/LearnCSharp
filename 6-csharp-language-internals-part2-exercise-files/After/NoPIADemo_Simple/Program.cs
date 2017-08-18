using Microsoft.Office.Interop.Word;
using System;

namespace NoPIADemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compile with "Embed Interop Types" set for
            // the Microsoft.Office.Interop.Word PIA.

            var app = new Application();
            app.Visible = true;
            Console.ReadLine();
            app.Quit();
        }
    }
}
