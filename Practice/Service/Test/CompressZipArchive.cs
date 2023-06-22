using NLog;
using System.IO.Compression;

namespace Test
{
    internal class CompressZipArchive : IArchiver
    {
        public async Task Compress(string folderPath, string archivePath)
        {
            try
            {
                if (string.IsNullOrEmpty(folderPath)) return;
                if (File.Exists(archivePath))
                {
                    Program.Logger.Info("Архив существует");
                    return;
                }
                Program.Logger.Info("Начало архивации");
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
                                var filesPath = fullPath.Substring(folderPath.Length + 1);
                                ZipArchiveEntry fileEntry = await Task.Run(() =>
                                    archive.CreateEntryFromFile(files[i].FullName, filesPath, CompressionLevel.Optimal));
                                Program.Logger.Trace(files[i].FullName);
                            }
                        }
                    }
                }
                Program.Logger.Info("Конец архивации");
            }
            catch (Exception ex) { Program.Logger.Info(ex, "Bitch"); }
        }
    }
}
