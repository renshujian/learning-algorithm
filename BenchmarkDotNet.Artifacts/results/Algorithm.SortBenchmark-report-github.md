``` ini

BenchmarkDotNet=v0.11.5, OS=fedora 29
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.0.100-preview4-011223
  [Host]     : .NET Core 3.0.0-preview4-27615-11 (CoreCLR 4.6.27615.73, CoreFX 4.700.19.21213), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview4-27615-11 (CoreCLR 4.6.27615.73, CoreFX 4.700.19.21213), 64bit RyuJIT


```
|        Method |        dataType | dataLength |          Mean |       Error |      StdDev |
|-------------- |---------------- |----------- |--------------:|------------:|------------:|
| **selectionSort** |  **lowCardinality** |       **1000** |   **1,313.09 us** |   **4.1910 us** |   **3.9202 us** |
| insertionSort |  lowCardinality |       1000 |      12.45 us |   0.0247 us |   0.0231 us |
|     shellSort |  lowCardinality |       1000 |      28.53 us |   0.0511 us |   0.0426 us |
| **selectionSort** |  **lowCardinality** |      **10000** | **163,571.11 us** | **179.1481 us** | **167.5753 us** |
| insertionSort |  lowCardinality |      10000 |     124.33 us |   0.1378 us |   0.1151 us |
|     shellSort |  lowCardinality |      10000 |     392.52 us |   1.2176 us |   1.0794 us |
| **selectionSort** | **highCardinality** |       **1000** |   **1,313.19 us** |   **3.4946 us** |   **3.2688 us** |
| insertionSort | highCardinality |       1000 |      12.45 us |   0.0258 us |   0.0215 us |
|     shellSort | highCardinality |       1000 |      28.56 us |   0.0768 us |   0.0681 us |
| **selectionSort** | **highCardinality** |      **10000** | **163,705.91 us** | **326.7528 us** | **289.6578 us** |
| insertionSort | highCardinality |      10000 |     124.16 us |   0.2276 us |   0.2017 us |
|     shellSort | highCardinality |      10000 |     392.39 us |   0.6419 us |   0.6004 us |
