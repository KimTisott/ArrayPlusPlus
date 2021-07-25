using BenchmarkDotNet.Attributes;
using System.Linq;

namespace ArrayPlusPlus.Benchmark
{
    public class MaxBenchmark : BenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public int MaxLinq()
        {
            return Data.Max();
        }

        [Benchmark]
        public int MaxPP()
        {
            return Data.MaxPP();
        }

        [Benchmark]
        public int MaxPPIndex()
        {
            return Data.MaxPP(out _);
        }
    }
}