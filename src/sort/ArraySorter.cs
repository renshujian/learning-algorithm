using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Algorithm {

  public static class ArraySorter<T> {

    const int INSERTION_SORT_LENGTH = 100;

    public static void selectionSort(T[] array, Comparison<T> comparison) => sort(selection, array, comparison);
    public static void selectionSort(T[] array) => sort(selection, array, null);

    public static void insertionSort(T[] array, Comparison<T> comparison) => sort(insertion, array, comparison);
    public static void insertionSort(T[] array) => sort(insertion, array, null);

    public static void shellSort(T[] array, Comparison<T> comparison) => sort(shell, array, comparison);
    public static void shellSort(T[] array) => sort(shell, array, null);

    public static void mergeSort(T[] array, Comparison<T> comparison) => sort(merge, array, comparison);
    public static void mergeSort(T[] array) => sort(merge, array, null);

    public static void parallelMergeSort(T[] array, Comparison<T> comparison) => sort(parallelMerge, array, comparison);
    public static void parallelMergeSort(T[] array) => sort(parallelMerge, array, null);

    public static void quickSort(T[] array, Comparison<T> comparison) => sort(quick, array, comparison);
    public static void quickSort(T[] array) => sort(quick, array, null);

    public static void quick3waySort(T[] array, Comparison<T> comparison) => sort(quick3way, array, comparison);
    public static void quick3waySort(T[] array) => sort(quick3way, array, null);

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

    private static void insertion(T[] array, Comparison<T> comparison, int lo, int hi) {
      int reverseFindInsertionIndex(T value, int lastIndex) {
        for (int i = lastIndex; i >= lo + 1; i--) {
          if (comparison(array[i - 1], value) <= 0) return i;
        }
        return lo;
      }

      for (int i = lo + 1; i < hi; i++) {
        T current = array[i];
        int index = reverseFindInsertionIndex(current, i);
        if (index < i) {
          Array.Copy(array, index, array, index + 1, i - index);
          array[index] = current;
        }
      }
    }

    private static void insertion(T[] array, Comparison<T> comparison) {
      insertion(array, comparison, 0, array.Length);
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

    /// <summary>
    ///   array[lo..mid] and array[mid..hi] are 2 sorted slices.
    ///   <para>lo &lt; mid &lt; hi, otherwise the behavior is undefined.</para>
    /// </summary>
    /// <param name="array">array[lo..hi] will be sorted</param>
    /// <param name="temp">temp[lo..hi] will be modified</param>
    private static void merge(T[] array, Comparison<T> comparison, int lo, int mid, int hi, T[] temp) {
      if (comparison(array[mid - 1], array[mid]) <= 0) return;

      int index1 = lo;
      int index2 = mid;
      int length1() => mid - index1;
      int length2() => hi - index2;

      for (int i = lo; i < hi; i++) {
        if (comparison(array[index1], array[index2]) < 0) {
          temp[i] = array[index1++];
          if (length1() == 0) {
            Array.Copy(array, index2, temp, i + 1, length2());
            break;
          }
        } else {
          temp[i] = array[index2++];
          if (length2() == 0) {
            Array.Copy(array, index1, temp, i + 1, length1());
            break;
          }
        }
      }
      Array.Copy(temp, lo, array, lo, hi - lo);
    }

    private static void merge(T[] array, Comparison<T> comparison) {
      T[] temp = new T[array.Length];

      void sort (int lo, int hi) {
        int length = hi - lo;
        if (length <= INSERTION_SORT_LENGTH) {
          insertion(array, comparison, lo, hi);
          return;
        }

        int mid = lo + length / 2;
        sort(lo, mid);
        sort(mid, hi);
        merge(array, comparison, lo, mid, hi, temp);
      };

      sort(0, array.Length);
    }

    private static void parallelMerge(T[] array, Comparison<T> comparison) {
      T[] temp = new T[array.Length];

      void sort (int lo, int hi) {
        int length = hi - lo;
        if (length <= INSERTION_SORT_LENGTH) {
          insertion(array, comparison, lo, hi);
          return;
        }

        int mid = lo + length / 2;
        Parallel.Invoke(() => sort(lo, mid), () => sort(mid, hi));
        merge(array, comparison, lo, mid, hi, temp);
      };

      sort(0, array.Length);
    }

    private static void quick(T[] array, Comparison<T> comparison, int lo, int hi) {
      int length = hi - lo;
      if (length <= INSERTION_SORT_LENGTH) {
        insertion(array, comparison, lo, hi);
        return;
      }

      T sample;
      // 3 sampling
      {
        int mid = (lo + hi) / 2;
        T first = array[lo];
        T middle = array[mid];
        T last = array[hi - 1];
        T[] samples = {first, middle, last};
        insertion(samples, comparison);
        sample = samples[1];
        if (sample.Equals(middle)) {
          array[lo] = middle;
          array[mid] = first;
        } else if (sample.Equals(last)) {
          array[lo] = last;
          array[hi - 1] = first;
        }
      }

      int left = lo;
      int right = hi;
      while (true) {
        // using median sample, left won't be out of range in first iteration
        // after first iteration, left <= right
        while (comparison(array[++left], sample) < 0) {}

        // right >= left - 1
        while (comparison(array[--right], sample) > 0) {}

        // right = left - 1
        if (left > right) {
          // array[left] >= sample, array[right] <= sample
          array.exchange(lo, right);
          break;
        }

        if (left == right) {
          // array[left] == array[right] == sample
          break;
        }
        array.exchange(left, right);
      }

      quick(array, comparison, lo, right);
      quick(array, comparison, right + 1, hi);
    }

    private static void quick(T[] array, Comparison<T> comparison) => quick(array, comparison, 0, array.Length);

    private static void quick3way(T[] array, Comparison<T> comparison, int lo, int hi) {
      int length = hi - lo;
      if (length <= INSERTION_SORT_LENGTH) {
        insertion(array, comparison, lo, hi);
        return;
      }

      T sample;
      // 3 sampling
      {
        int mid = (lo + hi) / 2;
        T first = array[lo];
        T middle = array[mid];
        T last = array[hi - 1];
        T[] samples = {first, middle, last};
        insertion(samples, comparison);
        sample = samples[1];
        if (sample.Equals(middle)) {
          array[lo] = middle;
          array[mid] = first;
        } else if (sample.Equals(last)) {
          array[lo] = last;
          array[hi - 1] = first;
        }
      }

      int lt = lo;
      int i = lo + 1;
      int gt = hi;
      while (i < gt) {
        int cmp = comparison(array[i], sample);
        if (cmp < 0) {
          array.exchange(lt++, i++);
        } else if (cmp > 0) {
          array.exchange(--gt, i);
        } else {
          i++;
        }
      }

      quick3way(array, comparison, lo, lt);
      quick3way(array, comparison, gt, hi);
    }

    private static void quick3way(T[] array, Comparison<T> comparison) {
      quick3way(array, comparison, 0, array.Length);
    }
  }
}
