using System;
using System.Collections.Generic;

namespace Algorithm {

  public static class ArraySorter<T> {

    public static void selectionSort(T[] array, Comparison<T> comparison) => sort(selection, array, comparison);
    public static void selectionSort(T[] array) => sort(selection, array, null);

    public static void insertionSort(T[] array, Comparison<T> comparison) => sort(insertion, array, comparison);
    public static void insertionSort(T[] array) => sort(insertion, array, null);

    public static void shellSort(T[] array, Comparison<T> comparison) => sort(shell, array, comparison);
    public static void shellSort(T[] array) => sort(shell, array, null);

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

    private static void insertion(T[] array, Comparison<T> comparison) {
      int reverseFindInsertionIndex(T value, int lastIndex) {
        for (int i = lastIndex; i >= 1; i--) {
          if (comparison(array[i - 1], value) <= 0) return i;
        }
        return 0;
      }

      for (int i = 1; i < array.Length; i++) {
        T current = array[i];
        int index = reverseFindInsertionIndex(current, i);
        Array.Copy(array, index, array, index + 1, i - index);
        array[index] = current;
      }
    }

    private static void shell(T[] array, Comparison<T> comparison) {
      int length = array.Length;
      int h = 1;
      while (h < length / 3) {
        h = 3 * h + 1;
      }

      int moveForInsertion(T value, int lastIndex) {
        int i = lastIndex;
        for (; i >= h && comparison(array[i - h], value) > 0; i -= h) {
          array[i] = array[i - h];
        }
        return i;
      }

      while (h >= 1) {
        for(int i = h; i < length; i++) {
          T current = array[i];
          array[moveForInsertion(current, i)] = current;
        }
        h = h / 3;
      }
    }
  }
}
