namespace Lesson21._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            var input = Console.ReadLine();

            if (int.TryParse(input, out var result))
            {
                //var isEven = IsEven(result);
                if (result.IsEven())
                {
                    Console.WriteLine($"{result} - четное");
                }
                else
                {
                    Console.WriteLine($"{result} - нечетное");
                }
                int h = 182;
                h.IsDivideBy(7);
                177.IsDivideBy(2);


            }
            else
            {
                Console.WriteLine($"То что ты ввёл - чепуха");
            }
            var roads = new List<Road>();
            for (var i = 0; i < 10; i++)
            {
                var road = new Road();
                road.CreateRandomRoad(1000, 10000);
                roads.Add(road);
            }
            var roadsName = roads.ConvertToString();
            Console.WriteLine(roadsName);

        }

    }
}