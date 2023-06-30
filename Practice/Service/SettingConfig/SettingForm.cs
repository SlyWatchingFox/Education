using NLog;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace SettingConfig
{
    public partial class SettingForm : Form
    {
        private static string ProgramDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        private static string XmlPath = "ArchiverPath\\config.xml";
        private static string ConfigPath = Path.Combine(ProgramDataPath, XmlPath);
        private static XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config));
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public SettingForm()
        {
            InitializeComponent();
            Log();
            Serialize();
            comboBoxArchivingType.Items.Add("ZipArchive");
            comboBoxArchivingType.Items.Add("ZipFile");
        }

        private static void Log()
        {
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "logFile.txt" };
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            NLog.LogManager.Configuration = config;
        }

        private void Serialize()
        {

            if (File.Exists(ConfigPath))
            {
                Logger.Info("Config найден, загрузка" + ConfigPath);
                statusStrip.Text = "Config найден, загрузка" + ConfigPath;
                Config config = null;
                try
                {
                    using (FileStream fs = new FileStream(ConfigPath, FileMode.OpenOrCreate))
                    {
                        config = xmlSerializer.Deserialize(fs) as Config;
                        textBoxFolderPath.Text = config.FolderPath;
                        textBoxArchivePath.Text = config.ArchivePath;
                        textBoxCron.Text = config.Cron;
                        comboBoxArchivingType.Text = config.ArchivingType;
                    }
                }
                catch (Exception ex) { Logger.Info(ex, "Bitch"); }
            }
            else
            {
                Logger.Info("Config не найден, создан новый" + ConfigPath);
                statusStrip.Text = "Config не найден, создан новый" + ConfigPath;
                try
                {
                    Config config = new Config("C:\\test", "C:\\test", "ZipArchive", "* * * * *");
                    using (FileStream fs = new FileStream(ConfigPath, FileMode.OpenOrCreate))
                    {
                        xmlSerializer.Serialize(fs, config);
                    }
                    textBoxFolderPath.Text = config.FolderPath;
                    textBoxArchivePath.Text = config.ArchivePath;
                    textBoxCron.Text = config.Cron;
                    comboBoxArchivingType.Text = config.ArchivingType;
                }
                catch (Exception ex) { Logger.Info(ex, "Bitch"); }
            }
        }
        private void loadConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string LoadPath = dialog.FileName;
                Logger.Info("Загрузка config " + LoadPath);
                statusStrip.Text = "Загрузка config " + LoadPath;
                Config config = null;
                try
                {
                    using (FileStream fs = new FileStream(LoadPath, FileMode.OpenOrCreate))
                    {
                        config = xmlSerializer.Deserialize(fs) as Config;
                        if (config != null)
                        {
                            config.ArchivePath = config.ArchivePath;
                        }
                    }
                    textBoxFolderPath.Text = config.FolderPath;
                    textBoxArchivePath.Text = config.ArchivePath;
                    textBoxCron.Text = config.Cron;
                    comboBoxArchivingType.Text = config.ArchivingType;
                }
                catch (Exception ex) { Logger.Info(ex, "Bitch"); }
            }
        }
        private async void saveConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxArchivingType.Text != null && textBoxFolderPath.Text != null && textBoxArchivePath.Text != null)
            {
                Logger.Info("Сохранение config");
                statusStrip.Text = "Сохранение config";
                try
                {
                    if (File.Exists(ConfigPath)) { File.Delete(ConfigPath); }
                    Config config = new Config(textBoxFolderPath.Text, textBoxArchivePath.Text,
                                                     comboBoxArchivingType.Text, textBoxCron.Text);
                    using (FileStream fs = new FileStream(ConfigPath, FileMode.OpenOrCreate))
                    {
                        xmlSerializer.Serialize(fs, config);
                    }
                }
                catch (Exception ex) { Logger.Info(ex, "Bitch"); }
            }
        }
        private void btnFolderPath_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxFolderPath.Text = fbd.SelectedPath;
            }
        }
        private void btnArchivePath_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxArchivePath.Text = fbd.SelectedPath;
            }
        }

        private void textBoxCron_TextChanged(object sender, EventArgs e)
        {
            string regexPattern = @"^(\*|[1-5]?\d)\s(\*|[1]?\d|[2][0-3])\s(\*|[3][0-1]|[1-2]\d|[1-9])\s(\*|[1][0-2]|[1-9])\s([*0-6])$";
            bool isMatch = Regex.IsMatch(textBoxCron.Text, regexPattern, RegexOptions.IgnoreCase);
            saveConfigToolStripMenuItem.Enabled = isMatch;
        }
    }
}