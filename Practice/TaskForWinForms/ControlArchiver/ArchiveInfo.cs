
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
        public ArchiveInfo
            (
            string dateTimeStart,
            string dateTimeEnd,
            string archivingDuration,
            int filesCount, 
            string sizeBeforeArchiving, 
            string sizeAfterArchiving
            )
        {
            DateTimeStart = dateTimeStart;
            DateTimeEnd = dateTimeEnd;
            ArchivingDuration = archivingDuration;
            FilesCount = filesCount;
            SizeBeforeArchiving = sizeBeforeArchiving;
            SizeAfterArchiving = sizeAfterArchiving;
        }
    }
}
