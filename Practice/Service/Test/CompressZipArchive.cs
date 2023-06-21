using System.IO.Compression;

namespace Test
{
    internal class CompressZipArchive
    {
        public static async Task Compress(string folderPath, string archivePath)
        {
            try
            {
                if (string.IsNullOrEmpty(folderPath)) return;
                
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
