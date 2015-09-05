//#define CONSOLE_TO_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace bitzhuwei.SortingExtension.Test
{
    public static class Tools
    {
        public static readonly Random seed = new Random();
        /// <summary>
        /// 以“[3][5][7][2][8][4]”的形式输出数列
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void WriteList<T>(this IList<T> list)
        {
            foreach (var v in list)
            {
                Console.Write("[" + v.ToString() + "]");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// 获取随机排列的连续整数
        /// <para>类似洗牌的功能</para>
        /// </summary>
        /// <param name="start">最小值</param>
        /// <param name="count">数组元素数目</param>
        /// <returns></returns>
        public static List<int> RandomSequentialNumbers(int start, int count)
        {
            if (count < 0)
                throw new Exception("数列元素数目不能小于0");
            List<int> result = new List<int>(Enumerable.Range(start, count));
            int shuffle = seed.Next(count / 2, count * 2);
            for (int i = 0; i < shuffle; i++)
            {
                int a = seed.Next(0, count / 2);
                int b = seed.Next(count / 2, count);
                int temp = result[a];
                result[a] = result[b];
                result[b] = temp;
            }
            return result;
        }
        public static List<Element> RandomSequentialNumbersWith2Same(int start, int count)
        {
            List<Element> list = new List<Element>();
            if (count <= 0) return list;

            List<int> intlist = RandomSequentialNumbers(start, count);
            for (int i = 0; i < intlist.Count; i++)
            {
                list.Add(new Element(i, intlist[i]));
            }
            if (count == 1) return list;

            int index = seed.Next(0, count);
            int repeatNumber;
            do
            {
                repeatNumber = seed.Next(start, start + count);
            } while (repeatNumber == list[index].Value);
            list[index].Value = repeatNumber;
            return list;
        }
        public static void testError(List<Element> lstData, List<Element> lstOriginalData, bool descending)
        {
            if (descending)
            {
                testErrorDescending(lstData, lstOriginalData);
            }
            else
            {
                testErrorAscending(lstData, lstOriginalData);
            }
        }
        public static void testErrorDescending(List<Element> lstData, List<Element> lstOriginalData)
        {
            for (int i = 0; i < lstData.Count - 2; i++)
            {
                if (lstData[i].CompareTo(lstData[i + 1]) < 0)
                {
                    Console.WriteLine("发现错误！");
                    Console.WriteLine("初始数列：");
                    lstOriginalData.WriteList();
                    Console.WriteLine("最终数列：");
                    lstData.WriteList();
#if CONSOLE_TO_FILE
#else
                    Console.ReadLine();
#endif
                }
                else if (lstData[i].CompareTo(lstData[i + 1]) == 0)
                {
                    if (lstData[i].ID >= lstData[i + 1].ID)
                    {
                        Console.WriteLine("警告：等号置换！");
                        Console.WriteLine("初始数列：");
                        lstOriginalData.WriteList();
                        Console.WriteLine("最终数列：");
                        lstData.WriteList();
#if CONSOLE_TO_FILE
#else
                        Console.ReadLine();
#endif
                    }
                }
            }
        }
        public static void testErrorAscending(List<Element> lstData, List<Element> lstOriginalData)
        {
            for (int i = 0; i < lstData.Count - 2; i++)
            {
                if (lstData[i].CompareTo(lstData[i + 1]) > 0)
                {
                    Console.WriteLine("发现错误！");
                    Console.WriteLine("初始数列：");
                    lstOriginalData.WriteList();
                    Console.WriteLine("最终数列：");
                    lstData.WriteList();
#if CONSOLE_TO_FILE
#else
                    Console.ReadLine();
#endif
                }
                else if (lstData[i].CompareTo(lstData[i + 1]) == 0)
                {
                    if (lstData[i].ID >= lstData[i + 1].ID)
                    {
                        Console.WriteLine("警告：等号置换！");
                        Console.WriteLine("初始数列：");
                        lstOriginalData.WriteList();
                        Console.WriteLine("最终数列：");
                        lstData.WriteList();
#if CONSOLE_TO_FILE
#else
                        Console.ReadLine();
#endif
                    }
                }
            }
        }

    }
    public class Element : IComparable
    {
        public Element(int id) { this.ID = id; }
        public Element(int id, int value) { this.ID = id; this.Value = value; }
        public int ID { get; set; }
        public int Value { get; set; }
        public override string ToString()
        {
            return string.Format("{0}:{1}", ID, Value);
        }

        public int CompareTo(object obj)
        {
            Element d = obj as Element;
            if (d == null)
            {
                return 1;
            }
            return this.Value - d.Value;
        }
    }
}
