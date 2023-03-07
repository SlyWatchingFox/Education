namespace Lesson11._1
    // Домашнее задание
    // Реализовать операции +,-,<,>,<=,<=,==,!= для класса из предметной области.

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("Красное яблоко", 100,100);
            Apple apple2 = new Apple("Зеленое яблоко", 90,110);
            var sumApple = Apple.Add(apple,apple2);
            var sumApple2 = apple + apple2;
            var sumApple3 = apple + 100;
            Console.WriteLine(apple);
            Console.WriteLine(apple2);
            Console.WriteLine(sumApple);
            Console.WriteLine(sumApple2);
            Console.WriteLine(sumApple3);
            Console.WriteLine(apple==apple2);
            Console.WriteLine(sumApple==sumApple2);

            Console.ReadLine();
        }
    }
}