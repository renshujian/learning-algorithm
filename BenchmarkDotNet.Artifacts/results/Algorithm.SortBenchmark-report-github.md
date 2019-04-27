``` ini

BenchmarkDotNet=v0.11.5, OS=fedora 29
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.0.100-preview4-011223
  [Host]     : .NET Core 3.0.0-preview4-27615-11 (CoreCLR 4.6.27615.73, CoreFX 4.700.19.21213), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview4-27615-11 (CoreCLR 4.6.27615.73, CoreFX 4.700.19.21213), 64bit RyuJIT


```
|        Method |        dataType | dataLength |        Mean |      Error |     StdDev |
|-------------- |---------------- |----------- |------------:|-----------:|-----------:|
|     **quickSort** |  **lowCardinality** |       **1000** |    **34.66 us** |  **0.3218 us** |  **0.3010 us** |
| quick3waySort |  lowCardinality |       1000 |    15.19 us |  0.1057 us |  0.0825 us |
|     **quickSort** |  **lowCardinality** |      **10000** |   **564.82 us** |  **3.0790 us** |  **2.7294 us** |
| quick3waySort |  lowCardinality |      10000 |   126.09 us |  1.5882 us |  1.4079 us |
|     **quickSort** |  **lowCardinality** |     **100000** | **7,343.90 us** | **24.8435 us** | **23.2386 us** |
| quick3waySort |  lowCardinality |     100000 | 1,433.03 us |  7.6411 us |  7.1475 us |
|     **quickSort** | **highCardinality** |       **1000** |    **36.58 us** |  **0.7049 us** |  **0.6923 us** |
| quick3waySort | highCardinality |       1000 |    33.10 us |  0.2520 us |  0.2357 us |
|     **quickSort** | **highCardinality** |      **10000** |   **576.18 us** |  **0.5020 us** |  **0.4450 us** |
| quick3waySort | highCardinality |      10000 |   389.67 us |  0.4513 us |  0.4222 us |
|     **quickSort** | **highCardinality** |     **100000** | **7,813.31 us** | **42.6608 us** | **37.8177 us** |
| quick3waySort | highCardinality |     100000 | 4,261.26 us | 22.0312 us | 20.6080 us |
