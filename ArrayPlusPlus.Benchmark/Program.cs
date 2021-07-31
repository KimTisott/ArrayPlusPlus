using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ArrayPlusPlus.Benchmark
{
    class Program
    {
        private const string ArtifactsDirectory = "Artifacts/";

        static void Main()
        {
            var array = new int[] { 3, 2, 3, 1, 2, 2 };

            var hey = ArrayPlusPlus.MaxPP(array);

            var config = ManualConfig.CreateEmpty()
                .AddLogger(ConsoleLogger.Default)
                .AddColumnProvider(DefaultColumnProviders.Instance)
                .AddExporter(MarkdownExporter.GitHub)
                .WithArtifactsPath(ArtifactsDirectory);

            var benchmarks = Enumerable.Empty<Type>();

            benchmarks = benchmarks.Append(typeof(MaxBenchmark));

            foreach (var benchmark in benchmarks)
            {
                var summary = BenchmarkRunner.Run(benchmark, config);

                if (summary.HasCriticalValidationErrors)
                {
                    return;
                }
            }
        }

        private static IEnumerable<Type> EnumerateTypes<T>()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            var tType = typeof(T);

            foreach (var type in types)
            {
                if (!type.IsClass)
                {
                    continue;
                }

                if (!tType.IsAssignableFrom(type) || tType == type)
                {
                    continue;
                }

                yield return type;
            }
        }
    }
}