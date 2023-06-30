using System;
using System.IO.Compression;
using System.IO;
using System.Threading.Tasks;

namespace WindowsServiceArchiver
{
    internal class CompressZipArchive : IArchiver
    {
        public async Task Compress(string folderPath, string archivePath)
        {
            try
            {
                if (string.IsNullOrEmpty(folderPath)) return;
                Service1.Logger.Info("Начало архивации");
                var directory = new DirectoryInfo(folderPath);
                archivePath = archivePath + "\\" + directory.Name + $".zip";
                if (File.Exists(archivePath))
                {
                    Service1.Logger.Info("Архив существует");
                    return;
                }
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
                                var filesPath = fullPath.Substring(folderPath.Length + 1);
                                ZipArchiveEntry fileEntry = await Task.Run(() =>
                                    archive.CreateEntryFromFile(files[i].FullName, filesPath, CompressionLevel.Optimal));
                                Service1.Logger.Trace(files[i].FullName);
                            }
                        }
                    }
                }
                Service1.Logger.Info("Конец архивации");
            }
            catch (Exception ex) { Service1.Logger.Info(ex, "Bitch"); }
        }
    }
}
