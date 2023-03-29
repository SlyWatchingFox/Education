using System;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Text;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsControlLibraryArchiver;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using File = System.IO.File;
using System.Threading;

namespace WindowsFormsControlLibraryArchiver
{
    public partial class UserControlArchiver : UserControl
    {
        static CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken ct = cts.Token;

        public UserControlArchiver()
        {
            InitializeComponent();
        }
        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxFolder.Text = fbd.SelectedPath;
                //foreach (var item in Directory.GetFiles(fbd.SelectedPath, "*", SearchOption.AllDirectories))
                //{
                //    listSelectedFiles.Items.Add(item);
                //}
            }
        }

        private void btnArchive1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFolder.Text))
            {
                MessageBox.Show("Пожалуйста укажите путь для папки с файлами.", "Сообщение", MessageBoxButtons.OK);
                return;
            }
            Archiver();
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            MessageBox.Show("Cancle");
        }



        private void Archiver()
        {
            var directory = new DirectoryInfo(textBoxFolder.Text);
            if (directory.Exists)
            {
                string zipPath = textBoxFolder.Text + $".zip";
                FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
                listSelectedFiles.Items.Clear();
                progresBar.Maximum = files.Length;
                progresBar.Value = 0;
                using (FileStream zipFile = File.Open(zipPath, FileMode.OpenOrCreate))
                {
                    using (ZipArchive archive = new ZipArchive(zipFile, ZipArchiveMode.Update))
                    {
                        //if (!ct.IsCancellationRequested)
                        //{
                        for (int i = 0; i < files.Length; i++)
                        {
                            FileInfo fi = new FileInfo(files[i].FullName);
                            var fullPath = files[i].FullName;
                            var path = fullPath.Substring(textBoxFolder.Text.Length);
                            var fileEntry = ArchiverAsync(files, archive, i, path);
                            listSelectedFiles.Items.Add(path);
                            listSelectedFiles.Refresh();
                            listSelectedFiles.TopIndex = listSelectedFiles.Items.Count - 1;
                            listSelectedFiles.SelectedIndex = listSelectedFiles.Items.Count - 1;
                            progresBar.Value = progresBar.Value + 1;
                        }
                        MessageBox.Show("Archive Complete");
                        //}
                    }
                }
            }
        }

        private static ZipArchiveEntry Enetry(FileInfo[] files, ZipArchive archive, int i, string path)
        {
            return archive.CreateEntryFromFile(files[i].FullName, path, CompressionLevel.Optimal);
        }


        async Task ArchiverAsync(FileInfo[] files, ZipArchive archive, int i, string path)
        {
            await Task.Run(() => Enetry(files, archive, i, path));
        }

        public void listSelectedFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

