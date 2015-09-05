using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace System
{
    public static partial class _BubbleSort
    {
        /// <summary>
        /// 冒泡排序（降序）原理：
        /// 从左到右以此比较两个相邻的数，若左小右大顺序则交换一下。
        /// 这样，当一轮比较结束，最小的数就排在了最右边。
        /// 下一轮比较前N-1个数即可。
        /// 经过N-1轮比较，数列就是大->小排序的了。
        /// 改进的冒泡排序：当某轮比较没有发生移动时，就可以确定排序完成了，从而减少了排序的轮数。
        /// <para>稳定排序</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void BubbleSortDescending1<T>(this IList<T> arr)
            where T : IComparable
        {
            bool exchanges;
            do
            {
#if DEBUG
                arr.WriteList();
#endif
                exchanges = false;
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]) < 0)
                    {
                        T temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        //当某轮比较没有发生移动时，就可以确定排序完成了
                        //否则应该继续排序
                        exchanges = true;
                    }
                }
            } while (exchanges);
#if DEBUG
            arr.WriteList();
#endif
        }
        /// <summary>
        /// 当某轮比较没有发生移动时，就可以确定排序完成了
        /// <para>稳定排序</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void BubbleSortAscending1<T>(this IList<T> arr)
            where T : IComparable
        {
            bool exchanges;
            do
            {
#if DEBUG
                arr.WriteList();
#endif
                exchanges = false;
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        T temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        //当某轮比较没有发生移动时，就可以确定排序完成了
                        //否则应该继续排序
                        exchanges = true;
                    }
                }
            } while (exchanges);
#if DEBUG
            arr.WriteList();
#endif
        }
        /// <summary>
        /// 经典冒泡排序算法
        /// <para>稳定排序</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void BubbleSortDescending2<T>(this IList<T> arr)
            where T : IComparable
        {
            for (int pass = 1; pass < arr.Count - 1; pass++)
            {
#if DEBUG
                arr.WriteList();
#endif
                for (int i = 0; i < arr.Count - pass; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]) < 0)
                    {
                        T temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
#if DEBUG
            arr.WriteList();
#endif
        }
        /// <summary>
        /// 经典冒泡排序算法
        /// <para>稳定排序</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void BubbleSortAscending2<T>(this IList<T> arr)
            where T : IComparable
        {
            for (int pass = 1; pass < arr.Count - 1; pass++)
            {
#if DEBUG
                arr.WriteList();
#endif
                for (int i = 0; i < arr.Count - pass; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        T temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
#if DEBUG
            arr.WriteList();
#endif
        }

   		private static void BubbleSortDescending<T>(this IList<T> arr)
			where T : IComparable
		{
			BubbleSortDescending1(arr);
            //BubbleSortDescending2(arr);
		}
		private static void BubbleSortAscending<T>(this IList<T> arr)
			where T : IComparable
		{
			BubbleSortAscending1(arr);
            //BubbleSortAscending2(arr);
		}
    }
}
