``` ini

BenchmarkDotNet=v0.12.0, OS=fedora 29
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.102
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  DefaultJob : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT


```
|        Method |        dataType | dataLength |          Mean |         Error |        StdDev |        Median | Ratio | RatioSD |
|-------------- |---------------- |----------- |--------------:|--------------:|--------------:|--------------:|------:|--------:|
| **insertionSort** | **highCardinality** |       **1000** |      **5.511 us** |     **0.1095 us** |     **0.2161 us** |      **5.373 us** |  **1.00** |    **0.00** |
|     shellSort | highCardinality |       1000 |     29.752 us |     0.7835 us |     1.1484 us |     29.206 us |  5.37 |    0.17 |
|     mergeSort | highCardinality |       1000 |      6.189 us |     0.0512 us |     0.0427 us |      6.179 us |  1.09 |    0.04 |
|               |                 |            |               |               |               |               |       |         |
| **insertionSort** | **highCardinality** |      **10000** |     **52.889 us** |     **0.3433 us** |     **0.2866 us** |     **52.778 us** |  **1.00** |    **0.00** |
|     shellSort | highCardinality |      10000 |    396.333 us |     1.9786 us |     1.8508 us |    395.861 us |  7.50 |    0.05 |
|     mergeSort | highCardinality |      10000 |     56.440 us |     0.5427 us |     0.5076 us |     56.358 us |  1.07 |    0.01 |
|               |                 |            |               |               |               |               |       |         |
| **insertionSort** | **highCardinality** |     **100000** |    **602.556 us** |    **18.4632 us** |    **53.5650 us** |    **593.806 us** |  **1.00** |    **0.00** |
|     shellSort | highCardinality |     100000 |  5,113.471 us |    40.7780 us |    38.1437 us |  5,105.936 us |  8.78 |    0.73 |
|     mergeSort | highCardinality |     100000 |    562.512 us |     4.3410 us |     4.0606 us |    560.309 us |  0.97 |    0.08 |
|               |                 |            |               |               |               |               |       |         |
| **insertionSort** | **highCardinality** |    **1000000** |  **5,836.219 us** |   **154.9308 us** |   **439.5129 us** |  **5,722.153 us** |  **1.00** |    **0.00** |
|     shellSort | highCardinality |    1000000 | 63,443.379 us | 1,432.3363 us | 1,862.4418 us | 62,490.022 us | 10.95 |    0.88 |
|     mergeSort | highCardinality |    1000000 |  5,907.548 us |   116.7934 us |   219.3663 us |  5,846.091 us |  1.03 |    0.08 |
