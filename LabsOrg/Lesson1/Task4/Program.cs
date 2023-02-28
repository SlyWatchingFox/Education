int a, b, c, d;
Console.WriteLine("Введите четыре числа");
if (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Не верный ввод");
    Environment.Exit(1);
}
if (!int.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine("Не верный ввод");
    Environment.Exit(1);
}
if (!int.TryParse(Console.ReadLine(), out c))
{
    Console.WriteLine("Не верный ввод");
    Environment.Exit(1);
}
if (!int.TryParse(Console.ReadLine(), out d))
{
    Console.WriteLine("Не верный ввод");
    Environment.Exit(1);
}

a=a+b;
c=c+d;
Console.WriteLine(a>c);
Console.ReadKey();