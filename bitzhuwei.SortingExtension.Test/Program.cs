//#define CONSOLE_TO_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace bitzhuwei.SortingExtension.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("测试正在进行。。。");
#if CONSOLE_TO_FILE
            TextWriter orginal = Console.Out;
            string output = "SmileWei.Sorting.SimpleTest.txt";
            TextWriter tw = new StreamWriter(output);
            Console.SetOut(tw);
#endif
            SimpleTester.StartTest(100,false);
            //for (int i = 11 - 1; i >= 0; i--)
            //{
            //    SimpleTester.StartTest(i, false);
            //}
#if CONSOLE_TO_FILE
            tw.Close();
            Console.SetOut(orginal);
            Console.WriteLine("测试已经完成，请查阅{0}。", output);
#else
            Console.WriteLine("测试已经完成。");
#endif
            Console.ReadLine();
        }
    }
}
