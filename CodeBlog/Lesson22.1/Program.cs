namespace Lesson22._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car() {Name="Ford", Number="A001AA01"},
                new Car() {Name="Lada", Number="A771AB72"}
            };


            var parking = new Parking();
            foreach (var car in cars)
            {
                parking.Add(car);
            }


            foreach (var car in parking)
            {
                Console.WriteLine(car);
            }

            var i = parking.GetEnumerator();


            foreach (var item in parking)
            {
                Console.WriteLine(item + " ");
            }


            foreach (var name in parking.GetNames())
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(parking["A001AA01"]?.Name);
            Console.WriteLine(parking["A001AA02"]?.Name);

            Console.WriteLine("Введите номер новой машины");
            var num = Console.ReadLine();
            parking[1] = new Car()
            {
                Name = "BMW",
                Number = num

            };
            Console.WriteLine(parking[1]);
            Console.ReadLine();
        }

    }
}