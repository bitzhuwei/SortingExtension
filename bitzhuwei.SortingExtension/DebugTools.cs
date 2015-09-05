using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace System
{
#if DEBUG
    /// <summary>
    /// 调试工具，此类不应被程序集外部代码访问，因为此程序集只提供对IList&lt;T&gt;的排序功能
    /// </summary>
    internal static class DebugTools
    {
        /// <summary>
        /// 以“[3][5][7][2][8][4]”的形式输出数列
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void WriteList<T>(this IList<T> list)
        {
            foreach (var v in list)
            {
                Console.Write("[" + v + "]");
            }
            Console.WriteLine();
        }
    }
#endif
}
