var list = new List<double>();
double num;
double sum = 0;
while (list.Count < 5)
{
    Console.WriteLine("Введите число");
    if (!double.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Не верный ввод.Введите следующее число");
    }
    list.Add(num);
    sum += num;
}
Console.WriteLine(Math.Round(sum, 3));