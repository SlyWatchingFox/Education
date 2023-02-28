var list = new List<int>();
int num;
int pol = 0;
int otr = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Введите число");
    if (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Не верный ввод.Введите следующее число");
    }
    list.Add(num);
    if (num > 0)
    {
        pol++;
    }
    else
    {
        otr++;
    }
}
Console.WriteLine($"Положительных: {pol} Отрицательных: {otr}");