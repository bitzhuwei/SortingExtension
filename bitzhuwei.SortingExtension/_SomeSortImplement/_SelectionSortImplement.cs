using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace System
{
    public static partial class _SelectionSort
    {
        /// <summary>
        /// 选择排序算法
        /// <para>不稳定排序</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void SelectionSortDescending1<T>(this IList<T> arr)
            where T : IComparable
        {
            for (int i = 0; i < arr.Count - 1; i++)
            {
#if DEBUG
                arr.WriteList();
#endif
                int max = i;
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[j].CompareTo(arr[max]) > 0)
                    {
                        max = j;
                    }
                }
                if (max != i)
                {
                    T temp = arr[i];
                    arr[i] = arr[max];
                    arr[max] = temp;
                }
            }
#if DEBUG
            arr.WriteList();
#endif
        }
        /// <summary>
        /// 选择排序算法
        /// <para>不稳定排序</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void SelectionSortAscending1<T>(this IList<T> arr)
            where T : IComparable
        {
            for (int i = 0; i < arr.Count - 1; i++)
            {
#if DEBUG
                arr.WriteList();
#endif
                int min = i;
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[j].CompareTo(arr[min]) < 0)
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    T temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
#if DEBUG
                arr.WriteList();
#endif
            }
        }

        private static void SelectionSortDescending<T>(this IList<T> arr)
            where T : IComparable
        {
            SelectionSortDescending1(arr);
        }
        private static void SelectionSortAscending<T>(this IList<T> arr)
            where T : IComparable
        {
            SelectionSortAscending1(arr);
        }
    }
}
