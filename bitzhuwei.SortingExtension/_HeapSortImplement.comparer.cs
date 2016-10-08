using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace System
{
    public static partial class _HeapSort
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void HeapSortDescending1<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
#if DEBUG
            arr.WriteList();
#endif
            // 从最后一个非叶结点开始构造堆
            for (int i = arr.Count / 2 - 1; i >= 0; i--)
            {
                arr.HeapAdjustDescending1(comparer, i, arr.Count);
            }
            for (int i = arr.Count - 1; i > 0; i--)
            {
                T temp = arr[i];
                arr[i] = arr[0];
                arr[0] = temp;
#if DEBUG
                arr.WriteList();
#endif
                HeapAdjustDescending1(arr, comparer, 0, i);
            }
        }
        /// <summary>
        /// 制作小根堆
        /// <para>让每一个父节点都比其子节点小</para>
        /// </summary>
        /// <typeparam name="T">要调整的数列的元素类型</typeparam>
        /// <param name="arr">要调整的数列</param>
        /// <param name="nonLeafNodeToBeAdujusted">要调整的结点索引（从0开始）</param>
        /// <param name="unRangedCount">要调整的数列元素数目（超过此数目的部分不进行调整）</param>
        private static void HeapAdjustDescending1<T>(this IList<T> arr, Func<T, T, int> comparer, int nonLeafNodeToBeAdujusted, int unRangedCount)
        {
            int leftChild = nonLeafNodeToBeAdujusted * 2 + 1;
            int rightChild = nonLeafNodeToBeAdujusted * 2 + 2;
            int min = nonLeafNodeToBeAdujusted;//假设要调整的结点就是最小的，即符合小根堆的要求
            if (nonLeafNodeToBeAdujusted < unRangedCount / 2)//索引所指结点是非叶节点
            {
                if (leftChild < unRangedCount && comparer(arr[leftChild], arr[min]) < 0)
                { min = leftChild; }
                if (rightChild < unRangedCount && comparer(arr[rightChild], arr[min]) < 0)
                { min = rightChild; }
                if (min != nonLeafNodeToBeAdujusted)
                {
                    T temp = arr[nonLeafNodeToBeAdujusted];
                    arr[nonLeafNodeToBeAdujusted] = arr[min];
                    arr[min] = temp;
                    arr.HeapAdjustDescending1(comparer, min, unRangedCount);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void HeapSortAscending1<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
#if DEBUG
            arr.WriteList();
#endif
            for (int i = arr.Count / 2 - 1; i >= 0; i--)
            {
                arr.HeapAdjustAscending1(comparer, i, arr.Count);
            }
            for (int i = arr.Count - 1; i > 0; i--)
            {
                T temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
#if DEBUG
                arr.WriteList();
#endif
                arr.HeapAdjustAscending1(comparer, 0, i);
            }
        }
        private static void HeapAdjustAscending1<T>(this IList<T> arr, Func<T, T, int> comparer, int nonLeafNodeToBeAdjusted, int unRangedCount)
        {
            int leftChild = nonLeafNodeToBeAdjusted * 2 + 1;
            int rightChild = nonLeafNodeToBeAdjusted * 2 + 2;
            int max = nonLeafNodeToBeAdjusted;
            if (nonLeafNodeToBeAdjusted < unRangedCount / 2) // 是非叶节点
            {
                if (leftChild < unRangedCount && comparer(arr[leftChild], arr[max]) > 0)
                { max = leftChild; }
                if (rightChild < unRangedCount && comparer(arr[rightChild], arr[max]) > 0)
                { max = rightChild; }
                if (max != nonLeafNodeToBeAdjusted)
                {
                    T temp = arr[max];
                    arr[max] = arr[nonLeafNodeToBeAdjusted];
                    arr[nonLeafNodeToBeAdjusted] = temp;
                    arr.HeapAdjustAscending1(comparer, max, unRangedCount);
                }
            }
        }
        private static void HeapSortDescending<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
            HeapSortDescending1(arr, comparer);
        }
        private static void HeapSortAscending<T>(this IList<T> arr, Func<T, T, int> comparer)
        {
            HeapSortAscending1(arr, comparer);
        }
    }
}
