using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mod04_CacheEffects
{
    class Integration
    {
        private const int STEPS = 128000000;
        private const double FROM = 0.0;
        private const double TO = 1.0;

        private static double Function(double x)
        {
            return 4.0 / (1 + x * x);
        }

        public static void Measure()
        {
            // Warm up
            Function(1.0);

            Utils.Measure("Integrate Sequential", () =>
            {
                double integral;
                IntegrateSequential(Function, FROM, TO, STEPS, out integral);
                Console.WriteLine("RESULT = {0:0.00000000}", integral);
            });
            Utils.Measure("Integrate Parallel Sharing", () =>
            {
                double integral;
                IntegrateParallelSharing(Function, FROM, TO, STEPS, Environment.ProcessorCount, out integral);
                Console.WriteLine("RESULT = {0:0.00000000}", integral);
            });
            Utils.Measure("Integrate Parallel Private", () =>
            {
                double integral;
                IntegrateParallelPrivate(Function, FROM, TO, STEPS, Environment.ProcessorCount, out integral);
                Console.WriteLine("RESULT = {0:0.00000000}", integral);
            });
        }

        private static void IntegrateSequential(
            Func<double, double> f, double from, double to, int steps, out double integral)
        {
            integral = 0.0;
            double stepSize = (to - from) / steps;
            for (int i = 0; i < steps; ++i)
            {
                integral += stepSize * f(from + ((i + 0.5) * stepSize));
            }
        }

        private static void IntegrateParallelSharing(
            Func<double, double> f, double from, double to, int steps, int parallelism, out double integral)
        {
            double[] partialIntegrals = new double[parallelism];
            double stepSize = (to - from) / steps;
            double chunkSize = (to - from) / parallelism;
            int chunkSteps = steps / parallelism;

            Thread[] threads = new Thread[parallelism];
            for (int i = 0; i < parallelism; ++i)
            {
                double myFrom = from + i * chunkSize;
                double myTo = myFrom + chunkSize;
                int myIndex = i;
                threads[i] = new Thread(() =>
                {
                    IntegrateSequential(f, myFrom, myTo, chunkSteps, out partialIntegrals[myIndex]);
                });
                threads[i].Start();
            }

            foreach (var thread in threads) thread.Join();
            integral = partialIntegrals.Sum();
        }

        private static void IntegrateParallelPrivate(
            Func<double, double> f, double from, double to, int steps, int parallelism, out double integral)
        {
            double[] partialIntegrals = new double[parallelism];
            double stepSize = (to - from) / steps;
            double chunkSize = (to - from) / parallelism;
            int chunkSteps = steps / parallelism;

            Thread[] threads = new Thread[parallelism];
            for (int i = 0; i < parallelism; ++i)
            {
                double myFrom = from + i * chunkSize;
                double myTo = myFrom + chunkSize;
                int myIndex = i;
                threads[i] = new Thread(() =>
                {
                    double myIntegral;
                    IntegrateSequential(f, myFrom, myTo, chunkSteps, out myIntegral);
                    partialIntegrals[myIndex] = myIntegral;
                });
                threads[i].Start();
            }

            foreach (var thread in threads) thread.Join();
            integral = partialIntegrals.Sum();
        }
    }
}
