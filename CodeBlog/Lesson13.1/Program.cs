﻿namespace Lesson13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new LadaSeven());
            cars.Add(new BMWSeven());

            foreach (var car in cars)
            {
                Console.WriteLine(car.Move(200));
            }
            Cyborg cyborg = new Cyborg();
            Console.WriteLine(((ICar)cyborg).Move(100));
            Console.WriteLine(((IPerson)cyborg).Move(100));
        }
    }
}