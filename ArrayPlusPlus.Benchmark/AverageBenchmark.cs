using BenchmarkDotNet.Attributes;
using System.Linq;

namespace ArrayPlusPlus.Benchmark
{
    public class AverageBenchmark : BenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public double AverageLinq()
        {
            return Data.Average();
        }

        [Benchmark]
        public double AveragePP()
        {
            return Data.AveragePP();
        }
    }
}