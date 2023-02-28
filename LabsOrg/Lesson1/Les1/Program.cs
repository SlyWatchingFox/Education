int n;
Console.WriteLine("введите число");
if (!int.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("Не верный ввод");
    Environment.Exit(1);
}
n++;
Console.WriteLine(n);

