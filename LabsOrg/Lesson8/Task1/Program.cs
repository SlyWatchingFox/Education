using System.ComponentModel;

namespace Task1
{
    //Выполнить: Создайте новый класс MyFuncs.В созданном классе создайте метод Add() для сложения двух чисел.
    //Указание: Метод Add() должен быть с двумя параметрами. Метод должен возвращать сумму этих двух параметров.
    //Вызовите метод в функции Main.Заголовок метода должен быть следующим:
    //public static int Add(int i, int j)

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите два числа ");
            int i = 0;
            int j = 0;
            i = Check();
            j = Check();
            Console.WriteLine("сумма: " + MyFuncs.Sum(i, j));
        }
        static int Check()
        {
            int i;
            while (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
            return i;
        }
    }
}