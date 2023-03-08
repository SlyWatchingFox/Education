using System;

namespace Task4
//Задание 4:
//Выполнить: Вводится строка(переменная s). Удалите всё между !первыми! двумя символами ‘*‘.     //Вопрос!//
//Если в cтроке нет таких символов, не меняйте ничего.Если в строке только один символ*, удалите всё до конца,
//начиная с этого символа. Используйте класс string (не StringBuilder).
//Указание 1: Лучше использовать методы Contains, IndexOf и Remove.Метод IndexOf может принимать два параметра:
//IndexOf(char value, int StartIndex)
//Указание 2: Создайте метод RemoveBetweenChars с двумя параметрами, they are the строка и символ
//(для символа должно быть указано значение по умолчанию*). Вызовите метод дважды с разными параметрами.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string sym = "*";
            RemoveBetweenChars(str, sym);
        }
        public static void RemoveBetweenChars(string str, string sym)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '*')
                {
                    count++;
                }
            }
            if(count > 1) 
            {
                Console.WriteLine($"Результат для строки {str} и символа *: {str.Remove(str.IndexOf(sym)+1,str.LastIndexOf(sym)-str.IndexOf(sym)-1)}");
            }
            else if (count == 1) 
            {
                Console.WriteLine($"Результат для строки {str} и символа *: {str.Remove(str.IndexOf(sym))}");
            }
            else { Console.WriteLine("Нет изменений"); }
        }

    }
}