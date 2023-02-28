// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

char again = 'y';
while (again == 'y')
{
    double a;
    Console.WriteLine("Введите первое число:");
    a = Convert.ToDouble(Console.ReadLine());

    char sign;
    Console.WriteLine("Введите знак");
    sign = Convert.ToChar(Console.ReadLine());

    double b;
    Console.WriteLine("Введите второе число:");
    b = Convert.ToDouble(Console.ReadLine());



    double total;

    if (sign == '+')
    {
        total = a + b;
        Console.WriteLine(total);
    }
    else if (sign == '-')
    {
        total = a - b;
        Console.WriteLine(total);
    }
    else if (sign == '*')
    {
        total = a * b;
        Console.WriteLine(total);
    }
    else if (sign == '/')
    {
        total = a / b;
        Console.WriteLine(total);
    }
    else if (sign == '^')
    {
        total = Math.Pow(a, b);
        Console.WriteLine(total);
    }
    else if (sign == '%')
    {
        total = a % b;
        Console.WriteLine(total);
    }
    else
    {
        Console.WriteLine("Неизвестный символ");
    }
    Console.WriteLine("Продолжить?(y)");
    again = Convert.ToChar(Console.ReadLine());
}