using System;
using System.Security.Cryptography.X509Certificates;

namespace Lesson15._2
{
    internal class Program
    {
        public delegate int ValueDelegate(int i);

        public delegate void MyDelegate();  // ==\/
        public event MyDelegate Event;      // == public event Action Event;

        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Вася"
            };
            person.GoToSleep += Person_GoToSleep;
            person.DoWork += Person_DoWork;
            person.TakeTime(DateTime.Parse("27.12.2018 21:13:00"));
            person.TakeTime(DateTime.Parse("27.12.2018 4:13:00"));

        }

        private static void Person_DoWork(object? sender, EventArgs e)
        {
            if (sender is Person)
            {
                Console.WriteLine($"{((Person)sender).Name} работает работу");
            }
        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("Spat' syka");
        }
    }
}