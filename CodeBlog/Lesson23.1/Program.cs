namespace Lesson23._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = new
            {
                Name = "Milk",
                Energy = 10
            };
            Console.WriteLine(product);
            Console.WriteLine(product.Energy);

            var eat = new Eat()
            {
                Name = "Meat"
            };
            var product2 = new
            {
                eat.Name,
                Energy = 200

            };
            Console.WriteLine(product2);





            Tuple<int, string> tuple = new Tuple<int, string>(5, "Hi");
            Console.WriteLine(tuple.Item1 + " " + tuple.Item2);

            var tuple2 = (5, "Hi");
            var tuple3 = (Name: "Tomato", Energy: 20);
            tuple3.Energy = 50;
            Console.WriteLine(tuple3.Name);

            var result = GetData();
            Console.WriteLine(result.Name);


        }
        public static (int Number,string Name,bool Flag) GetData()
        {
            var number = 4564; //метода получения данных
            var name = Guid.NewGuid().ToString(); //метода получения данных
            bool b = number > 500; // проверка услови

            return (number, name, b);
        }
    }
}