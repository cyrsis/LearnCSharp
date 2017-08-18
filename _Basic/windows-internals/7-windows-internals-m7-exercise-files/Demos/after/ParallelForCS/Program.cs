using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelForCS {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Working...");
			int result;
			Console.WriteLine(Measure(() => CountPrimesSerial(3, 10000000), out result));
			Console.WriteLine("Primes: {0}", result);
			Console.WriteLine(Measure(() => CountPrimesParallel(3, 10000000), out result));
			Console.WriteLine("Primes: {0}", result);
		}

		static int Measure(Func<int> action, out int result) {
			var sw = Stopwatch.StartNew();
			result = action();
			sw.Stop();
			return (int)sw.ElapsedMilliseconds;
		}

		static int CountPrimesSerial(int first, int last) {
			int count = 0;
			for(int i = first; i <= last; i++) {
				int limit = (int)Math.Sqrt(i);
				bool prime = true;
				for(int j = 2; j <= limit; j++)
					if(i % j == 0) {
						prime = false;
						break;
					}
				if(prime)
					++count;
			}
			return count;
		}

		static int CountPrimesParallel(int first, int last) {
			int count = 0;
			Parallel.For(first, last + 1, i => {
				int limit = (int)Math.Sqrt(i);
				bool prime = true;
				for(int j = 2; j <= limit; j++)
					if(i % j == 0) {
						prime = false;
						break;
					}
				if(prime)
					++count;// Interlocked.Increment(ref count);
			});
			return count;
		}
	}
}
