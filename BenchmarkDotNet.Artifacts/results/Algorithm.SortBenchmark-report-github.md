``` ini

BenchmarkDotNet=v0.11.5, OS=fedora 29
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.0.100-preview4-011223
  [Host]     : .NET Core 3.0.0-preview4-27615-11 (CoreCLR 4.6.27615.73, CoreFX 4.700.19.21213), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview4-27615-11 (CoreCLR 4.6.27615.73, CoreFX 4.700.19.21213), 64bit RyuJIT


```
|            Method |        dataType | dataLength |          Mean |       Error |      StdDev |        Median | Ratio | RatioSD |
|------------------ |---------------- |----------- |--------------:|------------:|------------:|--------------:|------:|--------:|
|     **insertionSort** | **highCardinality** |       **1000** |      **5.326 us** |   **0.0202 us** |   **0.0189 us** |      **5.329 us** |  **1.00** |    **0.00** |
|         shellSort | highCardinality |       1000 |     29.159 us |   0.2826 us |   0.2505 us |     29.102 us |  5.48 |    0.06 |
|         mergeSort | highCardinality |       1000 |      6.418 us |   0.0340 us |   0.0318 us |      6.411 us |  1.21 |    0.01 |
| parallelMergeSort | highCardinality |       1000 |     17.784 us |   0.3506 us |   0.6498 us |     17.565 us |  3.34 |    0.14 |
|                   |                 |            |               |             |             |               |       |         |
|     **insertionSort** | **highCardinality** |      **10000** |     **52.900 us** |   **0.2520 us** |   **0.2357 us** |     **52.916 us** |  **1.00** |    **0.00** |
|         shellSort | highCardinality |      10000 |    425.175 us |   8.3018 us |   9.5604 us |    428.983 us |  8.01 |    0.21 |
|         mergeSort | highCardinality |      10000 |     63.199 us |   0.7194 us |   0.6008 us |     63.031 us |  1.19 |    0.01 |
| parallelMergeSort | highCardinality |      10000 |    125.425 us |   2.5054 us |   5.0611 us |    123.615 us |  2.39 |    0.12 |
|                   |                 |            |               |             |             |               |       |         |
|     **insertionSort** | **highCardinality** |     **100000** |    **582.640 us** |  **17.5245 us** |  **49.7140 us** |    **561.671 us** |  **1.00** |    **0.00** |
|         shellSort | highCardinality |     100000 |  5,115.363 us |  21.4549 us |  20.0689 us |  5,117.011 us |  8.74 |    0.70 |
|         mergeSort | highCardinality |     100000 |    621.108 us |   3.6868 us |   3.4486 us |    620.670 us |  1.06 |    0.09 |
| parallelMergeSort | highCardinality |     100000 |    982.474 us |  19.1741 us |  28.6990 us |    971.616 us |  1.68 |    0.15 |
|                   |                 |            |               |             |             |               |       |         |
|     **insertionSort** | **highCardinality** |    **1000000** |  **5,622.000 us** | **112.3642 us** | **271.3721 us** |  **5,588.191 us** |  **1.00** |    **0.00** |
|         shellSort | highCardinality |    1000000 | 62,419.998 us | 415.6462 us | 388.7958 us | 62,435.095 us | 11.08 |    0.56 |
|         mergeSort | highCardinality |    1000000 |  6,413.018 us | 207.5539 us | 213.1426 us |  6,329.127 us |  1.13 |    0.06 |
| parallelMergeSort | highCardinality |    1000000 | 13,260.728 us | 254.7598 us | 348.7181 us | 13,216.169 us |  2.33 |    0.14 |
