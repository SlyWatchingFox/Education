namespace TaskForCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                context.Database.Create();
                Console.WriteLine($"bI");
            }
        }

    }
}