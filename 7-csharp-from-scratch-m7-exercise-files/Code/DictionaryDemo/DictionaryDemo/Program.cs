using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> capitals = new Dictionary<string, string>();
            //capitals.Add("Alabama", "Montgomery");
            //capitals.Add("Alaska", "Juneau");
            //capitals.Add("Arizona", "Phoenix");
            //capitals.Add("Massachusetts", "Boston");
            //capitals.Add("Wyoming", "Cheyenne");

            //string capitalOfMass = capitals["Massachusetts"];
            //Console.WriteLine("The capital of Massachusetts is {0}", capitalOfMass);

            var theStates = State.GetStates();
           // string capitalOfAlaska = theStates["Alaska"].Capital;
            var theState = theStates["Alaska"];
            Console.WriteLine(
                "The capital of Alaska is {0}, its population is {1} and it is {2} square miles", 
                theState.Capital, theState.Population, theState.Size);


        }
    }
}
