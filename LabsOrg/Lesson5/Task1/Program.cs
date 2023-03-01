using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение для трёх сторон треугольника:");
            int a, b, c;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
            Perimeter(a, b, c);
        }
        static void Perimeter(int a, int b, int c)
        {
            int perimeter = a + b + c;
            Console.WriteLine($"Периметр: {perimeter}");
        }
        //        Выполнить: Вводятся три числа — длины трех сторон треугольника.Создайте функцию Perimeter(), которая вычисляет периметр треугольника по длинам трех его сторон.
        //Указание 1: Метод Perimeter() должен принимать в качестве аргументов три целых числа.
        //Указание 2: Метод не должен возвращать никакого значения, поэтому вы должны использовать ключевое слово void в сигнатуре:
        //static void Perimeter(...);
        //        Указание 3: Не забудьте преобразовать введенные значения в целые числа.Например:
        //int a = int.Parse(Console.ReadLine());
    }
}