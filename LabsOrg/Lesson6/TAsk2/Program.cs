using System;

namespace TAsk2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральные числа N и a:");
            int N, a;
            while (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            } while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
            IEnumerable<int> seq;
            seq = System.Linq.Enumerable.Range(N, a);
            foreach (var x in seq)
                Console.Write($"{x} ");
        }
        //Выполнить: Создайте последовательность из N целых чисел, начинающихся с a.a и N — это натуральные числа.
    }
}