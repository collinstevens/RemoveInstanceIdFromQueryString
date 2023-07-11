using BenchmarkDotNet.Attributes;

namespace RemoveInstanceIdFromQueryString;

[MemoryDiagnoser]
public class Benchmarks
{
    [Params("test=1234&instanceId=1234", "instanceId=&test=1234")]
    public string Query;
    
    [Benchmark]
    public string? Old()
    {
        return Library.RemoveInstanceIdFromQueryString_Old(Query);
    }
    
    [Benchmark]
    public string? New()
    {
        return Library.RemoveInstanceIdFromQueryString_New(Query);
    }
}