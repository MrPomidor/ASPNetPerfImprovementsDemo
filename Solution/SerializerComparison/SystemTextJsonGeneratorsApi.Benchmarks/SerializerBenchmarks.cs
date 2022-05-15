using System.Text.Json;
using AutoBogus;
using BenchmarkDotNet.Attributes;
using Reusables.Data;
using SystemTextJsonGeneratorsApi.JsonConverters;

namespace SystemTextJsonGeneratorsApi.Benchmarks
{
    public class SerializerBenchmarks
    {
        private SalesOrderHeader header;
        private List<SalesOrderHeader> headerList;

        [GlobalSetup]
        public void Setup()
        {
            header = AutoFaker.Generate<SalesOrderHeader>();
            headerList = AutoFaker.Generate<SalesOrderHeader>(10);
        }

        [Benchmark]
        public void Serialize_Object()
        {
            _ = JsonSerializer.Serialize(header);
        }

        [Benchmark]
        public void Serialize_Object_WithSourceGeneratorContext()
        {
            _ = JsonSerializer.Serialize(header, AdventureWorksContext.Default.SalesOrderHeader);
        }

        [Benchmark]
        public void Serialize_List()
        {
            _ = JsonSerializer.Serialize(headerList);
        }

        [Benchmark]
        public void Serialize_List_WithSourceGeneratorContext()
        {
            _ = JsonSerializer.Serialize(headerList, AdventureWorksContext.Default.ListSalesOrderHeader);
        }
    }
}
