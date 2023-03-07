using Task2;
//Выполнить: Вводятся элементы двумерного массива 4 х 3. Посчитайте количество положительных элементов.

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 3];
            Console.WriteLine("Пожалуйста, введите значения матрицы 4 х 3");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = Enter.Check();
                }
            }
            Console.WriteLine("Матрица:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int positive = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arr[i, j] > 0) { positive++; }
                }
            }
            Console.WriteLine($"кол-во положительных ={positive}");
        }
    }
}