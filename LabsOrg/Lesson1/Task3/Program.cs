double a, c, p, s;
Console.WriteLine("Введите сторону треугольника");
if (!double.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Не верный ввод");
    Environment.Exit(1);
}

p = a * 3;
c = Math.Sqrt(3);
s = (a * a * c) / 4;
Console.WriteLine(p);
Console.WriteLine(s);