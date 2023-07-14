```

BenchmarkDotNet v0.13.6, Windows 10 (10.0.19045.3086/22H2/2022Update)
AMD Ryzen 9 7950X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100-preview.3.23178.7
  [Host]     : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2


```
| Method |                Query |      Mean |    Error |   StdDev |   Gen0 | Allocated |
|------- |--------------------- |----------:|---------:|---------:|-------:|----------:|
|    **Old** | **insta(...)=1234 [21]** | **115.19 ns** | **2.157 ns** | **2.018 ns** | **0.0002** |     **408 B** |
|    New | insta(...)=1234 [21] |  20.85 ns | 0.291 ns | 0.273 ns | 0.0000 |      40 B |
| Fowler | insta(...)=1234 [21] |  84.42 ns | 0.609 ns | 0.540 ns |      - |      40 B |
|    **Old** | **test=(...)=1234 [25]** | **118.30 ns** | **1.674 ns** | **1.566 ns** | **0.0002** |     **448 B** |
|    New | test=(...)=1234 [25] |  21.93 ns | 0.479 ns | 0.492 ns | 0.0000 |      40 B |
| Fowler | test=(...)=1234 [25] |  80.82 ns | 1.627 ns | 1.741 ns |      - |      40 B |
