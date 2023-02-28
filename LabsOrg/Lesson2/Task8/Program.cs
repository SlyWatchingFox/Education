Console.WriteLine("Введите число от 1 до 7");
string day = Console.ReadLine();
switch (day)
{
    case "1":
        Console.WriteLine("понедельник");
        break;
    case "2":
        Console.WriteLine("вторникк");
        break;
    case "3":
        Console.WriteLine("среда");
        break;
    case "4":
        Console.WriteLine("четверг");
        break;
    case "5":
        Console.WriteLine("пятница");
        break;
    case "6":
        Console.WriteLine("суббота");
        break;
    case "7":
        Console.WriteLine("воскресенье");
        break;
    default:
        Console.WriteLine("такого дня недели нету, введите число от 1 до 7");
        break;

}