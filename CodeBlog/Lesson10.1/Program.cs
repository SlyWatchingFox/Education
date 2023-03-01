using System.Reflection.Metadata.Ecma335;

namespace Lesson10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Иванов", "Иван");
            var person2 = new Person("Петров", "Пётр");
            for(var i = 0; i < 10;i++)
            {
                var position1 = person1.Run();
                Console.WriteLine(position1);

                Console.WriteLine(person2.Run(1, 2));
            }

            Console.WriteLine();
            Console.ReadLine();
        }


        //        public static int PrintHello(string name, int age)
        //        {
        //            Console.WriteLine($"Привет, {name}. Вам {age} лет.");
        //            return 2;
        //        }
    }

}
