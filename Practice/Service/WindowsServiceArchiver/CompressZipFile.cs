using System;
using System.IO.Compression;
using System.Threading.Tasks;

namespace WindowsServiceArchiver
{
    internal class CompressZipFile : IArchiver
    {
        public async Task Compress(string folderPath, string archivePath)
        {
            try
            {
                Service1.Logger.Info("Начало архивации");
                await Task.Run(() => ZipFile.CreateFromDirectory(folderPath, archivePath));
                Service1.Logger.Info("Конец архивации");
            }
            catch (Exception ex) { Service1.Logger.Info(ex, "Bitch"); }
        }
    }
}
