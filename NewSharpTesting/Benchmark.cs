using System;
using System.Diagnostics;

namespace NewSharpTesting
{
    internal static class Benchmark
    {
        public static double Measure(Action a, int iter, int warmup = 1000)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            for (var i = 0; i < warmup; i++)
                a();

            var watch = Stopwatch.StartNew();

            for (var i = 0; i < iter; i++)
                a();

            watch.Stop();

            return watch.Elapsed.TotalMilliseconds;
        }
    }
}
