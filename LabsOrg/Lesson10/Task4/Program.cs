using Calcul;
using System.Transactions;

//Выполнить: Создайте метод FillMatrix для заполнения двумерного массива случайными числами от -15 до 15.
//Создайте еще один метод для нахождения минимального и максимального элементов массива (FindMinMaxArr).
//Указание 1: Сигнатура(заголовок) метода FindMinMaxArr должен быть таким: 
//private static void FindMinMaxArr(int[,] matrix, ref int min, ref int max)
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите кол-во строк");
            int rows = Enter.Check();
            Console.WriteLine("введите кол-во столбцов");
            int columns = Enter.Check();
            int[,] matrix = new int[rows, columns];
            int minValue = -15;
            int maxValue = 15;
            FillMatrix(matrix, minValue, maxValue);
            int min = 0;
            int max = 0;
            FindMinMaxArr(matrix, ref min, ref max);
        }

        public static void FillMatrix(int[,] matrix, int minValue, int maxValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(minValue, maxValue);
                    Console.Write($"{matrix[i, j].ToString().PadLeft(4)} ");
                }
                Console.WriteLine();
            }
        }
        public static void FindMinMaxArr(int[,] matrix, ref int min, ref int max)
        {
            min = int.MaxValue;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min) { min = matrix[i, j]; }
                }

            }
            Console.WriteLine($"Min = {min}");
            max = int.MinValue;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max) { max = matrix[i, j]; }
                }

            }
            Console.WriteLine($"Max = {max}");
        }
    }
}
