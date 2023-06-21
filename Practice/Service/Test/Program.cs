using System.Xml.Serialization;

namespace Test
{

    internal class Program
    {
        static async Task Main(string[] args)
        {
            string folderPath;
            string archivePath;
            string archivingType;
            string cron;
            string programDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string jsonPath = "ArchiverPath\\config.xml";
            string path = Path.Combine(programDataPath, jsonPath);
            Serialize(out folderPath, out archivePath, out archivingType, out cron, path);

            System.Timers.Timer timer = new System.Timers.Timer(1000);

            CheckForCron(cron, folderPath, archivePath);


        }

        private static async void CheckForCron(string cron, string folderPath, string archivePath)
        {
            string[] crons = cron.Split(new char[] { ' ' });
            DateTime dateTime = DateTime.Now;
            string cronMinute = crons[0];
            string cronHour = crons[1];
            string cronDay = crons[2];
            string cronMonth = crons[3];
            string cronDayOfWeek = crons[4];
            if (cronMinute != "*" && cronMinute != dateTime.Minute.ToString()) return;
            if (cronHour != "*" && cronHour != dateTime.Hour.ToString()) return;
            if (cronDay != "*" && cronDay != dateTime.Day.ToString()) return;
            if (cronMonth != "*" && cronMonth != dateTime.Month.ToString()) return;
            if (cronDayOfWeek != "*" && cronDayOfWeek == dateTime.DayOfWeek.ToString()) return;


            await CompressZipArchive.Compress(folderPath, archivePath);
            //CompressZipFile.Compress(folderPath, archivePath);
        }






        //interface IArchiver
        //{
        //    Task Compress();
        //}






        private static void Serialize(out string folderPath, out string archivePath, out string archivingType, out string cron, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Config? config = xmlSerializer.Deserialize(fs) as Config;
                folderPath = config.FolderPath;
                archivePath = config.ArchivePath + $".zip";
                archivingType = config.ArchivingType;
                cron = config.Cron;
            }
        }











    }
}



//path = "C:\\Users\\SlyWatchingFox\\source\\repos\\Education\\Practice\\Service\\Test\\bin\\Debug\\net6.0\\path.txt";
//using (StreamReader reader = new StreamReader(path))
//{
//    folderPath = await reader.ReadLineAsync();
//}

//using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
//{
//    Config? config = await JsonSerializer.DeserializeAsync<Config>(fs);
//    folderPath = config.Path;
//    Console.WriteLine(folderPath);
//}

//Config config = new Config("E:\\test", "E:\\test", "ZipArchive", "*****");
//XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config));
//using (FileStream fs = new FileStream("config.xml", FileMode.OpenOrCreate))
//{
//    xmlSerializer.Serialize(fs, config);
//    Console.WriteLine("Data has been saved to file");
//}



//using (FileStream fs = new FileStream("config.json", FileMode.OpenOrCreate))
//{
//    Config tom = new Config("E:\\test");
//    await JsonSerializer.SerializeAsync<Config>(fs, tom);
//    Console.WriteLine("Data has been saved to file");
//}