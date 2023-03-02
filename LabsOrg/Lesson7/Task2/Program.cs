using System.Reflection.Metadata.Ecma335;

namespace Task2
{
    //Выполнить: Дан целочисленный массив(15 элементов, сгенерированных случайным образом в диапазоне от 1 до 10).
    //Требуется определить, есть ли в массиве элемент, равный N(N вводится). Выведите «да» или «нет» один раз.Для поиска элемента используйте цикл foreach.
    //1. Для заполнения и вывода элементов массива требуется создать функцию.
    //2. Создайте еще одну функцию FindN для поиска элемента, равного N (N — один из параметров функции).
    //Указание 1: Для выхода из цикла используйте оператор break:
    //foreach (int x in arr) 
    //            {
    //                if (...)
    //                {
    //                    ...
    //                    break; // выход
    //                }
    //            }
    //Указание 2: Для проверки того, найден ли искомый элемент, используйте логическую переменную:
    //bool f = false;
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            RandomArray(arr);
            PrintArray(arr);
            FindN(arr);
        }
        static void RandomArray(int[] arr, int minValue = 1, int maxValue = 10)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(minValue, maxValue);
            }
        }
        static void PrintArray(int[] arr)
        {
            Console.WriteLine("Массив");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        static void FindN(int[] arr)
        {
            Console.WriteLine("введите искомое значение:");
            int N, x;
            x = 0;
            N = 0;
            Check(ref N);
            Console.WriteLine(N);

            foreach (int i in arr) { if (i == N) { x = 1; } }
            if (x == 1) { Console.WriteLine("результат: да"); }
            else { Console.WriteLine("результат: нет"); }
        }
        static void Check(ref int N)
        {
            while (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
        }

    }
}