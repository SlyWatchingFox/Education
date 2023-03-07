using Calcul;
//To do: Создайте метод PlaceZero, который замещает некоторые элементы матрицы (5 х 5) нулями(0).Посмотрите на пример вывода, чтобы понять, какие элементы должны быть замещены нулями.
//Указание 1: Создайте методы для заполнения и вывода матрицы.
//Указание 2: Заголовок метода PlaceZero должен быть следующим: 
//static void PlaceZero(int[,] matrix)
//Указание 3: Для замены элементов нулями используйте циклы.

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int columns = 5;
            int[,] matrix = new int[rows, columns];
            int minValue = -15;
            int maxValue = 15;
            FillMatrix(matrix, minValue, maxValue);
            int min = 0;
            int max = 0;
            Console.WriteLine();
            PlaceZero(matrix);
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
        
        static void PlaceZero(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0) { matrix[i, j] = 0; }
                    if (i == 4) { matrix[i, j] = 0; }
                    if (j == 0) { matrix[i, j] = 0; }
                    if (j == 4) { matrix[i, j] = 0; }
                    Console.Write($"{matrix[i, j].ToString().PadLeft(4)} ");
                }
                Console.WriteLine();
            }

        }

    }
}