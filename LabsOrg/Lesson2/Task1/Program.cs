int a;
Console.WriteLine("Введите число");
if (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Не верный ввод.");
    Environment.Exit(1);
}

if (a > 0)
{
    Console.WriteLine("введенное число положительное");
}
else if (a < 0)
{
    Console.WriteLine("введенное число отрицательное");
}
else
{
    Console.WriteLine("введенное число равно 0");
}