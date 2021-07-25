using BenchmarkDotNet.Attributes;
using System.Linq;

namespace ArrayPlusPlus.Benchmark
{
    public class SumBenchmark : BenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public int SumLinq()
        {
            return Data.Sum();
        }

        [Benchmark]
        public int SumPP()
        {
            return Data.SumPP();
        }
    }
}