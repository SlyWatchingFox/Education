using System.Text;

namespace Task5
//Задание 5:
//Выполнить: Даны две строки.Добавьте такое кол-во пробелов к той строке, которая короче,
//чтобы длина строк стала одинаковой.Используйте класс StringBuilder.
//Указание 1: Для выполнения задания проще использовать метод Append.
//Указание 2: Создайте метод AddSpaces с двумя аргументами - сама строка и кол-во пробелов, которые необходимо добавить.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первую строку");
            string str1 = Console.ReadLine();
            Console.WriteLine("введите вторую строку");
            string str2 = Console.ReadLine();
            int diff = 0;
            if (str1.Length < str2.Length)
            {
                diff = str2.Length - str1.Length;
                AddSpace(str1, diff);
            }
            else if (str1.Length > str2.Length)
            {
                diff = str1.Length - str2.Length;
                AddSpace(str2, diff);
            }
        }
        public static void AddSpace(string str, int diff)
        {
            StringBuilder sb = new StringBuilder(str);
            sb.Append(' ',diff);
            Console.WriteLine($"{sb}.");
        }
    }
}