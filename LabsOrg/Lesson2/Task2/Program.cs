using static System.Math;
int a, b, c;
Console.WriteLine("Введите число");
if (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Не верный ввод.");
    Environment.Exit(1);
}

c = a % 10;
b = a / 10;

Console.WriteLine($"Единицы {Math.Abs(c)}"); //"Единицы",
Console.WriteLine($"Десятки {Math.Abs(b)}"); //"Десятки"
