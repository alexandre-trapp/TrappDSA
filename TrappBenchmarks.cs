using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using TrappDSA.Algorithms;

namespace TrappDSA;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn(NumeralSystem.Arabic)]
[MarkdownExporter]
public class TrappBenchmarks
{
    [Benchmark(Description = "O(log n)")]
    public void BinarSearch()
    {
        new BinarySearch().Execute();
    }
}
