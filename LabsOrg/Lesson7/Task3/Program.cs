using System.Runtime.Intrinsics.X86;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10];
            RandomArray(arr);
            PrintArray(arr);
            Sum(arr);
        }
        static void RandomArray(double[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.NextDouble() * 10 - 5;
            }
        }
        static void PrintArray(double[] arr)
        {
            Console.WriteLine("Массив");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0:0.00} ", arr[i]);
            }
            Console.WriteLine();
        }
        static void Sum(double[] arr)
        {
            double a0 = 0;
            double a1 = 0;
            double a2 = 0;
            double a3 = 0;
            double a4 = 0;
            double a5 = 0;
            double a6 = 0;
            double a7 = 0;
            
            foreach (double i in arr)
            {
                a0 = arr[0] + arr[1] + arr[2];
                a1 = arr[1] + arr[2] + arr[3];
                a2 = arr[2] + arr[3] + arr[4];
                a3 = arr[3] + arr[4] + arr[5];
                a4 = arr[4] + arr[5] + arr[6];
                a5 = arr[5] + arr[6] + arr[7];
                a6 = arr[6] + arr[7] + arr[8];
                a7 = arr[7] + arr[8] + arr[9];
                

            }
            Console.WriteLine("суммы троек:");
            Console.Write($"{a0.ToString("F" + 2)} {a1.ToString("F" + 2)} {a2.ToString("F" + 2)} {a3.ToString("F" + 2)} {a4.ToString("F" + 2)} {a5.ToString("F" + 2)} {a6.ToString("F" + 2)} {a7.ToString("F" + 2)} ");
            Console.WriteLine();
        }

    }
}