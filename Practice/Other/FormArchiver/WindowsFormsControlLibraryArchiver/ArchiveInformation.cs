using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsControlLibraryArchiver
{
    [Serializable]
    public class ArchiveInformation
    {
        public DateTime DateTimeStart { get; set; }
        public DateTime DateTimeEnd { get; set; }
        public TimeSpan ArchivingDuration { get; set; }
        public int FilesCount { get; set; }
        public string SizeBeforeArchiving { get; set; }
        public string SizeAfterArchiving { get; set;}
    }
}
