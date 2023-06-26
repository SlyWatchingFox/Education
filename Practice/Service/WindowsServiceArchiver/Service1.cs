using System;
using System.IO;
using System.ServiceProcess;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NLog;

namespace WindowsServiceArchiver
{
    interface IArchiver
    {
        Task Compress(string folderPath, string archivePath);
    }
    public partial class Service1 : ServiceBase
    {
        private Config _config;
        private IArchiver _archiver;
        public static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private double _timerInterval = 1000;
        private System.Timers.Timer _timer;
        public Service1()
        {
            InitializeComponent();
        }

        protected override async void OnStart(string[] args)
        {
            _timer = new System.Timers.Timer(_timerInterval);
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "logFile.txt" };
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            NLog.LogManager.Configuration = config;
            string programDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string jsonPath = "ArchiverPath\\config.xml";
            string configPath = Path.Combine(programDataPath, jsonPath);
            _config = Serialize(configPath);
            _archiver = ArchiverFactory.GetArchiver(_config.ArchivingType);
            _timer.Elapsed += CheckForCron;
            _timer.AutoReset = false;
            _timer.Start();
        }
        private async void CheckForCron(object sender, System.Timers.ElapsedEventArgs e)
        {
            string regexPattern = @"^[*,0,1,2,3,4,5,6,7,8,9]\d*\s[*,0,1,2,3,4,5,6,7,8,9]\d*\s[*,0,1,2,3,4,5,6,7,8,9]\d*\s" +
                                 @"[*,0,1,2,3,4,5,6,7,8,9]\d*\s[*,0,1,2,3,4,5,6]";
            if (!Regex.IsMatch(_config.Cron, regexPattern, RegexOptions.IgnoreCase)) { Logger.Info("Fucking cron"); Environment.Exit(1); }
            if (_config is null || _archiver is null) return;
            string[] crons = _config.Cron.Split(new char[] { ' ' });
            DateTime dateTime = DateTime.Now;
            string cronMinute = crons[0];
            string cronHour = crons[1];
            string cronDay = crons[2];
            string cronMonth = crons[3];
            string cronDayOfWeek = crons[4];
            if (cronMinute != "*" && cronMinute != dateTime.Minute.ToString()) { _timer.Start(); return; }
            if (cronHour != "*" && cronHour != dateTime.Hour.ToString()) { _timer.Start(); return; }
            if (cronDay != "*" && cronDay != dateTime.Day.ToString()) { _timer.Start(); return; }
            if (cronMonth != "*" && cronMonth != dateTime.Month.ToString()) { _timer.Start(); return; }
            if (cronDayOfWeek != "*" && cronDayOfWeek == dateTime.DayOfWeek.ToString()) { _timer.Start(); return; }
            await _archiver.Compress(_config.FolderPath, _config.ArchivePath);
            _timerInterval = 1000;
            if (cronMinute == dateTime.Minute.ToString()) _timerInterval = 1000 * 60;
            if (cronHour == dateTime.Hour.ToString()) _timerInterval = 1000 * 60 * 60;
            if (cronDay == dateTime.Day.ToString()) _timerInterval = 1000 * 60 * 60 * 24; ;
            if (cronDayOfWeek == dateTime.DayOfWeek.ToString()) _timerInterval = 1000 * 60 * 60 * 24;
            if (cronMonth == dateTime.Month.ToString()) _timerInterval = 1000d * 60d * 60d * 24d * 30d;
            _timer.Interval = _timerInterval;
            _timer.Start();
        }
        private static Config Serialize(string configPath)
        {
            Logger.Info("Загрузка config " + configPath);
            Config config = null;
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
                Logger.Info("Config загружен");
                Logger.Info("Folder Path - " + config.FolderPath);
                Logger.Info("Archive Path - " + config.ArchivePath);
                Logger.Info("Archiving Type - " + config.ArchivingType);
                Logger.Info("cron - " + config.Cron);
            }
            catch (Exception ex) { Service1.Logger.Info(ex, "Bitch"); }
            return config;
        }










    }
}