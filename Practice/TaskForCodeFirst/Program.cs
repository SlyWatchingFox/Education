namespace TaskForCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                var Mechanic1 = new Mechanic()
                {
                    LastName = "Пупкин",
                    FirstName = "Вася"
                };
                context.Mechanics.Add(Mechanic1);
                context.SaveChanges();

                Console.WriteLine($"bI");
            }
        }

    }
}