using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace System
{
    public static partial class _QuickSort
    {
        /// <summary>
        /// 快速排序算法
        /// <para>不稳定排序</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void QuickSortDescending1<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
            QuickSortDescending1_Do(arr, comparer, 0, 0, arr.Count - 1);
#if DEBUG
            arr.WriteList();
#endif
        }
        private static void QuickSortDescending1_Do<T>(IList<T> arr, Func<T, T, int> comparer, int indexOfRightPlaceToFind, int first, int last)
        {
            if (first < last)
            {
#if DEBUG
                arr.WriteList();
#endif
                int rightPlace = QuickSortDescending1_Find(indexOfRightPlaceToFind, arr, comparer, first, last);
                if (first + 1 < last)
                {
                    QuickSortDescending1_Do(arr, comparer, first, first, rightPlace - 1);
                    QuickSortDescending1_Do(arr, comparer, rightPlace + 1, rightPlace + 1, last);
                }
            }
        }
        private static int QuickSortDescending1_Find<T>(int indexOfRightPlaceToFind, IList<T> arr, Func<T, T, int> comparer, int first, int last)
        {
            bool searchRight = true;
            int indexOfLeftSearch = first;
            int indexOfRightSearch = last;
            do
            {
                if (searchRight)
                {
                    while (comparer(arr[indexOfRightPlaceToFind], arr[indexOfRightSearch]) >= 0)
                    {
                        indexOfRightSearch--;
                        if (indexOfRightPlaceToFind == indexOfRightSearch)
                        {
                            searchRight = false;
                            break;
                        }
                    }
                    if (searchRight)
                    {
                        T temp = arr[indexOfRightPlaceToFind];
                        arr[indexOfRightPlaceToFind] = arr[indexOfRightSearch];
                        arr[indexOfRightSearch] = temp;
                        indexOfRightPlaceToFind = indexOfRightSearch;
                        searchRight = false;
                    }
                }
                else
                {
                    while (comparer(arr[indexOfRightPlaceToFind], arr[indexOfLeftSearch]) <= 0)
                    {
                        indexOfLeftSearch++;
                        if (indexOfRightPlaceToFind == indexOfLeftSearch)
                        {
                            searchRight = true;
                            break;
                        }
                    }
                    if (!searchRight)
                    {
                        T temp = arr[indexOfRightPlaceToFind];
                        arr[indexOfRightPlaceToFind] = arr[indexOfLeftSearch];
                        arr[indexOfLeftSearch] = temp;
                        indexOfRightPlaceToFind = indexOfLeftSearch;
                        searchRight = true;
                    }
                }
            } while (indexOfLeftSearch < indexOfRightPlaceToFind || indexOfRightPlaceToFind < indexOfRightSearch);
            return indexOfRightPlaceToFind;
        }

        /// <summary>
        /// 快速排序算法
        /// <para>不稳定排序</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void QuickSortAscending1<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
            QuickSortAscending1_Do(arr, comparer, 0, 0, arr.Count - 1);
#if DEBUG
            arr.WriteList();
#endif
        }
        private static void QuickSortAscending1_Do<T>(IList<T> arr, Func<T, T, int> comparer, int indexOfRightPlaceToFind, int first, int last)
        {
            if (first < last)
            {
#if DEBUG
                arr.WriteList();
#endif
                int rightPlace = QuickSortAscending1_Find(indexOfRightPlaceToFind, arr, comparer, first, last);
                if (first + 1 < last)
                {
                    QuickSortAscending1_Do(arr, comparer, first, first, rightPlace - 1);
                    QuickSortAscending1_Do(arr, comparer, rightPlace + 1, rightPlace + 1, last);
                }
            }
        }
        private static int QuickSortAscending1_Find<T>(int indexOfRightPlaceToFind, IList<T> arr, Func<T, T, int> comparer, int first, int last)
        {
            bool searchRight = true;
            int indexOfLeftSearch = first;
            int indexOfRightSearch = last;
            do
            {
                if (searchRight)
                {
                    while (comparer(arr[indexOfRightPlaceToFind], arr[indexOfRightSearch]) <= 0)
                    {
                        indexOfRightSearch--;
                        if (indexOfRightPlaceToFind == indexOfRightSearch)
                        {
                            searchRight = false;
                            break;
                        }
                    }
                    if (searchRight)
                    {
                        T temp = arr[indexOfRightPlaceToFind];
                        arr[indexOfRightPlaceToFind] = arr[indexOfRightSearch];
                        arr[indexOfRightSearch] = temp;
                        indexOfRightPlaceToFind = indexOfRightSearch;
                        searchRight = false;
                    }
                }
                else
                {
                    while (comparer(arr[indexOfRightPlaceToFind], arr[indexOfLeftSearch]) >= 0)
                    {
                        indexOfLeftSearch++;
                        if (indexOfRightPlaceToFind == indexOfLeftSearch)
                        {
                            searchRight = true;
                            break;
                        }
                    }
                    if (!searchRight)
                    {
                        T temp = arr[indexOfRightPlaceToFind];
                        arr[indexOfRightPlaceToFind] = arr[indexOfLeftSearch];
                        arr[indexOfLeftSearch] = temp;
                        indexOfRightPlaceToFind = indexOfLeftSearch;
                        searchRight = true;
                    }
                }
            } while (indexOfLeftSearch < indexOfRightPlaceToFind || indexOfRightPlaceToFind < indexOfRightSearch);
            return indexOfRightPlaceToFind;
        }


        private static void QuickSortDescending<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
            QuickSortDescending1(arr, comparer);
        }
        private static void QuickSortAscending<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
            QuickSortAscending1(arr, comparer);
        }
    }
}
