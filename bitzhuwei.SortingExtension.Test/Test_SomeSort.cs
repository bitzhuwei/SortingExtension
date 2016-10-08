using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace bitzhuwei.SortingExtension.Test
{
    /// <summary>
    /// 用于对冒泡排序进行测试的类
    /// </summary>
    partial class Test_BubbleSort
    {
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestBubbleSort001(int listCount, bool descending)
        {
            Console.WriteLine("Test: _BubbleSort.cs 001");
            if (listCount < 0)
            {
                Console.WriteLine("要测试元素数目小于0的数列，这是无法实现的。程序也屏蔽了这个问题，无需担心。");
                //Console.ReadLine();
            }
            List<Element> lstElement = Tools.RandomSequentialNumbersWith2Same(0, listCount);
            TestBubbleSort001(lstElement, descending);
        }
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestBubbleSort001(List<Element> list, bool descending)
        {
            Console.WriteLine("Test: _BubbleSort.cs 001");
            if (list == null)
            {
                Console.WriteLine("要排序的数列为null，无法排序。程序为求效率，没有进行数列为null的检验。");
                //Console.ReadLine();
            }
            List<Element> lstElement = list;
            List<Element> lstOriginalElement = new List<Element>(lstElement.AsEnumerable());
            lstElement.BubbleSort(descending);

            Tools.testError(lstElement, lstOriginalElement, descending);
            Console.WriteLine();
        }
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestBubbleSort001(bool descending)
        {
            Console.WriteLine("Test: _BubbleSort.cs 001");
            int count = Tools.seed.Next(0, 11);// 0 1 2 3 4 5 6 7 8 9 10
            TestBubbleSort001(count, descending);
        }
    }
    /// <summary>
    /// 用于对插入排序进行测试的类
    /// </summary>
    partial class Test_InsertionSort
    {
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestInsertionSort001(int listCount, bool descending)
        {
            Console.WriteLine("Test: _InsertionSort.cs 001");
            if (listCount < 0)
            {
                Console.WriteLine("要测试元素数目小于0的数列，这是无法实现的。程序也屏蔽了这个问题，无需担心。");
                //Console.ReadLine();
            }
            List<Element> lstElement = Tools.RandomSequentialNumbersWith2Same(0, listCount);
            TestInsertionSort001(lstElement, descending);
        }
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestInsertionSort001(List<Element> list, bool descending)
        {
            Console.WriteLine("Test: _InsertionSort.cs 001");
            if (list == null)
            {
                Console.WriteLine("要排序的数列为null，无法排序。程序为求效率，没有进行数列为null的检验。");
                //Console.ReadLine();
            }
            List<Element> lstElement = list;
            List<Element> lstOriginalElement = new List<Element>(lstElement.AsEnumerable());
            lstElement.InsertionSort(descending);
            Tools.testError(lstElement, lstOriginalElement, descending);
            Console.WriteLine();
        }
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestInsertionSort001(bool descending)
        {
            Console.WriteLine("Test: _InsertionSort.cs 001");
            int count = Tools.seed.Next(0, 11);// 0 1 2 3 4 5 6 7 8 9 10
            TestInsertionSort001(count, descending);
        }
    }
    /// <summary>
    /// 用于对归并排序进行测试的类
    /// </summary>
    partial class Test_MergeSort
    {
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestMergeSort001(int listCount, bool descending)
        {
            Console.WriteLine("Test: _MergeSort.cs 001");
            if (listCount < 0)
            {
                Console.WriteLine("要测试元素数目小于0的数列，这是无法实现的。程序也屏蔽了这个问题，无需担心。");
                //Console.ReadLine();
            }
            List<Element> lstElement = Tools.RandomSequentialNumbersWith2Same(0, listCount);
            TestMergeSort001(lstElement, descending);
        }
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestMergeSort001(List<Element> list, bool descending)
        {
            Console.WriteLine("Test: _MergeSort.cs 001");
            if (list == null)
            {
                Console.WriteLine("要排序的数列为null，无法排序。程序为求效率，没有进行数列为null的检验。");
                //Console.ReadLine();
            }
            List<Element> lstElement = list;
            List<Element> lstOriginalElement = new List<Element>(lstElement.AsEnumerable());
            lstElement.MergeSort(descending);
            Tools.testError(lstElement, lstOriginalElement, descending);
            Console.WriteLine();
        }
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestMergeSort001(bool descending)
        {
            Console.WriteLine("Test: _MergeSort.cs 001");
            int count = Tools.seed.Next(0, 11);// 0 1 2 3 4 5 6 7 8 9 10
            TestMergeSort001(count, descending);
        }
    }
    /// <summary>
    /// 用于对快速排序进行测试的类
    /// </summary>
    partial class Test_QuickSort
    {
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestQuickSort001(int listCount, bool descending)
        {
            Console.WriteLine("Test: _QuickSort.cs 001");
            if (listCount < 0)
            {
                Console.WriteLine("要测试元素数目小于0的数列，这是无法实现的。程序也屏蔽了这个问题，无需担心。");
                //Console.ReadLine();
            }
            List<Element> lstElement = Tools.RandomSequentialNumbersWith2Same(0, listCount);
            TestQuickSort001(lstElement, descending);
        }
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestQuickSort001(List<Element> list, bool descending)
        {
            Console.WriteLine("Test: _QuickSort.cs 001");
            if (list == null)
            {
                Console.WriteLine("要排序的数列为null，无法排序。程序为求效率，没有进行数列为null的检验。");
                //Console.ReadLine();
            }
            List<Element> lstElement = list;
            List<Element> lstOriginalElement = new List<Element>(lstElement.AsEnumerable());
            lstElement.QuickSort(descending);
            Tools.testError(lstElement, lstOriginalElement, descending);
            Console.WriteLine();
        }
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestQuickSort001(bool descending)
        {
            Console.WriteLine("Test: _QuickSort.cs 001");
            int count = Tools.seed.Next(0, 11);// 0 1 2 3 4 5 6 7 8 9 10
            TestQuickSort001(count, descending);
        }
    }
    /// <summary>
    /// 用于对选择排序进行测试的类
    /// </summary>
    partial class Test_SelectionSort
    {
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestSelectionSort001(int listCount, bool descending)
        {
            Console.WriteLine("Test: _SelectionSort.cs 001");
            if (listCount < 0)
            {
                Console.WriteLine("要测试元素数目小于0的数列，这是无法实现的。程序也屏蔽了这个问题，无需担心。");
                //Console.ReadLine();
            }
            List<Element> lstElement = Tools.RandomSequentialNumbersWith2Same(0, listCount);
            TestSelectionSort001(lstElement, descending);
        }
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestSelectionSort001(List<Element> list, bool descending)
        {
            Console.WriteLine("Test: _SelectionSort.cs 001");
            if (list == null)
            {
                Console.WriteLine("要排序的数列为null，无法排序。程序为求效率，没有进行数列为null的检验。");
                //Console.ReadLine();
            }
            List<Element> lstElement = list;
            List<Element> lstOriginalElement = new List<Element>(lstElement.AsEnumerable());
            lstElement.SelectionSort(descending);
            Tools.testError(lstElement, lstOriginalElement, descending);
            Console.WriteLine();
        }
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestSelectionSort001(bool descending)
        {
            Console.WriteLine("Test: _SelectionSort.cs 001");
            int count = Tools.seed.Next(0, 11);// 0 1 2 3 4 5 6 7 8 9 10
            TestSelectionSort001(count, descending);
        }
    }
    /// <summary>
    /// 用于对希尔排序进行测试的类
    /// </summary>
    partial class Test_ShellSort
    {
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestShellSort001(int listCount, bool descending)
        {
            Console.WriteLine("Test: _ShellSort.cs 001");
            if (listCount < 0)
            {
                Console.WriteLine("要测试元素数目小于0的数列，这是无法实现的。程序也屏蔽了这个问题，无需担心。");
                //Console.ReadLine();
            }
            List<Element> lstElement = Tools.RandomSequentialNumbersWith2Same(0, listCount);
            TestShellSort001(lstElement, descending);
        }
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestShellSort001(List<Element> list, bool descending)
        {
            Console.WriteLine("Test: _ShellSort.cs 001");
            if (list == null)
            {
                Console.WriteLine("要排序的数列为null，无法排序。程序为求效率，没有进行数列为null的检验。");
                //Console.ReadLine();
            }
            List<Element> lstElement = list;
            List<Element> lstOriginalElement = new List<Element>(lstElement.AsEnumerable());
            lstElement.ShellSort(descending);
            Tools.testError(lstElement, lstOriginalElement, descending);
            Console.WriteLine();
        }
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestShellSort001(bool descending)
        {
            Console.WriteLine("Test: _ShellSort.cs 001");
            int count = Tools.seed.Next(0, 11);// 0 1 2 3 4 5 6 7 8 9 10
            TestShellSort001(count, descending);
        }
    }
    /// <summary>
    /// 用于对堆排序进行测试的类
    /// </summary>
    partial class Test_HeapSort
    {
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestHeapSort001(int listCount, bool descending)
        {
            Console.WriteLine("Test: _HeapSort.cs 001");
            if (listCount < 0)
            {
                Console.WriteLine("要测试元素数目小于0的数列，这是无法实现的。程序也屏蔽了这个问题，无需担心。");
                //Console.ReadLine();
            }
            List<Element> lstElement = Tools.RandomSequentialNumbersWith2Same(0, listCount);
            TestHeapSort001(lstElement, descending);
        }
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestHeapSort001(List<Element> list, bool descending)
        {
            Console.WriteLine("Test: _HeapSort.cs 001");
            if (list == null)
            {
                Console.WriteLine("要排序的数列为null，无法排序。程序为求效率，没有进行数列为null的检验。");
                //Console.ReadLine();
            }
            List<Element> lstElement = list;
            List<Element> lstOriginalElement = new List<Element>(lstElement.AsEnumerable());
            lstElement.HeapSort(descending);
            Tools.testError(lstElement, lstOriginalElement, descending);
            Console.WriteLine();
        }
        /// <summary>
        /// 测试方法001
        /// </summary>
        public static void TestHeapSort001(bool descending)
        {
            Console.WriteLine("Test: _HeapSort.cs 001");
            int count = Tools.seed.Next(0, 11);// 0 1 2 3 4 5 6 7 8 9 10
            TestHeapSort001(count, descending);
        }
    }
    class SimpleTester
    {
        public static void StartTest(int listCount, bool descending)
        {
            Test_BubbleSort.TestBubbleSort001(listCount, descending);
            Test_InsertionSort.TestInsertionSort001(listCount, descending);
            Test_MergeSort.TestMergeSort001(listCount, descending);
            Test_QuickSort.TestQuickSort001(listCount, descending);
            Test_SelectionSort.TestSelectionSort001(listCount, descending);
            Test_ShellSort.TestShellSort001(listCount, descending);
            Test_HeapSort.TestHeapSort001(listCount, descending);
        }
        public static void StartTest()
        {
            StartTest(10, false);
        }
    }
}
