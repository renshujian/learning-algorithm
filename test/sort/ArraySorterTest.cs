using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm {

  [TestClass]
  public class ArraySorterTest {

    [TestMethod]
    public void selectionSort() {
      int[] data = {3, 2, 1, 0, -1};
      Comparison<int> comparison = Comparer<int>.Default.Compare;
      ArraySorter<int>.selectionSort(data, comparison);
      Assert.IsTrue(data.isSorted(comparison));
    }

    [TestMethod]
    public void insertionSort() {
      int[] data = {3, 2, 1, 0, -1};
      Comparison<int> comparison = Comparer<int>.Default.Compare;
      ArraySorter<int>.insertionSort(data, comparison);
      Assert.IsTrue(data.isSorted(comparison));
    }

    [TestMethod]
    public void shellSort() {
      int[] data = {3, 2, 1, 0, -1};
      Comparison<int> comparison = Comparer<int>.Default.Compare;
      ArraySorter<int>.shellSort(data, comparison);
      Assert.IsTrue(data.isSorted(comparison));
    }
  }
}
