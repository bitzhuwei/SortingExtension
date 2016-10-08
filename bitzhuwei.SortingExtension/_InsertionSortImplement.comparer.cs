using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace System
{
    public static partial class _InsertionSort
    {
        /// <summary>
        /// 插入排序算法
        /// <para>稳定排序</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void InsertionSortDescending1<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
            for (int i = 1; i < arr.Count; i++)
            {
#if DEBUG
                arr.WriteList();
#endif
                T temp = arr[i];
                int j = i;
                while ((j > 0) && (comparer(temp, arr[j - 1]) > 0))
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = temp;
            }
#if DEBUG
            arr.WriteList();
#endif
        }
        /// <summary>
        /// 插入排序算法
        /// <para>稳定排序</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void InsertionSortAscending1<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
            for (int i = 1; i < arr.Count; i++)
            {
#if DEBUG
                arr.WriteList();
#endif
                T temp = arr[i];
                int j = i;
                while ((j > 0) && (comparer(temp, arr[j - 1]) < 0))
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = temp;
            }
#if DEBUG
            arr.WriteList();
#endif
        }

        private static void InsertionSortDescending<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
            InsertionSortDescending1(arr, comparer);
        }
        private static void InsertionSortAscending<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
            InsertionSortAscending1(arr, comparer);
        }

    }
}
