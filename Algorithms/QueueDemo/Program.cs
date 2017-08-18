using System;
using System.Collections.Generic;
using static System.Console;

/// <summary>
/// We have here code example demonstrates several methods of the 
/// Queue class
/// </summary>
namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoQueue();
        }

        private static void DemoQueue()
        {
            Queue<string> movies = new Queue<string>();
            movies.Enqueue("Ace Ventura");
            movies.Enqueue("Batman");
            movies.Enqueue("Cable Guy");
            movies.Enqueue("Dallas Buyers Club");
            movies.Enqueue("East of Eden");
            
            WriteLine("Default content of Queue");

            foreach (string movie in movies)
            {
                WriteLine(movie);
            }

            WriteLine("\nDequeuing '{0}'", movies.Dequeue());
            WriteLine("The next item to dequeue using peek: {0}",
                movies.Peek());
            WriteLine("Dequeuing '{0}'", movies.Dequeue());

            Queue<string> queueCopy = new Queue<string>(movies.ToArray());

            WriteLine("\nContents of the first copy:");
            foreach (string movie in queueCopy)
            {
                WriteLine(movie);
            }

            string[] array2 = new string[movies.Count * 2];
            movies.CopyTo(array2, movies.Count);

            Queue<string> queueCopy2 = new Queue<string>(array2);

            WriteLine("\nContents of the second copy, with duplicates and" +
                      " nulls:");
            foreach (string movie in queueCopy2)
            {
                WriteLine(movie);
            }

            WriteLine("\nqueueCopy.Contains(\"Dallas Buyers Club\") = {0}",
                queueCopy.Contains("Dallas Buyers Club"));

            WriteLine("\nqueueCopy.Clear()");
            queueCopy.Clear();
            WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);
        }

    }
}
