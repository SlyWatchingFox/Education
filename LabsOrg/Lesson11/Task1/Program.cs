using System.Data.SqlTypes;
using System;

namespace Task1
//Выполнить: Запрашивается символ(переменная c). Переменная s строкового типа содержит ровно два символа c.
//Найдите подстроку между этими двумя символами.Используйте класс string (не StringBuilder).
//Указание 1: Для решения задания лучше использовать методы Substring, IndexOf и LastIndexOf.
//Указание 2: Создайте пользовательский метод BetweenChars с двумя аргументами — сама строка и символ.
//Вызовите метод дважды с разными значениями параметров.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ");
            string c = Console.ReadLine();
            Console.WriteLine("Введите строку");
            string s = c + Console.ReadLine() + c;
            int indexOf = s.IndexOf(c)+1;
            int lastIndexOf = s.LastIndexOf(c);
            string result = s.Substring(indexOf,lastIndexOf-indexOf);
            Console.WriteLine($"Результат для строки {s} и символа {c}: {result}");


        }
    }
}