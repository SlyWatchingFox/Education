namespace Task2;
//To do: Вводятся элементы двумерного массива 2 х 3 ([2, 3]). Посчитайте сумму элементов.
//Указание 1: Для объявления массива размерностью 2 х 3 используйте код: 
//int[,] arr = new int[2, 3];
//Указание 2: Для ввода значений элементов массива и перебора элементов, воспользуйтесь вложенными циклами:
//for (int i = 0; i< 2; i++)
//            {
//                for (int j = 0; j< 3; j++)
//                {
//                   ...
//                }
//            }
class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[2, 3];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                arr[i, j] = Enter.Check();
            }
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        int sum = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                sum += arr[i, j];
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Сумма: {sum}");
    }
}

