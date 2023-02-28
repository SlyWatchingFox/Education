int a, b, c;
Console.WriteLine("Введите три числа");
if (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Не верный ввод.");
    Environment.Exit(1);
}
if (!int.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine("Не верный ввод.");
    Environment.Exit(1);
}
if (!int.TryParse(Console.ReadLine(), out c))
{
    Console.WriteLine("Не верный ввод.");
    Environment.Exit(1);
}
if (a!=b || b!=c || a!=c)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}