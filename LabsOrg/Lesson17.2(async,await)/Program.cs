using System.Text;

namespace Lesson17._2_async_await_
{
    internal class Program
    {
        public static object locker = new object();
        static void Main(string[] args)
        {
            #region async 
            //Console.WriteLine("Begin main");
            //DoWorkAsync();
            //DoWorkAsync2();
            //Console.WriteLine("Continue main");
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("Main");
            //}
            //Console.WriteLine("End main");
            #endregion

            var result = SaveFileAsync("E:\\test.txt");
            var input = Console.ReadLine();
            Console.WriteLine(result.Result);

        }

        static async Task<bool> SaveFileAsync(string path)
        {
            var result = await Task.Run(() => SaveFile(path));
            return result;
        }
        static bool SaveFile(string path)

        {
            lock (locker)
            {
                var rnd = new Random();
                var text = "";
                for (int i = 0; i < 20000; i++)
                {
                    text += rnd.Next();
                }
            }
            using (var sw = new StreamWriter(path, true, Encoding.UTF8))
            {
                sw.WriteLine();
            }
            return true;
        }




        static async Task DoWorkAsync() //Task<T> Task<int>
        {
            Console.WriteLine("Begin Async");
            await Task.Run(() => DoWork());
            Console.WriteLine("End Async");
        }
        static async Task DoWorkAsync2() //Task<T> Task<int>
        {
            Console.WriteLine("Begin Async");
            await Task.Run(() => DoWork2());
            Console.WriteLine("End Async");
        }



        static void DoWork()
        {
            int j = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("DoWark");
            }
        }
        static void DoWork2()
        {
            int j = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("DoWark2");
            }
        }
    }
}
