using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlArchiver
{
    public class ArchiveInfo
    {
        public string DateTimeStart { get; set; }
        public string DateTimeEnd { get; set; }
        public string ArchivingDuration { get; set; }
        public int FilesCount { get; set; }
        public string SizeBeforeArchiving { get; set; }
        public string SizeAfterArchiving { get; set; }

    }
}
