using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class L8MyFunctions
    {
        public static void RandomArray(int[] arr, int minValue = -10, int maxValue = 10)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(minValue, maxValue);
            }
        }
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("Массив");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public static void FindEven(int[] arr, out int con)
        {
            con = 0;
            Console.WriteLine("четный элементы: ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    con++;
                    Console.WriteLine($"{arr[i]} index: {i}");
                }

            }
            //foreach (int i in arr)
            //{
            //    if (i % 2 == 0)
            //    {
            //        con++;
            //        Console.WriteLine($"{i}");

            //    }

            //}
        }
    }
}
