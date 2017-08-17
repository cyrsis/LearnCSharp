using System.Collections.Generic;
using static System.Console;

namespace LinearSearch
{
    class Program
    {
        public static void Main()
        {
            List<string> actors = new List<string>();

            actors.Add("Tom Cruise");
            actors.Add("Madonna");
            actors.Add("Bruce Lee");
            actors.Add("Jimmy Fallon");

            WriteLine("Linear search results: \n\nIn the collection, there are {0} actors:", actors.Count);
            PrintOut(actors);

            WriteLine("\nOf which, the IndexOf(\"Madonna\") is {0}",
                actors.IndexOf("Madonna"));

        }

        private static void PrintOut(List<string> cs)
        {
            WriteLine();
            foreach (string item in cs)
            {
                WriteLine(item);
            }
        }
    }
}
