using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Threading;

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
                foreach (var item in Directory.GetFiles(fbd.SelectedPath))
                {
                    listSelectedFiles.Items.Add(item);
                }
            }


        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(textBoxFolder.Text))
            //{
            //    MessageBox.Show("Пожалуйста укажите путь для папки с файлами.", "Сообщение", MessageBoxButtons.OK);
            //    return;
            //}
            string pathFolder = textBoxFolder.Text;
            string pathZip = textBoxFolder.Text + ".zip";
            
            int list = listSelectedFiles.TopIndex;
            MessageBox.Show(list.ToString());
            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show("s");
                progresBar.Value = progresBar.Value + 1;
            }
            ZipFile.CreateFromDirectory(pathFolder, pathZip);
            MessageBox.Show($"Папка {pathFolder} архивирована в файл {pathZip}");
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progresBar.Value = progresBar.Value + 1;
        }
    }
}
