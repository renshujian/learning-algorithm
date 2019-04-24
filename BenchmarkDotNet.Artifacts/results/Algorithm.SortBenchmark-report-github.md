``` ini

BenchmarkDotNet=v0.11.5, OS=fedora 29
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.0.100-preview4-011223
  [Host]     : .NET Core 3.0.0-preview4-27615-11 (CoreCLR 4.6.27615.73, CoreFX 4.700.19.21213), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview4-27615-11 (CoreCLR 4.6.27615.73, CoreFX 4.700.19.21213), 64bit RyuJIT


```
|        Method |        dataType | dataLength |        Mean |     Error |    StdDev |
|-------------- |---------------- |----------- |------------:|----------:|----------:|
| **selectionSort** |  **lowCardinality** |       **1000** | **1,320.14 us** | **1.9710 us** | **1.7472 us** |
| insertionSort |  lowCardinality |       1000 |    12.57 us | 0.0523 us | 0.0464 us |
| **selectionSort** | **highCardinality** |       **1000** | **1,325.22 us** | **7.8470 us** | **7.3401 us** |
| insertionSort | highCardinality |       1000 |    12.52 us | 0.0459 us | 0.0407 us |
