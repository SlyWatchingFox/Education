//using System;
//using System.Windows.Forms;
//using System.IO.Compression;
//using System.IO;
//using System.Text;
//using System.Collections.Generic;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using WindowsFormsControlLibraryArchiver;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace WindowsFormsControlLibraryArchiver
//{
//    public partial class UserControlArchiver : UserControl
//    {
//        public UserControlArchiver()
//        {
//            InitializeComponent();
//        }
//        private void btnFolder_Click(object sender, EventArgs e)
//        {
//            if (fbd.ShowDialog() == DialogResult.OK)
//            {
//                textBoxFolder.Text = fbd.SelectedPath;
//                //foreach (var item in Directory.GetFiles(fbd.SelectedPath, "*", SearchOption.AllDirectories))
//                //{
//                //    listSelectedFiles.Items.Add(item);
//                //}
//            }
//        }

//        private void btnArchive_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(textBoxFolder.Text))
//            {
//                MessageBox.Show("Пожалуйста укажите путь для папки с файлами.", "Сообщение", MessageBoxButtons.OK);
//                return;
//            }
//            string pathFolder = textBoxFolder.Text;
//            string pathZip = textBoxFolder.Text + ".zip";

//            int list = listSelectedFiles.Items.Count;
//            progresBar.Maximum = list;
//            for (int i = 0; i < list; i++)
//            {

//                progresBar.Value = progresBar.Value + 1;
//            }
//            ZipFile.CreateFromDirectory(pathFolder, pathZip);
//            MessageBox.Show($"Папка {pathFolder} архивирована в файл {pathZip}");
//        }

//        private void timer1_Tick(object sender, EventArgs e)
//        {
//            progresBar.Value = progresBar.Value + 1;
//        }

//        private void btnArchive1_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(textBoxFolder.Text))
//            {
//                MessageBox.Show("Пожалуйста укажите путь для папки с файлами.", "Сообщение", MessageBoxButtons.OK);
//                return;
//            }
//            ArchiverAsync();
//            ListSelected();
//            ProgresBarWork();
//        }


//        public void ListSelected()
//        {
//            listSelectedFiles.Items.Clear();
//            var directory = new DirectoryInfo(textBoxFolder.Text);
//            if (directory.Exists)
//            {
//                string zipPath = textBoxFolder.Text + $".zip";
//                FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
//                for (int i = 0; i < files.Length; i++)
//                {
//                    listSelectedFiles.Items.Add(files[i].FullName);
//                }
//            }
//        }
//        public void ProgresBarWork()
//        {
//            var directory = new DirectoryInfo(textBoxFolder.Text);
//            if (directory.Exists)
//            {
//                FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
//                progresBar.Maximum = files.Length;
//                progresBar.Value = 0;
//                for (int i = 0; i < files.Length; i++)
//                {
//                    progresBar.Value = progresBar.Value + 1;
//                }
//            }
//        }
//        private void Archiver()
//        {
//            var directory = new DirectoryInfo(textBoxFolder.Text);
//            if (directory.Exists)
//            {
//                string zipPath = textBoxFolder.Text + $".zip";
//                FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
//                using (FileStream zipFile = File.Open(zipPath, FileMode.OpenOrCreate))
//                {
//                    using (ZipArchive archive = new ZipArchive(zipFile, ZipArchiveMode.Update))
//                    {
//                        for (int i = 0; i < files.Length; i++)
//                        {
//                            FileInfo fi = new FileInfo(files[i].FullName);
//                            var fullPath = files[i].FullName;
//                            var path = fullPath.Substring(textBoxFolder.Text.Length);
//                            ZipArchiveEntry fileEntry = archive.CreateEntryFromFile(files[i].FullName, path, CompressionLevel.Optimal);
//                        }
//                    }
//                }
//                MessageBox.Show("Archive Complete");
//            }
//        }
//        async Task ArchiverAsync()
//        {
//            await Task.Run(() => Archiver());
//        }












//        //Regex regexFolder = new Regex(@".*\\");
//        //string folder = regexFolder.Replace(textBoxFolder.Text, "");
//        //ListSelectedAsync(fileEntry.ToString());
//        //public void ListSelected(string fileEntry)
//        //{
//        //    listSelectedFiles.Items.Add(fileEntry);
//        //}
//        //async Task ListSelectedAsync(string fileEntry)
//        //{
//        //    await Task.Run(() => ListSelected(fileEntry));
//        //}


//    }
//}
