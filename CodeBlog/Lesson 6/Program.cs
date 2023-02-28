//bool b = true; //false
//if(b)
//{
//    //пукть1
//}
//else
//{
//    //путь2
//}

//-

//int a = 2;
//int b = 3;


//bool c = a<b; //false
//if (c)
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine(false);
//}
//Console.ReadLine(); 

//-


//!!!!Логические операторы && - И , || - или , ! - не .
// a  b  a&&b  a||b  !a
// 1  0   0     1     0
// 0  1   0     1     1
// 1  1   1     1     
// 0  0   0     0     

//-

//int input = int.Parse(Console.ReadLine());
//if (input < 10 && input > 0)
//{

//    Console.WriteLine("Верно");

//}
//else
//{

//    Console.WriteLine("Не верно");

//}
//Console.ReadLine();

//-

//String s = "Привет";
//if (s.Equals("привет", StringComparison.CurrentCultureIgnoreCase))            //if ( s == "привет"),  StringComparison.CurrentCultureIgnoreCase - игнорировать регистр
//{

//    Console.WriteLine("Верно");

//}
//else
//{

//    Console.WriteLine("Не верно");

//}
//Console.ReadLine();

// -

//int input = int.Parse(Console.ReadLine());

//if (input == 1)
//{
//    //Действие1
//}
//else if (input == 2)
//{

//}
//else
//{

//}

////-

//int input = int.Parse(Console.ReadLine());

//switch (input)
//{
//    case 1:
//        //Действие1
//        break;
//    case 2:
//        break;
//    default:
//        break;
//}

////-

//int input = int.Parse(Console.ReadLine());

//Console.WriteLine(input == 10 ? "да" : "нет"); // быстрая проверка



//Задание 1

//int a, b, c;
//Console.WriteLine("Первое число");
//a = int.Parse(Console.ReadLine());
//Console.WriteLine("Второе число");
//b = int.Parse(Console.ReadLine());
//Console.WriteLine("Третье число");
//c = int.Parse(Console.ReadLine());

//if (a >= b && a >= c )
//{
//    Console.WriteLine(a);
//}
//else if (b >= c)
//{
//    Console.WriteLine(b);
//}    
//else
//{
//    Console.WriteLine(c);
//}
//Console.ReadLine();

//Задание 2

//int a;
//Console.WriteLine("Введите число");
//if (!int.TryParse(Console.ReadLine(), out a))
//{
//    Console.WriteLine("Не верный ввод.");
//    Environment.Exit(1);
//}

//a = a % 2;

//switch (a)
//{
//    case 0:
//        Console.WriteLine("Чётное");
//        break;
//    default:
//        Console.WriteLine("Не Чётное");
//        break;
//}
//Console.ReadLine();


//Задание 3

int a;
Console.WriteLine("Введите число");
if (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Не верный ввод.");
    Environment.Exit(1);
}

Console.WriteLine(a % 2 == 0 ? "Чётное" : "Не Чётное");