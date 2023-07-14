```

BenchmarkDotNet v0.13.6, Windows 10 (10.0.19045.3086/22H2/2022Update)
AMD Ryzen 9 7950X3D, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100-preview.3.23178.7
  [Host]     : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2


```
| Method |                Query |      Mean |    Error |   StdDev |   Gen0 | Allocated |
|------- |--------------------- |----------:|---------:|---------:|-------:|----------:|
|    **Old** | **insta(...)=1234 [21]** | **128.94 ns** | **1.603 ns** | **1.339 ns** | **0.0002** |     **408 B** |
|    New | insta(...)=1234 [21] |  20.36 ns | 0.141 ns | 0.117 ns | 0.0000 |      40 B |
| Fowler | insta(...)=1234 [21] |  81.75 ns | 0.233 ns | 0.182 ns |      - |      40 B |
|    **Old** | **test=(...)=1234 [25]** | **116.70 ns** | **1.472 ns** | **1.377 ns** | **0.0002** |     **448 B** |
|    New | test=(...)=1234 [25] |  21.20 ns | 0.095 ns | 0.089 ns | 0.0000 |      40 B |
| Fowler | test=(...)=1234 [25] |  79.42 ns | 0.356 ns | 0.316 ns |      - |      40 B |
