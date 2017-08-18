using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var presidents = new LinkedList<string>();
			presidents.AddLast("JFK");
			presidents.AddLast("Lyndon B Johnson");
			presidents.AddLast("Richard Nixon");
			presidents.AddLast("Jimmy Carter");

			presidents.RemoveFirst();
			LinkedListNode<string> kennedy = presidents.AddFirst("John F Kennedy");

			LinkedListNode<string> nixon = presidents.Find("Richard Nixon");
			presidents.AddAfter(nixon, "Gerald Ford");

			foreach (string president in presidents)
				Console.WriteLine(president);
		}
	}
}
