using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace csharp_func
{
    static class Program
    {
        static void Main(string[] args)
        {
            var task = new Task<IEnumerable<int>>(
                () => FindLargePrimes(3, 100)
            );

            var task2 = task.ContinueWith((antecedent) =>
                                  {
                                      foreach (var number in antecedent.Result)
                                      {
                                          Console.WriteLine(number);
                                      }
                                  });

            task.Start();

            Console.WriteLine("Doing other work");

            task2.Wait();


            //var timekeeper = new Timekeeper();
            //var elapsed = timekeeper.Measure(() => FindLargePrimesInParallel(900000, 1000000));
            //Console.WriteLine(elapsed);            
        }

        private static IList<int> FindLargePrimes(int start, int end)
        {
            var primes = Enumerable.Range(start, end - start).ToList();
            return primes.Where(IsPrime).ToList();
        }

        private static IList<int> FindLargePrimesInParallel(int start, int end)
        {
            var primes = Enumerable.Range(start, end - start).ToList();
            return primes.AsParallel().Where(IsPrime).ToList();
        }

        private static void Timekeeping()
        {
            var timekeeper = new Timekeeper();
            var elapsed = timekeeper.Measure(() =>
            {
                var primes = GetRandomNumbers().Find(IsPrime).Take(2).ToList();
                foreach (var prime in primes)
                {
                    Console.WriteLine(prime);
                }
            });
            Console.WriteLine(elapsed);
        }

        private static void Downloads()
        {
            var client = new WebClient();
            Func<string, string> download = url => client.DownloadString(url);
            Func<string, Func<string>> downloadCurry = download.Curry();

            var data = download.Partial("http://microsoft.com").WithRetry();
            var data2 = downloadCurry("http://microsoft.com").WithRetry();
        }

        private static IEnumerable<int> GetRandomNumbers()
        {
            Random rand = new Random();
            while (true)
            {
                yield return rand.Next(10000000);
            }
        }

        private static IEnumerable<int> Find(this IEnumerable<int> values,
                                             Func<int, bool> test)
        {
            foreach (var number in values)
            {
                Console.WriteLine("Testing {0}", number);
                if (test(number))
                {
                    yield return number;
                }
            }
        }

        private static bool IsPrime(int number)
        {
            bool result = true;
            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private static bool IsOdd(int number)
        {
            return number % 2 == 1;
        }

        private static bool IsEven(int number)
        {
            return !IsOdd(number);
        }
    }
}
