using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        CollectReportWait();
        Consume();
        CollectReportWait();
    }

    static void Consume()
    {
        foreach (var x in Xs())
        {
            Console.WriteLine(x);
            CollectReportWait();
        }
    }

    static void CollectReportWait()
    {
        Console.WriteLine(GC.GetTotalMemory(forceFullCollection: true));
        Console.ReadLine();
    }

    static IEnumerable<int> Xs()
    {
        byte[] buffer;
        yield return 1;

        buffer = new byte[10 * 1024 * 1024];
        yield return 2;

        var len = buffer.Length / (1024 * 1024);
        buffer = null;
        yield return len;

        yield return 4; // buffer no longer used
        yield return 5; // buffer no longer used
    }
}
