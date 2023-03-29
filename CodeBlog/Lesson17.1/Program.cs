namespace Lesson17._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(DoWork));
            thread.Start();
            Thread thread2 = new Thread(new ParameterizedThreadStart(DoWork2));
            thread2.Start(int.MaxValue);
            int j = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                j++;
                if (j % 10000 == 0)
                {
                    Console.WriteLine("Main");
                }
            }
        }

        static void DoWork()
        {
            int j = 0;
            for (int i = 0; i<int.MaxValue; i++)
            {
                j++;
                if (j % 10000 == 0)
                {
                    Console.WriteLine("DoWark");
                }
            }
        }
        static void DoWork2(object max)

        {
            int j = 0;
            for (int i = 0; i < (int)max; i++)
            {
                j++;
                if (j % 10000 == 0)
                {
                    Console.WriteLine("DoWark2");
                }
            }
        }
    }
}