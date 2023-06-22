using NLog;
using System.IO.Compression;

namespace Test
{
    internal class CompressZipFile : IArchiver
    {
        public async Task Compress(string folderPath, string archivePath)
        {
            try
            {
                Program.Logger.Info("Начало архивации");
                await Task.Run(() => ZipFile.CreateFromDirectory(folderPath, archivePath));
                Program.Logger.Info("Конец архивации");
            }
            catch (Exception ex) { Program.Logger.Info(ex, "Bitch"); }
        }
    }
}
