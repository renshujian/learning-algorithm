using BenchmarkDotNet.Attributes;

namespace Algorithm {

  public class SortBenchmark {

    [Params(DataType.lowCardinality, DataType.highCardinality)]
    public DataType dataType {get; set;}

    [Params(1000, 10000)]
    public int dataLength {get; set;}

    public char[] data {get; set;}

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

    [Benchmark]
    public void selectionSort() {
      ArraySorter<char>.selectionSort(data);
    }

    [Benchmark]
    public void insertionSort() {
      ArraySorter<char>.insertionSort(data);
    }

    [Benchmark]
    public void shellSort() {
      ArraySorter<char>.shellSort(data);
    }
  }
}

