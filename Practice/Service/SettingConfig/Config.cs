using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingConfig
{
    public class Config
    {
        public string FolderPath { get; set; }
        public string ArchivePath { get; set; }
        public string ArchivingType { get; set; }
        public string Cron { get; set; }
        public Config() { }
        public Config(string folderPath, string archivePath, string archivingType, string cron)
        {
            FolderPath = folderPath;
            ArchivePath = archivePath;
            ArchivingType = archivingType;
            Cron = cron;
        }
    }
}
