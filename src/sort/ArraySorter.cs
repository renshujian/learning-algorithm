using System;
using System.Collections.Generic;

namespace Algorithm {

  public static class ArraySorter<T> {

    public static void selectionSort(T[] array, Comparison<T> comparison) => sort(selection, array, comparison);
    public static void selectionSort(T[] array) => sort(selection, array, null);

    private static void sort(Action<T[], Comparison<T>> strategy, T[] array, Comparison<T> comparison) {
      if (array == null) throw new ArgumentNullException();
      if (array.Length <= 1) return;
      strategy(array, comparison ?? Comparer<T>.Default.Compare);
    }

    private static void selection(T[] array, Comparison<T> comparison) {
      for (int i = 0; i < array.Length - 1; i++) {
        (_, int minIndex) = array.min(comparison, i);
        (array[i], array[minIndex]) = (array[minIndex], array[i]);
      }
    }
  }
}
