using System.Diagnostics;
using System.IO;
//Задание 1:
//Выполнить: Скопируйте файл L01.dat для предыдущей лабораторной работы и вставьте его в папку текущего задания,
//пусть к файлу: (~/ Lesson_14Task1 / bin / Debug).
//1.Создайте программу для вывода чисел в квадрате из файла в окно консоли (числа могут быть выведены через пробел в
//пределах одной строки), а также для вычисления количества четных цифр среди чисел. Вы должны использовать класс BinaryReader.
//Создайте программу, используя блок try..catch.
//Указание: Здесь нет необходимости создавать методы.
//Примерный вывод:
//Квадраты чисел:
//1 4 9 16 25 36 49 64 81 100 121 144 169 196 225
//Количество четных: 7
//++++++++++++++ +
//Ошибка чтения из файла: Файл 'c:\users\user\documents\visual studio 2015\Projects\L_14Task1\bin\Debug\L02.dat' не найден.
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\SlyWatchingFox\source\repos\Education\LabsOrg\Lesson14\Task1\bin\Debug\L01.dat";
            var count = 0;
            try
            {
                using (var fs = new FileStream(path, FileMode.Open))
                using (var br = new BinaryReader(fs))
                    while (br.PeekChar() != -1)
                    {
                        var x = Math.Pow(br.ReadInt32(), 2);
                        Console.Write($"{x} ");
                        if (x % 2 == 0) { count++; }
                    }
                Console.WriteLine();
                Console.WriteLine($"Количество четных:{count}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Ошибка чтения из файла: {e.Message}");
            }
        }
    }
}