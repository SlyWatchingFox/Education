using Microsoft.VisualBasic;

namespace Lesson19._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {

                var group1 = new Group()
                {
                    Name = "Ramstein",
                    Year = 1994
                };
                var group2 = new Group()
                {
                    Name = "Linkin Park",
                    Year = 1990
                };
                context.Groups.Add(group1);
                context.Groups.Add(group2);
                context.SaveChanges();

                Console.WriteLine($"{group1.Name}" );
            }
        }
    }
}