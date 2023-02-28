//for (итератор; условие; изменение)
//{

//}
//for(int i = 1; i <= 0; i += 10)

//for(int j = 0;j < 10; j++) 

//for(; ;) //бесконечный цикл

//int k = 10;
//for (; k = 10; k++)

//for (int i = 0; ; i++)
//{
//    if (i < 5)
//    {
//        break;
//    }
//}


//var list = new List<int>();
//for (var i = 0; i < 10; i += 2)
//{
//    list.Add(i);
//}
//for(var i = 0;i< list.Count;i++)
//{
//    Console.WriteLine(list[i]); 
//}
//Console.ReadLine();

//while(условие)
//{

//}    


//var list = new List<string>();
//while(list.Count < 5)
//{
//    list.Add(Console.ReadLine());
//}

//var i = 0;
//while(i < list.Count)
//{
//    Console.WriteLine(list[i]);
//    i++;
//}
//Console.ReadLine();


//var list = new List<string>();
//while (list.Count < 5)
//{
//    list.Add(Console.ReadLine());
//}


//var i = 0;
//do
//{

//}
//while (i < list.Count) ;

//Console.ReadLine();

//var list = new List<string>();
//foreach (элемент in коллекция)
//{

//}


//var list = new List<string>();


//var rnd = new Random();
//for (var i = 0; i < 10; i++)
//{

//    list.Add(rnd.Next(0, 100).ToString());
//    continue; //закончить круг,продолжить цикл в циклс нового круга, 
//    list.Add(rnd.Next(0, 100).ToString());
//    break; //закончить цикл
//}


//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}


//Console.ReadLine();

//int[,] array = new int[10, 10];
//for (var i = 0; i < 10; i++)
//{
//    for (var j = 0; j < 10; j++)
//    {
//        array[i, j] = 8;
//    }
//}


//Задание:

var list = new List<int>();
int num;
while (list.Count < 10)
{
    Console.WriteLine("Введите число");
    if (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Не верный ввод.Введите следующее число");
    }
    list.Add(num);
}

foreach (var item in list)
{
    Console.WriteLine(item);
}

int sum = 0;
for (var isum = 0; isum < list.Count; sum += list[isum], isum++)
{

}

Console.WriteLine($"Сумма: {sum}");

int raz = 0;
int iraz = 0;
while (iraz < list.Count)
{
    raz = raz - list[iraz];
    iraz++;
}
Console.WriteLine($"Разность: {raz}");


int pro = 1;
int ipro = 0;
do
{
    pro *= list[ipro];
    ipro++;
}
while (ipro < list.Count);
Console.WriteLine("Произведение: " + pro);