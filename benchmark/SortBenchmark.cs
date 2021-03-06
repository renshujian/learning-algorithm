using BenchmarkDotNet.Attributes;

namespace Algorithm {

  public class SortBenchmark {

    [Params(DataType.lowCardinality, DataType.highCardinality)]
    public DataType dataType {get; set;}

    [Params(1000, 10000, 100000)]
    public int dataLength {get; set;}

    public char[] data {get; set;} = default!;

    [GlobalSetup]
    public void setup() {
      switch (dataType) {
        case DataType.lowCardinality: {
          data = DataSource.lowCardinality(dataLength);
          break;
        }
        case DataType.highCardinality: {
          data = DataSource.highCardinality(dataLength);
          break;
        }
      }
    }

    // [Benchmark]
    public void selectionSort() => ArraySorter<char>.selectionSort(data);

    [Benchmark(Baseline = true)]
    public void insertionSort() => ArraySorter<char>.insertionSort(data);

    [Benchmark]
    public void shellSort() => ArraySorter<char>.shellSort(data);

    [Benchmark]
    public void mergeSort() => ArraySorter<char>.mergeSort(data);

    // [Benchmark]
    public void parallelMergeSort() => ArraySorter<char>.parallelMergeSort(data);

    [Benchmark]
    public void quickSort() => ArraySorter<char>.quickSort(data);

    [Benchmark]
    public void quick3waySort() => ArraySorter<char>.quick3waySort(data);
  }
}

