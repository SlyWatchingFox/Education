// See https://aka.ms/new-console-template for more information
string ResMassage = String.Empty;
double a, b;
char sign;

while (Console.ReadKey().Key== ConsoleKey.Y)
{
    Console.WriteLine("Введите первое число:");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите знак:");
    sign = Console.ReadKey().KeyChar;
    Console.WriteLine("Введите второе число:");
    b = Convert.ToDouble(Console.ReadLine());

    if (sign == '+')
    {
        ResMassage = (a+ b).ToString();
    }
    if (sign == '-')
    {
        ResMassage = (a- b).ToString();
    }
    else 
    {
        ResMassage = "Неизвестный символ";
    }
    Console.WriteLine(ResMassage);
}