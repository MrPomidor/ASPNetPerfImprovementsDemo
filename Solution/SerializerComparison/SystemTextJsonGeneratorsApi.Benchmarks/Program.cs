using BenchmarkDotNet.Running;

namespace SystemTextJsonGeneratorsApi.Benchmarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SerializerBenchmarks>();
        }
    }
}