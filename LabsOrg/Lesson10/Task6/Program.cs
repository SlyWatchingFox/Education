//To do: Создайте метод FindProductOfColumn для нахождения произведения элементов матрицы M-го столбца (матрица 3 х 4) (M вводится).
//M — это параметр out (вывода).
//Note: Сигнатура метода FindProductOfColumn должна быть следующей:
//static void FindProductOfColumn(int[,] matrix, int M, out int product)
using Calcul;
using System.Transactions;

namespace Task6
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
            int minValue = -99;
            int maxValue = 99;
            FillMatrix(matrix, minValue, maxValue);
            Console.WriteLine();
            Console.WriteLine($"Введите номер столбца:");
            var M = Enter.Check() - 1;
            int product = 0;
            FindProductOfColumn(matrix, M, product);


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
        static void FindProductOfColumn(int[,] matrix, int M, int product)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == M) { product += matrix[i, j]; }
                }
            }
            Console.WriteLine($"Произведение элементов 2-го столбца = {product}");

        }
    }
}