namespace Lesson10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(15));
            Console.ReadLine();

        }

        public static int Factorial(int value1)
        {
            if (value1 <= 1)
            {
                return 1;
            }
            else
            {
                return value1 * Factorial(value1 - 1);
            }
        }
    }
}