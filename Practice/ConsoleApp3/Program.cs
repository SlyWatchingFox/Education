using System.Drawing;
using System.IO.Compression;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTimeStart = DateTime.Now;
            
            Task.Delay(10000);
            TimeSpan interval = dateTimeStart - DateTime.Now;
            Console.WriteLine(interval);
            string filePath = $"E:\\test";
            
            Console.WriteLine("Size: " + sizeConver(filePath));

        }
        public static string sizeConver(string filePath)
        {
            if (File.Exists(filePath))
            {
                FileInfo info = new FileInfo(filePath);
                long size = info.Length;
                string[] sizeletters = new string[] { "bytes", "KB", "MB", "GB", "TB" };
                for (int i = 0; i < 5; i++)
                {
                    if (size < 1024)
                    {
                        string fileSize = size.ToString() + sizeletters[i];
                        return fileSize;
                    }
                    size /= 1024;
                }
            }
            return "";
        }
        
    }
}