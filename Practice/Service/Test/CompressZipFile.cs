using System.IO.Compression;

namespace Test
{
    internal class CompressZipFile
    {
        public static void Compress(string folderPath, string archivePath)
        {
            ZipFile.CreateFromDirectory(folderPath, archivePath);
        }
    }
}
