namespace Task1
{

    //    To do: Дан массив вещественных чисел(значения элементов: 1.1, -2.3, 3.7, 4.1, 5.6, 6.1, 7.1).
    //1. Создайте функцию для печати массива.
    //2. Создайте еще одну функцию для поиска минимального и максимального элементов массива.При этом использовать стандартные min и max функции запрещено.
    //Указание 1: Поиск максимального и минимального значения осуществлен в Лабораторной работе 4 5-го урока.
    //Указание 2: Создайте функцию Print для печати элементов массива.
    //Указание 3: Создайте функцию FindMaxMin с циклом foreach и оператором if для поиска максимального и минимального значения.
    //Заголовок функции должен выглядеть следующим образом:
    //static void FindMaxMin(double[] arr, ref double max, ref double min) {}
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] a = { 1.1, -2.3, 3.7, 4.1, 5.6, 6.1, 7.1 };
            Print(a);
            double max = 0;
            double min = 0;
            FindMaxMin(a, ref max, ref min);
            Console.WriteLine($"максимальный элемент: {max}, минимальный элемент: {min}");
        }
        static void Print(double[] arr)
        {
            Console.WriteLine("Массив");
            foreach (double x in arr)
            Console.Write($"{x} ");
            Console.WriteLine();
        }
        static void FindMaxMin(double[] arr, ref double max, ref double min)
        {
            foreach (double x in arr)
            {
                if (x>max) max = x;
                if (x<min) min = x;
            }

        }
    }
}