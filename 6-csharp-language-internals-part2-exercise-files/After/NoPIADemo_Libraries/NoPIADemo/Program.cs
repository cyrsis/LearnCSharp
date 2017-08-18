using Lib1;
using Lib2;
using System;

namespace NoPIADemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Stuff.NewWord();

            MoreStuff.NewDocument(word);

            Console.ReadLine();
            Stuff.QuitWord(word);
        }
    }
}
