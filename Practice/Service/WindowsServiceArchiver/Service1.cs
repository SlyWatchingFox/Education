using System;
using System.IO;
using System.IO.Compression;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Text.Json;

namespace WindowsServiceArchiver
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override async void OnStart(string[] args)
        {
            await Compress();
        }

        private async Task Compress()
        {
            try
            {
                string folderPath;
                string programDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string jsonPath = "ArchiverPath\\config.json";
                string path = Path.Combine(programDataPath, jsonPath);


                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    Config config = await JsonSerializer.DeserializeAsync<Config>(fs);
                    folderPath = config.Path;
                }

                //path = "C:\\Users\\SlyWatchingFox\\source\\repos\\Education\\Practice\\Service\\Test\\bin\\Debug\\net6.0\\path.txt";
                //using (StreamReader reader = new StreamReader(path))
                //{
                //    folderPath = await reader.ReadLineAsync();
                //}


                if (string.IsNullOrEmpty(folderPath))
                {
                    return;
                }
                var directory = new DirectoryInfo(folderPath);
                if (directory.Exists)
                {
                    FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
                    string zipPath = folderPath + $".zip";
                    using (FileStream zipFile = File.Open(zipPath, FileMode.OpenOrCreate))
                    {
                        using (ZipArchive archive = new ZipArchive(zipFile, ZipArchiveMode.Update))
                        {
                            for (int i = 0; i < files.Length; i++)
                            {
                                var fullPath = files[i].FullName;
                                var filesPath = fullPath.Substring(folderPath.Length);
                                ZipArchiveEntry fileEntry = await Task.Run(() =>
                                    archive.CreateEntryFromFile(files[i].FullName, filesPath, CompressionLevel.Optimal));

                            }
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }
    }
}

