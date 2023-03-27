using System.IO.Compression;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourceFolder = "E://test/"; // исходная папка
            string zipFile = "E://test1.zip"; // сжатый файл
            string targetFolder = "E://newtest"; // папка, куда распаковывается файл

            ZipFile.CreateFromDirectory(sourceFolder, zipFile);
            Console.WriteLine($"Папка {sourceFolder} архивирована в файл {zipFile}");
            
        }
    }
}