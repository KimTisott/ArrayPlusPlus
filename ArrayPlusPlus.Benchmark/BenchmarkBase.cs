using BenchmarkDotNet.Attributes;
using System.Linq;

namespace ArrayPlusPlus.Benchmark
{
    [DisassemblyDiagnoser, MemoryDiagnoser, SimpleJob(targetCount: 10, launchCount: 1, warmupCount: 3)]
    public class BenchmarkBase
    {
        [Params(100, 10_000, 1_000_000)]
        protected int N;

        protected int[] Data;

        protected int[] DataSecondary;

        [GlobalSetup]
        public void GlobalSetup()
        {
            Data = Utilities.TestArray(typeof(int), N, 0, 1000).ToArray()[0][0] as int[];

            DataSecondary = Utilities.TestArray(typeof(int), N, 500, 1500).ToArray()[0][0] as int[];
        }
    }
}