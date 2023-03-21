namespace Lesson20._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var collection = new List<int>();
            //for (var i = 0; i < 10; i++)
            //{
            //    collection.Add(i);

            //}
            //var result = from item in collection
            //             where item < 5
            //             select item;
            //var result2 = collection.Where(item => item < 5);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            var rnd = new Random();
            var products = new List<Product>();
            for (var i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Продукт" + i,
                    Energy = rnd.Next(10, 12)
                };

                products.Add(product);

            }
            var result = from item in products
                         where item.Energy < 200
                         select item;
            var result2 = products.Where(item => item.Energy < 100);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();





            var selectcollection = products.Select(product => product.Energy);





            var orderbyCollection = products.OrderBy(product => product.Energy)
                                            .ThenByDescending(product => product.Name);
            foreach (var item in orderbyCollection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();





            var groupbyCollection = products.GroupBy(product => product.Energy);
            foreach (var group in groupbyCollection)
            {
                Console.WriteLine($"Ключ: {group.Key}");
                Console.WriteLine();
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
            }




            products.Reverse();
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            Console.WriteLine(products.All(item => item.Energy == 10));
            Console.WriteLine(products.Any(item => item.Energy == 10));


            Console.WriteLine(products.Contains(products[5]));

            var array = new int[] { 1, 2, 3, 4 };
            var array2 = new int[] { 3, 4, 5, 6 };
            var union = array.Union(array2);
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var intersect = array.Intersect(array2);
            foreach (var item in intersect)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var excep = array.Except(array2);
            foreach (var item in excep)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var sum = array.Sum();
            var min = products.Min(p => p.Energy);
            var max = products.Max(p => p.Energy);

            var aggregate = array.Aggregate((x, y) => x + y);
            Console.WriteLine(aggregate);

            var sum2 = array.Skip(1).Take(2).Sum(); // skip - сколько пропустить, take - сколько подряд 
            Console.WriteLine();


            var first = array.FirstOrDefault();
            var last = array.LastOrDefault();
            var single = array.Single(a => a == 5); // элемент должен быть только один иначе ошибка
            var elementAt = array.ElementAt(5);  // по индексу


        }
    }
}