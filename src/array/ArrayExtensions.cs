using System;
using System.Collections.Generic;

namespace Algorithm {

  public static class ArrayExtensions {

    // There are arrays with non-zero lower bound. Here won't deal with that case.
    private const int LOWER_BOUND = 0;

    public static (T, int) min<T>(this T[] array, Comparison<T> comparison, int startIndex = LOWER_BOUND) {
      if (startIndex >= LOWER_BOUND + array.Length) throw new IndexOutOfRangeException();
      int index = startIndex;
      T min = array[index];
      for (int i = index + 1; i < LOWER_BOUND + array.Length; i++) {
        if (comparison(array[i], min) < 0) {
          index = i;
          min = array[index];
        }
      }
      return (min, index);
    }

    public static void exchange<T>(this T[] array, int i, int j) {
      T t = array[i];
      array[i] = array[j];
      array[j] = t;
    }

    public static bool isSorted<T>(this T[] array, Comparison<T> comparison) {
      for (int i = LOWER_BOUND + 1; i < LOWER_BOUND + array.Length; i++) {
        if (comparison(array[i], array[i - 1]) < 0) return false;
      }
      return true;
    }

    public static string join<T>(this T[] array, string seperator = ", ") {
      if (array.Length == 0) return "";
      string result = array[LOWER_BOUND]?.ToString() ?? "null";
      for (int i = LOWER_BOUND + 1; i < LOWER_BOUND + array.Length; i++) {
        result = result + seperator + array[i]?.ToString() ?? "null";
      }
      return result;
    }
  }
}
