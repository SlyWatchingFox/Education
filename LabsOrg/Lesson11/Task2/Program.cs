using System.ComponentModel;

namespace Task2
//Задание 2: С методами и без методов
//Выполнить: Создайте программу для поиска символа s в строке.Выведите значение true, если символ s найден,
//и false — если не найден.
//Указание 1: Выполните программу разными способами: 1) используя метод Contains и
//2) используя проход по символам строки циклом for.
//Указание 2: Возможно, вам пригодится логическая переменная:
//bool b = false;
//Указание 3: Для выхода из цикла можно использовать оператор break:
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine(str.Contains("s"));
            bool b = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 's')
                {
                    b = true;
                    break;
                }
            }
            Console.WriteLine(b);
        }
    }
}