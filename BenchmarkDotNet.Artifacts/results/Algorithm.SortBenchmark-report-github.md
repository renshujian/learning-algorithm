``` ini

BenchmarkDotNet=v0.12.0, OS=fedora 29
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.102
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  DefaultJob : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT


```
|        Method |        dataType | dataLength |        Mean |     Error |    StdDev |      Median |
|-------------- |---------------- |----------- |------------:|----------:|----------:|------------:|
|     **quickSort** |  **lowCardinality** |       **1000** |    **33.14 us** |  **0.527 us** |  **0.440 us** |    **33.33 us** |
| quick3waySort |  lowCardinality |       1000 |    14.42 us |  0.421 us |  0.643 us |    14.16 us |
|     **quickSort** |  **lowCardinality** |      **10000** |   **455.91 us** | **11.003 us** | **17.452 us** |   **447.52 us** |
| quick3waySort |  lowCardinality |      10000 |   130.72 us |  1.011 us |  0.896 us |   130.71 us |
|     **quickSort** |  **lowCardinality** |     **100000** | **6,213.75 us** | **40.256 us** | **37.656 us** | **6,193.34 us** |
| quick3waySort |  lowCardinality |     100000 | 1,367.01 us | 11.767 us | 10.431 us | 1,368.08 us |
|     **quickSort** | **highCardinality** |       **1000** |    **30.64 us** |  **0.939 us** |  **1.118 us** |    **30.06 us** |
| quick3waySort | highCardinality |       1000 |    34.67 us |  0.235 us |  0.220 us |    34.57 us |
|     **quickSort** | **highCardinality** |      **10000** |   **443.00 us** |  **5.500 us** |  **4.593 us** |   **441.31 us** |
| quick3waySort | highCardinality |      10000 |   402.55 us |  3.085 us |  2.886 us |   401.67 us |
|     **quickSort** | **highCardinality** |     **100000** | **6,363.97 us** | **49.872 us** | **57.433 us** | **6,343.27 us** |
| quick3waySort | highCardinality |     100000 | 4,350.58 us | 28.032 us | 24.850 us | 4,361.32 us |
