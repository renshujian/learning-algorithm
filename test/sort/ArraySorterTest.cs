using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm {

  [TestClass]
  public class ArraySorterTest {

    private int[] _datasource;

    public int[] datasource {
      get {
        if (_datasource == null) {
          Random random = new Random();
          byte[] buffer = new byte[random.Next(4000)];
          random.NextBytes(buffer);
          MemoryStream stream = new MemoryStream(buffer);
          BinaryReader reader = new BinaryReader(stream);
          _datasource = new int[buffer.Length / 4];
          for (int i = 0; i < _datasource.Length; i++) {
            _datasource[i] = reader.ReadInt32();
          }
          reader.Dispose();
        }
        return (int[]) _datasource.Clone();
      }
    }

    Comparison<int> comparison = Comparer<int>.Default.Compare;

    [TestMethod]
    public void selectionSort() {
      int[] data = datasource;
      ArraySorter<int>.selectionSort(data, comparison);
      Assert.IsTrue(data.isSorted(comparison));
    }

    [TestMethod]
    public void insertionSort() {
      int[] data = datasource;
      ArraySorter<int>.insertionSort(data, comparison);
      Assert.IsTrue(data.isSorted(comparison));
    }

    [TestMethod]
    public void shellSort() {
      int[] data = datasource;
      ArraySorter<int>.shellSort(data, comparison);
      Assert.IsTrue(data.isSorted(comparison));
    }

    [TestMethod]
    public void mergeSort() {
      int[] data = datasource;
      ArraySorter<int>.mergeSort(data, comparison);
      Assert.IsTrue(data.isSorted(comparison));
    }

    [TestMethod]
    public void parallelMergeSort() {
      int[] data = datasource;
      ArraySorter<int>.parallelMergeSort(data, comparison);
      Assert.IsTrue(data.isSorted(comparison));
    }

    [TestMethod]
    public void quickSort() {
      int[] data = datasource;
      ArraySorter<int>.quickSort(data, comparison);
      Assert.IsTrue(data.isSorted(comparison));
    }

    [TestMethod]
    public void quick3waySort() {
      int[] data = datasource;
      ArraySorter<int>.quick3waySort(data, comparison);
      Assert.IsTrue(data.isSorted(comparison));
    }
  }
}
