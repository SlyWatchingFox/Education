using NLog;
using System.Xml.Serialization;

namespace Test
{
    interface IArchiver
    {
        Task Compress(string folderPath, string archivePath);
    }
    internal class Program
    {
        private static Config? _config;
        private static IArchiver? archiver;
        public static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private static double timerInterval = 1000;
        private static System.Timers.Timer timer = new System.Timers.Timer(timerInterval);
        static async Task Main(string[] args)
        {
            Console.WriteLine(timerInterval);
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "logFile.txt" };
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            NLog.LogManager.Configuration = config;
            string programDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string jsonPath = "ArchiverPath\\config.xml";
            string configPath = Path.Combine(programDataPath, jsonPath);
            _config = Serialize(configPath);
            archiver = ArchiverFactory.GetArchiver(_config.ArchivingType);
            timer.Elapsed += CheckForCron;
            timer.AutoReset = true;
            timer.Start();
            Console.ReadLine();
        }
        private static async void CheckForCron(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if (_config is null || archiver is null) return;
            string[] crons = _config.Cron.Split(new char[] { ' ' });
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.Month.ToString());
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
            await archiver.Compress(_config.FolderPath, _config.ArchivePath);
            if (cronMinute == dateTime.Minute.ToString()) timerInterval = 1000 * 60; timer.Interval = timerInterval;
            if (cronHour == dateTime.Hour.ToString()) timerInterval = 1000 * 60 * 60; timer.Interval = timerInterval;
            if (cronDay == dateTime.Day.ToString()) timerInterval = 1000 * 60 * 60 * 24; timer.Interval = timerInterval;
            if (cronDayOfWeek == dateTime.DayOfWeek.ToString()) timerInterval = 1000 * 60 * 60 * 24; timer.Interval = timerInterval;
            if (cronMonth == dateTime.Month.ToString()) timerInterval = 1000d * 60d * 60d * 24d * 30d; timer.Interval = timerInterval;
        }
        private static Config? Serialize(string configPath)
        {
            Logger.Info("загрузка config " + configPath);
            Config? config = null;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config));
                using (FileStream fs = new FileStream(configPath, FileMode.OpenOrCreate))
                {
                    config = xmlSerializer.Deserialize(fs) as Config;
                    if (config != null)
                    {
                        config.ArchivePath = config.ArchivePath + $".zip";
                    }
                }
                Logger.Info("сonfig загружен");
                Logger.Info("Folder Path - " + config.FolderPath);
                Logger.Info("Archive Path - " + config.ArchivePath);
                Logger.Info("Archiving Type - " + config.ArchivingType);
                Logger.Info("cron - " + config.Cron);
            }
            catch (Exception ex) { Program.Logger.Info(ex, "Bitch"); }
            return config;
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