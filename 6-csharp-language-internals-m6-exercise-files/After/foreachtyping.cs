using System;

namespace ForeachTyping
{
    class Program
    {
        static void Main()
        {
            foreach (string x in new MyCollection())
            {
                Console.WriteLine(x);
            }
        }
    }

    class MyCollection
    {
        public MyEnumerator GetEnumerator()
        {
            return new MyEnumerator();
        }
    }

    class MyEnumerator
    {
        public bool MoveNext()
        {
            return true;
        }

        public object Current
        {
            get
            {
                return 42;
            }
        }
    }
}
