namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность, завершите ввод 0");
            int counterPositive = 0;
            int counterNegative = 0;
            PosNegSeq(ref counterPositive, ref counterNegative);
            Console.WriteLine($"Кол-во отрицательных: {counterNegative}, количество положительных: {counterPositive}");
        }
        static void PosNegSeq(ref int counterPositive, ref int counterNegative)
        {

            int num;
            do
            {
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Не верный ввод. Повторите");
                }
                if (num > 0 && num != 0) { counterPositive++; }
                if (num < 0 && num != 0) { counterNegative++; }

            }
            while (num != 0);
        }
        //Выполнить: Создайте функцию PosNegSeq(), которая принимает два аргумента по ссылке — счетчики положительных чисел последовательности и отрицательных чисел.
        //Пользователь вводит последовательность целых чисел, завершая ввод 0. Функция должна посчитать количество отрицательных и положительных чисел и вернуть
        //значения счетчиков в главную программу.
        //Указание 1: Функция не должна возвращать значение(поэтому используется ключевое слово void в объявлении функции). Параметр ref — это параметр ввода-вывода,
        //чтo означает, что значения параметров будут изменены внутри функции и возвращены в основную программу.
        //Указание 2: Параметры ref должны быть инициализированы до вызова функции.Поэтому сначала вам необхзодимо инициализировать такие параметры значениями.
        //Установите начальные значения для этих параметров, равные 0:


    }
}