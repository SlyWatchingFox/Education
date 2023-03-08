using Calcul;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace Task6
//Задание 6:
//Выполнить: Дана строка S, состоящая из двух чисел, разделенных пробелом; и задан символ C,
//который может принимать одно из следующих значений: +, -, * (знак соответствующей математической операции).
//Создайте строку, содержащую результат выполнения операции C с числами из строки S, например '2+3=5'.
//Указание 1: Создайте метод Calculate с двумя аргументами: строка S и символ C.
//Указание 2: Для перевода символа в строковое значение понадобится метод.ToString().
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Enter.Check();
            int num2 = Enter.Check();
            string str = num1 + " " + num2;
            Console.WriteLine("Введите знак: (+, -, *.)");
            char sign = Console.ReadKey().KeyChar;          // Как можно проверить на знак через while
            Console.WriteLine();
            Calculator(str, sign);
        }
        public static void Calculator(string str, char sign)
        {

            string[] numbers = str.Split(new char[] {' '});
            int index = str.IndexOf(" ");
            int num1 = Convert.ToInt32(numbers[0]);
            int num2 = Convert.ToInt32(numbers[1]);
            if (sign == '+')
            {
                int result = num1 + num2;
                Console.WriteLine($"Результат: {result}");
            }
            else if (sign == '-')
            {
                int result = num1 - num2;
                Console.WriteLine($"Результат: {result}");
            }
            else if (sign == '*')
            {
                int result = num1 * num2;
                Console.WriteLine($"Результат: {result}");
            }
        }
     
    }
}