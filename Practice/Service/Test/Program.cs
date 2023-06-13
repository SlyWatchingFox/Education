using System.IO.Compression;
using System.Text.Json;

namespace Test
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //using (FileStream fs = new FileStream("config.json", FileMode.OpenOrCreate))
            //{
            //    Config tom = new Config("E:\\test");
            //    await JsonSerializer.SerializeAsync<Config>(fs, tom);
            //    Console.WriteLine("Data has been saved to file");
            //}
            string programDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string jsonPath = "ArchiverPath\\config.json";
            string path = Path.Combine(programDataPath, jsonPath);

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Config? config = await JsonSerializer.DeserializeAsync<Config>(fs);
                string folderPath = config.Path;
                Console.WriteLine(folderPath);
            }
        }
        class Config
        {
            public string Path { get; set; }
            public Config(string path)
            {
                Path = path;
            }
        }
    }
}