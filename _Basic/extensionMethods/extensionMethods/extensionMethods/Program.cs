using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int messages = 1;
            //Console.WriteLine("You have {0}.", StringHelpers.SmartPlural(messages, "message", "messages"));
            Console.WriteLine("You have {0}.", messages.SmartPlural("message", "messages"));

            Console.WriteLine("You can type \"order\" or \"purchase\" but do not use the word \"contract\"");
            Console.WriteLine("You can type 'order' or 'purchase' but do not use the word 'contract'".Quotes());

            Console.WriteLine("Files:".Indent(1));
            Console.WriteLine("Reports".Indent(2));
            Console.WriteLine("Letters".Indent(2));


            string title = "C# Cookbook";
            string description = "This is a good book";
            Console.WriteLine("{0}: {1}", title, description);
            string printLine = String.Format("{0}: {1}", title, description);
            Console.WriteLine(printLine);

            string printLine2 = "'{0}': {1}".FormatWith(title, description).ToUpper().Quotes().Indent(2);
            Console.WriteLine(printLine2);
         
            Console.ReadLine();
        }
    }

    public static class StringHelpers
    {
        public static string SmartPlural(this int howMany, string singular, string plural)
        {
            if (howMany == 1)
                return "1 " + singular;
            else
                return howMany.ToString() + " " + plural;
        }

        public static string Quotes(this string line)
        {
            return line.Replace("'", "\"");
        }

        public static string Indent(this string line, int tabs = 1)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < tabs; i++)
            {
                sb.Append('\t');
            }
            sb.Append(line);
            return sb.ToString();
        }


        public static string FormatWith(this string format, params object[] args)
        {
            if (format == null)
                throw new ArgumentNullException("format");
            return string.Format(format, args);
        }

    }

}
