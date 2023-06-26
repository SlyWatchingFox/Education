namespace WindowsServiceArchiver
{
    internal static class ArchiverFactory
    {
        public static IArchiver GetArchiver(string archiverType)
        {
            switch (archiverType)
            {
                case "ZipArchive": return new CompressZipArchive();
                case "ZipFile": return new CompressZipFile();
                default: return null;
            }
        }
    }
}
