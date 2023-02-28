using System;
using System.Collections.Generic;

int numb;
int max = int.MinValue;
Console.WriteLine("Введите последовательность чисел и закончите ввод нулем");
do
{
    if (!int.TryParse(Console.ReadLine(), out numb))
    {

        Console.WriteLine("Не верный ввод.");
    }
    if (numb != 0 && numb > max)
    {
        max = numb;
    }
}
while (numb!=0);
Console.WriteLine(max);
    