using System;
using System.IO;
using System.IO.Compression;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Text.Json;
using System.Diagnostics;
using System.Xml.Serialization;

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

        interface IArchiver
        {
            Task Compress();
        }








        private async Task Compress()
        {
            while (!Debugger.IsAttached)
            {
                await Task.Delay(1000);
            }
            try
            {
                string folderPath;
                string archivePath;
                string archivingType;
                string cron;
                string programDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string jsonPath = "ArchiverPath\\config.json";
                string path = Path.Combine(programDataPath, jsonPath);


                //Config config = new Config("E:\\test", "E:\\test", "ZipArchive", "*****");
                //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config));
                //using (FileStream fs = new FileStream("C:\\Users\\SlyWatchingFox\\source\\repos\\Education\\Practice\\Service\\WindowsServiceArchiver\\bin\\Debug\\config.xml", FileMode.OpenOrCreate))
                //{
                //    xmlSerializer.Serialize(fs, config);
                //}

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config));
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    Config config = xmlSerializer.Deserialize(fs) as Config;
                    folderPath = config.FolderPath;
                    archivePath = config.ArchivePath + $".zip";
                    archivingType = config.ArchivingType;
                    cron = config.Cron;
                }





                if (string.IsNullOrEmpty(folderPath))
                {
                    return;
                }
                var directory = new DirectoryInfo(folderPath);
                if (directory.Exists)
                {
                    FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
                    using (FileStream zipFile = File.Open(archivePath, FileMode.OpenOrCreate))
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