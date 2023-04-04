using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ControlArchiver
{
    public partial class UserControlArchiver : UserControl
    {
        static CancellationTokenSource cts = new CancellationTokenSource();

        Archiver archiver = new Archiver();

        public UserControlArchiver()
        {
            InitializeComponent();
            archiver.FileCompressed += DisplayParameters;
            Name = "Архиватор";
        }

        private void DisplayParameters(int pBarValue, string filesPath)
        {
            progresBar.Value = pBarValue;
            toolStripStatusLabel.Text = filesPath;
            statusStrip.Update();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxFolder.Text = fbd.SelectedPath;
                listSelectedFiles.Items.Clear();
                foreach (var item in Directory.GetFiles(fbd.SelectedPath, "*", SearchOption.AllDirectories))
                {
                    listSelectedFiles.Items.Add(item);
                }
            }
        }

        private async void btnArchive1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFolder.Text))
            {
                MessageBox.Show("Пожалуйста укажите путь для папки с файлами.", "Сообщение", MessageBoxButtons.OK);
                return;
            }
            bool checkJson;
            if (checkBoxCreateJson.Checked) { checkJson = true; }
            else checkJson = false;
            var directory = new DirectoryInfo(textBoxFolder.Text);
            if (directory.Exists)
            {
                FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
                progresBar.Maximum = files.Length;
                progresBar.Value = 0;
                await archiver.Compress(textBoxFolder.Text, files, cts.Token, checkJson);
                MessageBox.Show("Archive Complete");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            cts = new CancellationTokenSource();
        }
    }
}
