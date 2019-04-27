``` ini

BenchmarkDotNet=v0.11.5, OS=fedora 29
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.0.100-preview4-011223
  [Host]     : .NET Core 3.0.0-preview4-27615-11 (CoreCLR 4.6.27615.73, CoreFX 4.700.19.21213), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview4-27615-11 (CoreCLR 4.6.27615.73, CoreFX 4.700.19.21213), 64bit RyuJIT


```
|        Method |        dataType | dataLength |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|-------------- |---------------- |----------- |-------------:|------------:|------------:|-------------:|------:|--------:|
| **insertionSort** |  **lowCardinality** |       **1000** |     **5.349 us** |   **0.0221 us** |   **0.0206 us** |     **5.343 us** |  **1.00** |    **0.00** |
|     shellSort |  lowCardinality |       1000 |    28.893 us |   0.1248 us |   0.1107 us |    28.903 us |  5.40 |    0.03 |
|     mergeSort |  lowCardinality |       1000 |     6.316 us |   0.1154 us |   0.0963 us |     6.302 us |  1.18 |    0.02 |
|     quickSort |  lowCardinality |       1000 |    35.852 us |   0.0338 us |   0.0282 us |    35.855 us |  6.70 |    0.03 |
|               |                 |            |              |             |             |              |       |         |
| **insertionSort** |  **lowCardinality** |      **10000** |    **52.846 us** |   **0.3168 us** |   **0.2964 us** |    **52.740 us** |  **1.00** |    **0.00** |
|     shellSort |  lowCardinality |      10000 |   399.116 us |   3.7526 us |   3.5102 us |   397.936 us |  7.55 |    0.09 |
|     mergeSort |  lowCardinality |      10000 |    62.501 us |   1.0056 us |   0.9407 us |    62.788 us |  1.18 |    0.02 |
|     quickSort |  lowCardinality |      10000 |   564.402 us |   3.6365 us |   3.2237 us |   563.749 us | 10.68 |    0.09 |
|               |                 |            |              |             |             |              |       |         |
| **insertionSort** |  **lowCardinality** |     **100000** |   **545.914 us** |  **10.8965 us** |  **26.3163 us** |   **540.656 us** |  **1.00** |    **0.00** |
|     shellSort |  lowCardinality |     100000 | 5,114.747 us |  32.4986 us |  30.3992 us | 5,112.548 us |  9.24 |    0.46 |
|     mergeSort |  lowCardinality |     100000 |   620.627 us |   5.2704 us |   4.9299 us |   619.345 us |  1.12 |    0.06 |
|     quickSort |  lowCardinality |     100000 | 7,619.129 us |  37.2583 us |  34.8514 us | 7,613.114 us | 13.76 |    0.65 |
|               |                 |            |              |             |             |              |       |         |
| **insertionSort** | **highCardinality** |       **1000** |     **5.343 us** |   **0.0285 us** |   **0.0238 us** |     **5.346 us** |  **1.00** |    **0.00** |
|     shellSort | highCardinality |       1000 |    28.983 us |   0.4966 us |   0.4146 us |    28.831 us |  5.42 |    0.08 |
|     mergeSort | highCardinality |       1000 |     6.400 us |   0.0439 us |   0.0389 us |     6.396 us |  1.20 |    0.01 |
|     quickSort | highCardinality |       1000 |    30.242 us |   0.1376 us |   0.1149 us |    30.192 us |  5.66 |    0.04 |
|               |                 |            |              |             |             |              |       |         |
| **insertionSort** | **highCardinality** |      **10000** |    **54.164 us** |   **1.0751 us** |   **1.8544 us** |    **53.410 us** |  **1.00** |    **0.00** |
|     shellSort | highCardinality |      10000 |   399.096 us |   9.1042 us |   8.0706 us |   397.222 us |  7.12 |    0.28 |
|     mergeSort | highCardinality |      10000 |    67.252 us |   1.3433 us |   1.6988 us |    67.778 us |  1.22 |    0.05 |
|     quickSort | highCardinality |      10000 |   557.754 us |   5.8972 us |   5.2277 us |   556.190 us |  9.95 |    0.28 |
|               |                 |            |              |             |             |              |       |         |
| **insertionSort** | **highCardinality** |     **100000** |   **592.547 us** |  **11.8093 us** |  **18.0341 us** |   **592.096 us** |  **1.00** |    **0.00** |
|     shellSort | highCardinality |     100000 | 5,236.510 us | 103.7209 us | 178.9134 us | 5,147.787 us |  8.89 |    0.46 |
|     mergeSort | highCardinality |     100000 |   623.881 us |   6.6477 us |   6.2182 us |   623.099 us |  1.05 |    0.02 |
|     quickSort | highCardinality |     100000 | 8,602.460 us |   7.0246 us |   6.2271 us | 8,600.683 us | 14.50 |    0.32 |
