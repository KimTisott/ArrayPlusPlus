using BenchmarkDotNet.Attributes;
using System.Linq;

namespace ArrayPlusPlus.Benchmark
{
    public class MinBenchmark : BenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public int MinLinq()
        {
            return Data.Min();
        }

        [Benchmark]
        public int MinPP()
        {
            return Data.MinPP();
        }

        [Benchmark]
        public int MinPPIndex()
        {
            return Data.MinPP(out int index);
        }
    }
}