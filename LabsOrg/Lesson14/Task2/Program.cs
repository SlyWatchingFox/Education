using System.Diagnostics;
using System.IO;
using System.Text;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\SlyWatchingFox\source\repos\Education\LabsOrg\Lesson14\Task2\bin\Debug\Task02.dat";
            //string path = @"C:\Users\SlyWatchingFox\source\repos\Education\LabsOrg\Lesson14\Task2\bin\Debug\Task022.dat";
            PrintData(path);
            var count = CountLessThanLeft(path);
            Console.WriteLine();
            Console.WriteLine($"Количество чисел, меньших, чем их левый сосед: {count}");
            Console.WriteLine();
        }
        static void PrintData(string path)
        {
            try
            {
                using (var fs = new FileStream(path, FileMode.Open))

                {
                    try
                    {
                        var br = new BinaryReader(fs, Encoding.ASCII);
                        if (br.PeekChar() == -1) Console.WriteLine("Пустой файл");
                        while (br.PeekChar() != -1)
                        {
                            var x = br.ReadInt32();
                            Console.Write($"{x} ");
                        }
                        //Console.WriteLine();
                        //Console.WriteLine(br.ReadInt32());
                    }
                    catch (IOException e) { Console.WriteLine($"Ошибка обработки файла: {e.Message}"); }
                }
            }
            catch (IOException e) { Console.WriteLine($"Ошибка чтения из файла: {e.Message}"); }
        }
        static int CountLessThanLeft(string path)
        { 
            var count = 0;
            int y = int.MaxValue;
            try
            {
                using (var fs = new FileStream(path, FileMode.Open))

                {
                    try
                    {
                        var br = new BinaryReader(fs, Encoding.ASCII);
                        if (br.PeekChar() == -1) Console.WriteLine("Пустой файл");
                        while (br.PeekChar() != -1)
                        {
                            var x = br.ReadInt32();
                           
                            if (x<y)
                            {
                                y=x; count++;
                            }
                        }
                    }
                    catch (IOException e) { Console.WriteLine($"Ошибка обработки файла: {e.Message}"); }
                }
            }
            catch (IOException e) { Console.WriteLine($"Ошибка чтения из файла: {e.Message}"); }
            return count; 
        }
    }
}
