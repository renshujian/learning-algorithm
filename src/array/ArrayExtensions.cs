using System;
using System.Collections.Generic;

namespace Algorithm {

  public static class ArrayExtensions {

    private const int lowerBound = 0;

    public static (T, int) min<T>(this T[] array, Comparison<T> comparison, int startIndex = lowerBound) {
      if (startIndex >= lowerBound + array.Length) throw new IndexOutOfRangeException();
      int index = startIndex;
      T min = array[index];
      for (int i = index + 1; i < lowerBound + array.Length; i++) {
        if (comparison(array[i], min) < 0) {
          index = i;
          min = array[index];
        }
      }
      return (min, index);
    }

    public static bool isSorted<T>(this T[] array, Comparison<T> comparison) {
      for (int i = lowerBound + 1; i < lowerBound + array.Length; i++) {
        if (comparison(array[i], array[i - 1]) < 0) return false;
      }
      return true;
    }
  }
}
