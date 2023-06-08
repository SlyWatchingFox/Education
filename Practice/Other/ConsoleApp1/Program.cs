namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.MachineName);
            Console.Beep(327,100);
            Console.WriteLine("{0:x}", 255);
        }
    }
}