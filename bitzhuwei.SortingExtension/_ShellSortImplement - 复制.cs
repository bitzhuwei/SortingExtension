using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace System
{
    public static partial class _ShellSort
    {
        /// <summary>
        /// 希尔排序算法
        /// <para>不稳定排序</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void ShellSortDescending1<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
            int inc;
            for (inc = 1; inc <= arr.Count / 9; inc = 3 * inc + 1) ;
            for (; inc > 0; inc /= 3)
            {
#if DEBUG
                arr.WriteList();
#endif
                for (int i = inc + 1; i <= arr.Count; i += inc)
                {
                    T temp = arr[i - 1];
                    int j = i;
                    while ((j > inc) && (comparer(temp, arr[j - inc - 1]) > 0))
                    {
                        arr[j - 1] = arr[j - inc - 1];
                        j -= inc;
                    }
                    arr[j - 1] = temp;
                }
            }
#if DEBUG
            arr.WriteList();
#endif
        }
        /// <summary>
        /// 希尔排序算法
        /// <para>不稳定排序</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void ShellSortAscending1<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
            int inc;
            for (inc = 1; inc <= arr.Count / 9; inc = 3 * inc + 1) ;
            for (; inc > 0; inc /= 3)
            {
#if DEBUG
                arr.WriteList();
#endif
                for (int i = inc + 1; i <= arr.Count; i += inc)
                {
                    T temp = arr[i - 1];
                    int j = i;
                    while ((j > inc) && (comparer(temp, arr[j - inc - 1]) < 0))
                    {
                        arr[j - 1] = arr[j - inc - 1];
                        j -= inc;
                    }
                    arr[j - 1] = temp;
                }
            }
#if DEBUG
            arr.WriteList();
#endif
        }

        private static void ShellSortDescending<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
            ShellSortDescending1(arr, comparer);
        }
        private static void ShellSortAscending<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
            ShellSortAscending1(arr, comparer);
        }
    }
}
