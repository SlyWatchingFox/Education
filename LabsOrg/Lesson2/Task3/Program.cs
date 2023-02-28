int a, a1, a2, a3;
Console.WriteLine("Введите трёхзначное число");
if (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Не верный ввод.");
    Environment.Exit(1);
}
a1 = a % 10;
a2 = a / 10 % 10;
a3 = a / 100;
Console.WriteLine(a3);
Console.WriteLine(a2);
Console.WriteLine(a1);
a = a3 * 100 + a1;
Console.WriteLine(a);