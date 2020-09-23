using BenchmarkDotNet.Attributes;

namespace TestBed
{
    [MemoryDiagnoser]
    public class DefaultBenchmark
    {
        [GlobalSetup]
        public void GlobalSetup()
        {
            // Add setup code not part of the benchmark here
        }
        
        [GlobalCleanup]
        public void GlobalCleanup()
        {
            // Add cleanup logic not part of the benchmark here
        }

        [Benchmark(Baseline = true)]
        public void BenchmarkOne()
        {
            // Add code to benchmark here
        }
        
        [Benchmark]
        public void BenchmarkTwo()
        {
            // Add code to benchmark here
        }
    }
}