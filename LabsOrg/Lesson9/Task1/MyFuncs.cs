using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class MyFuncs
    {
        public static void PrintArr<T>(this T[] arr)
        {
            foreach (var x in arr)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }
        public static void FindEven<T>(this T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{arr[i]} ");
                }
                
            }
            Console.WriteLine();
        }
    }
}
