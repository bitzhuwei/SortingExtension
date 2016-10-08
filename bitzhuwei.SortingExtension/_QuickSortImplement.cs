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
        private static void QuickSortDescending1<T>(this IList<T> arr)
            where T : IComparable
        {
            QuickSortDescending1_Do(arr, 0, 0, arr.Count - 1);
#if DEBUG
            arr.WriteList();
#endif
        }
        private static void QuickSortDescending1_Do<T>(IList<T> arr, int indexOfRightPlaceToFind, int first, int last)
            where T : IComparable
        {
            if (first < last)
            {
#if DEBUG
                arr.WriteList();
#endif
                int rightPlace = QuickSortDescending1_Find(indexOfRightPlaceToFind, arr, first, last);
                if (first + 1 < last)
                {
                    QuickSortDescending1_Do(arr, first, first, rightPlace - 1);
                    QuickSortDescending1_Do(arr, rightPlace + 1, rightPlace + 1, last);
                }
            }
        }
        private static int QuickSortDescending1_Find<T>(int indexOfRightPlaceToFind, IList<T> arr, int first, int last)
            where T : IComparable
        {
            bool searchRight = true;
            int indexOfLeftSearch = first;
            int indexOfRightSearch = last;
            do 
            {
                if (searchRight)
                {
                    while (arr[indexOfRightPlaceToFind].CompareTo(arr[indexOfRightSearch]) >= 0)
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
                    while (arr[indexOfRightPlaceToFind].CompareTo(arr[indexOfLeftSearch]) <= 0)
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
        private static void QuickSortAscending1<T>(this IList<T> arr)
            where T : IComparable
        {
            QuickSortAscending1_Do(arr, 0, 0, arr.Count - 1);
#if DEBUG
            arr.WriteList();
#endif
        }
        private static void QuickSortAscending1_Do<T>(IList<T> arr, int indexOfRightPlaceToFind, int first, int last)
    where T : IComparable
        {
            if (first < last)
            {
#if DEBUG
                arr.WriteList();
#endif
                int rightPlace = QuickSortAscending1_Find(indexOfRightPlaceToFind, arr, first, last);
                if (first + 1 < last)
                {
                    QuickSortAscending1_Do(arr, first, first, rightPlace - 1);
                    QuickSortAscending1_Do(arr, rightPlace + 1, rightPlace + 1, last);
                }
            }
        }
        private static int QuickSortAscending1_Find<T>(int indexOfRightPlaceToFind, IList<T> arr, int first, int last)
            where T : IComparable
        {
            bool searchRight = true;
            int indexOfLeftSearch = first;
            int indexOfRightSearch = last;
            do
            {
                if (searchRight)
                {
                    while (arr[indexOfRightPlaceToFind].CompareTo(arr[indexOfRightSearch]) <= 0)
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
                    while (arr[indexOfRightPlaceToFind].CompareTo(arr[indexOfLeftSearch]) >= 0)
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


        private static void QuickSortDescending<T>(this IList<T> arr)
            where T : IComparable
        {
            QuickSortDescending1(arr);
        }
        private static void QuickSortAscending<T>(this IList<T> arr)
            where T : IComparable
        {
            QuickSortAscending1(arr);
        }
    }
}
