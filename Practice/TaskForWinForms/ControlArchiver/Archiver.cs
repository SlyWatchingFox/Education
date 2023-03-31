using System;
using System.IO.Compression;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace ControlArchiver
{
    public class Archiver
    {
        public delegate void ArchiveHandler(int pBarValue, string filesPath);
        public event ArchiveHandler FileCompressed;


        public async Task Compress(string folderPath, FileInfo[] files, CancellationToken ct)
        {
            var pBarValue = 0;
            long sizeFiles = 0;
            string zipPath = folderPath + $".zip";
            DateTime dateTimeStart = DateTime.Now;
            using (FileStream zipFile = File.Open(zipPath, FileMode.OpenOrCreate))
            {
                using (ZipArchive archive = new ZipArchive(zipFile, ZipArchiveMode.Update))
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        if (ct.IsCancellationRequested) return;
                        var fullPath = files[i].FullName;
                        var filesPath = fullPath.Substring(folderPath.Length);
                        ZipArchiveEntry fileEntry = await Task.Run(() =>
                            archive.CreateEntryFromFile(files[i].FullName, filesPath, CompressionLevel.Optimal));
                        pBarValue++;
                        FileCompressed?.Invoke(pBarValue, filesPath);
                        sizeFiles += files[i].Length;
                    }
                }
            }
            DateTime dateTimeEnd = DateTime.Now;
            ArchiveInformation archiveInformation = new ArchiveInformation()
            {
                DateTimeStart = dateTimeStart.ToString(),
                DateTimeEnd = dateTimeEnd.ToString(),
                ArchivingDuration = (dateTimeEnd - dateTimeStart).ToString(),
                FilesCount = files.Length,
                SizeBeforeArchiving = SizeConver(sizeFiles),
                SizeAfterArchiving = SizeConver(zipPath)
            };

            string archiveInformationPath = folderPath + $"ArchiveInformation.json";
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<ArchiveInformation>));
            using (var file = new FileStream(archiveInformationPath, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(file, archiveInformation);
            }
        }
        public static string SizeConver(long sizeFiles)
        {
            string[] sizeletters = new string[] { "bytes", "KB", "MB", "GB", "TB" };
            for (int i = 0; i < 5; i++)
            {
                if (sizeFiles < 1024)
                {
                    string fileSize = sizeFiles.ToString() + sizeletters[i];
                    return fileSize;
                }
                sizeFiles /= 1024;
            }
            return "";
        }
        public static string SizeConver(string zipPath)
        {
            if (File.Exists(zipPath))
            {
                FileInfo info = new FileInfo(zipPath);
                long size = info.Length;
                string[] sizeletters = new string[] { "bytes", "KB", "MB", "GB", "TB" };
                for (int i = 0; i < 5; i++)
                {
                    if (size < 1024)
                    {
                        string fileSize = size.ToString() + sizeletters[i];
                        return fileSize;
                    }
                    size /= 1024;
                }
            }
            return "";
        }
    }
}
