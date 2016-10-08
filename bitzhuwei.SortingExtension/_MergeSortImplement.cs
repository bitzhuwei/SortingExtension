using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace System
{
    public static partial class _MergeSort
    {
        /// <summary>
        /// 归并排序，自顶向下的方法
        /// <para>稳定排序</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void MergeSortDescending1<T>(this IList<T> arr)
            where T : IComparable
        {
            MergeSortDescending1_Split(arr, 0, arr.Count - 1);
#if DEBUG
            arr.WriteList();
#endif
        }
        private static void MergeSortDescending1_Split<T>(IList<T> arr, int first, int last)
            where T : IComparable
        {
            if (first < last)
            {
                int mid = (first + last) / 2;
                MergeSortDescending1_Split(arr, first, mid);
                MergeSortDescending1_Split(arr, mid + 1, last);
#if DEBUG
                arr.WriteList();
#endif
                MergeSortDescending1_Combine(arr, first, mid, last);
            }
        }
        /// <summary>
        /// 将两个有序的左右子表（以mid区分），合并成一个有序的表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="first"></param>
        /// <param name="mid"></param>
        /// <param name="last"></param>
        private static void MergeSortDescending1_Combine<T>(IList<T> arr, int first, int mid, int last)
            where T : IComparable
        {
            int indexA = first;//左侧子表的起始位置
            int indexB = mid + 1;//右侧子表的起始位置
            //声明数组（暂存左右子表的所有有序数列）
            //长度等于左右子表的长度之和。
            IList<T> tempList = new List<T>(arr.AsEnumerable());

            int tempIndex = 0;
            //进行左右子表的遍历，如果其中有一个子表遍历完，则跳出循环
            while (indexA <= mid && indexB <= last)
            {
                //此时左子表的数 >= 右子表的数
                if (arr[indexA].CompareTo(arr[indexB]) >= 0)
                {//将左子表的数放入暂存数组中，遍历左子表下标++
                    tempList[tempIndex++] = arr[indexA++];
                }
                else//此时左子表的数 < 右子表的数
                {//将右子表的数放入暂存数组中，遍历右子表下标++
                    tempList[tempIndex++] = arr[indexB++];
                }
            }
            //有一侧子表遍历完后，跳出循环，
            //将另外一侧子表剩下的数一次放入暂存数组中（有序）
            while (indexA <= mid)
            {
                tempList[tempIndex++] = arr[indexA++];
            }
            while (indexB <= last)
            {
                tempList[tempIndex++] = arr[indexB++];
            }
            //将暂存数组中有序的数列写入目标数组的制定位置，
            //使进行归并的数组段有序
            tempIndex = 0;
            for (int i = first; i <= last; i++)
            {
                arr[i] = tempList[tempIndex++];
            }
        }
        /// <summary>
        /// 归并排序，自顶向下的方法
        /// <para>稳定排序</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void MergeSortAscending1<T>(this IList<T> arr)
            where T : IComparable
        {
            MergeSortAscending1_Split(arr, 0, arr.Count - 1);
#if DEBUG
            arr.WriteList();
#endif
        }
        private static void MergeSortAscending1_Split<T>(IList<T> arr, int first, int last)
            where T : IComparable
        {
            if (first < last)
            {
                int mid = (first + last) / 2;
                MergeSortAscending1_Split(arr, first, mid);
                MergeSortAscending1_Split(arr, mid + 1, last);
#if DEBUG
                arr.WriteList();
#endif
                MergeSortAscending1_Combine(arr, first, mid, last);
            }
        }
        /// <summary>
        /// 将两个有序的左右子表（以mid区分），合并成一个有序的表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="first"></param>
        /// <param name="mid"></param>
        /// <param name="last"></param>
        private static void MergeSortAscending1_Combine<T>(IList<T> arr, int first, int mid, int last)
            where T : IComparable
        {
            int indexA = first;//左侧子表的起始位置
            int indexB = mid + 1;//右侧子表的起始位置
            //声明数组（暂存左右子表的所有有序数列）
            //长度等于左右子表的长度之和。
            IList<T> tempList = new List<T>(arr.AsEnumerable());

            int tempIndex = 0;
            //进行左右子表的遍历，如果其中有一个子表遍历完，则跳出循环
            while (indexA <= mid && indexB <= last)
            {
                //此时左子表的数 <= 右子表的数
                if (arr[indexA].CompareTo(arr[indexB]) <= 0)
                {//将左子表的数放入暂存数组中，遍历左子表下标++
                    tempList[tempIndex++] = arr[indexA++];
                }
                else//此时左子表的数 > 右子表的数
                {//将右子表的数放入暂存数组中，遍历右子表下标++
                    tempList[tempIndex++] = arr[indexB++];
                }
            }
            //有一侧子表遍历完后，跳出循环，
            //将另外一侧子表剩下的数一次放入暂存数组中（有序）
            while (indexA <= mid)
            {
                tempList[tempIndex++] = arr[indexA++];
            }
            while (indexB <= last)
            {
                tempList[tempIndex++] = arr[indexB++];
            }
            //将暂存数组中有序的数列写入目标数组的指定位置，
            //使进行归并的数组段有序
            tempIndex = 0;
            for (int i = first; i <= last; i++)
            {
                arr[i] = tempList[tempIndex++];
            }
        }

        private static void MergeSortDescending<T>(this IList<T> arr)
            where T : IComparable
        {
            MergeSortDescending1(arr);
        }
        private static void MergeSortAscending<T>(this IList<T> arr)
            where T : IComparable
        {
            MergeSortAscending1(arr);
        }
    }
}
