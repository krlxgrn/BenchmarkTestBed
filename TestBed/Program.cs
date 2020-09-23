using BenchmarkDotNet.Running;

namespace TestBed
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<DefaultBenchmark>();
        }
    }
}