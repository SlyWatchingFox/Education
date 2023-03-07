namespace Task1
{
    //Выполнить:

    //Выведите значение температуры на 2-й метеостанции в течение 4-го дня и на 3-й метеостанции в течение 1-го дня(результат должен быть 20 и 11).
    //Выведите значения температуры всех метеостанций в течение 2-го дня(необходим for цикла).
    //Выведите значения температуры всех метеостанций в течение всех дней.
    //Рассчитайте среднюю температуру на 3-й метеостанции(необходим for цикла).
    //Выведите дни и номера метеостанций, где температура была в диапазоне 24—26 градусов.


    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] t = {
                {-8,-14,-19,-18},
                { 25,28, 26, 20},
                { 11,18, 20, 25}
                };
            Console.WriteLine($"{t[1, 3]} и {t[2, 0]}");
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < t.GetLength(1); i++) { Console.Write($"{t[1, i]} "); }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    Console.Write(t[i, j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < t.GetLength(1); i++) { Console.Write($"{t[0, i]} "); }
            Console.WriteLine();
            for (int i = 0; i < t.GetLength(1); i++) { Console.Write($"{t[1, i]} "); }
            Console.WriteLine();
            for (int i = 0; i < t.GetLength(1); i++) { Console.Write($"{t[2, i]} "); }
            Console.WriteLine();
            Console.WriteLine();

            int sumTemp = 0;
            int midTemp = 0;
            for (int i = 0; i < t.GetLength(1); i++)
            {
                midTemp++;
                sumTemp += t[2, i];
            }
            Console.WriteLine(sumTemp / midTemp);
            Console.WriteLine();

            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    if (24 < t[i,j]&& t[i, j] < 26)
                    {
                        Console.WriteLine($"станция {i+1}  день {j+1}");
                    }
                }
            }
        }
    }
}// почему не выводится один день?