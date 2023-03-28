using System;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Text;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsControlLibraryArchiver;
using System.Text.RegularExpressions;

namespace WindowsFormsControlLibraryArchiver
{
    public partial class UserControlArchiver : UserControl
    {
        public UserControlArchiver()
        {
            InitializeComponent();
        }


        private void btnFolder_Click(object sender, EventArgs e)
        {
            listSelectedFiles.Items.Clear();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxFolder.Text = fbd.SelectedPath;
                //foreach (var item in Directory.GetFiles(fbd.SelectedPath, "*", SearchOption.AllDirectories))
                //{
                //    listSelectedFiles.Items.Add(item);
                //}
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFolder.Text))
            {
                MessageBox.Show("Пожалуйста укажите путь для папки с файлами.", "Сообщение", MessageBoxButtons.OK);
                return;
            }
            string pathFolder = textBoxFolder.Text;
            string pathZip = textBoxFolder.Text + ".zip";

            int list = listSelectedFiles.Items.Count;
            progresBar.Maximum = list;
            for (int i = 0; i < list; i++)
            {

                progresBar.Value = progresBar.Value + 1;
            }
            ZipFile.CreateFromDirectory(pathFolder, pathZip);
            MessageBox.Show($"Папка {pathFolder} архивирована в файл {pathZip}");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progresBar.Value = progresBar.Value + 1;

        }

        private void btnArchive1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFolder.Text))
            {
                MessageBox.Show("Пожалуйста укажите путь для папки с файлами.", "Сообщение", MessageBoxButtons.OK);
                return;
            }
            progresBar.Value = 0;
            Regex regexFolder = new Regex(@".*\\");
            string folder = regexFolder.Replace(textBoxFolder.Text, "");

            var directory = new DirectoryInfo(textBoxFolder.Text);
            if (directory.Exists)
            {
                string zipPath = textBoxFolder.Text + $"\\{folder}.zip";
                FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
                progresBar.Maximum = files.Length;
                using (FileStream zipFile = File.Open(zipPath, FileMode.OpenOrCreate))
                {
                    using (ZipArchive archive = new ZipArchive(zipFile, ZipArchiveMode.Update))
                    {
                        for (int i = 0; i < files.Length; i++)
                        {
                            FileInfo fi = new FileInfo(files[i].FullName);
                            var fullPath = files[i].FullName;









                            //Regex regexPath = new Regex(@".*\\" + folder);
                            //MessageBox.Show(folder);
                            //string path = regexPath.Replace(fullPath, "");
                            ZipArchiveEntry fileEntry = archive.CreateEntryFromFile(files[i].FullName, fullPath, CompressionLevel.Optimal);
                            progresBar.Value = progresBar.Value + 1;
                            listSelectedFiles.Items.Add(files[i].FullName);
                            //MessageBox.Show("");
                        }

                    }
                }
            }
        }
    }
}
