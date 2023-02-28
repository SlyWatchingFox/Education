double a, b, c;
Console.WriteLine("введите первое число");
if (!double.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Не верный ввод");
    Environment.Exit(1);
}
Console.WriteLine("введите второе число");
if (!double.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine("Не верный ввод");
    Environment.Exit(1);
}
c = (a + b) / 2;
Console.WriteLine(c);