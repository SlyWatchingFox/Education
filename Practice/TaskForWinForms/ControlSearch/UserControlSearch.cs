using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlSearch.Properties;

namespace ControlSearch
{
    public partial class UserControlSearch : UserControl
    {
        static CancellationTokenSource cts = new CancellationTokenSource();
        public UserControlSearch()
        {
            InitializeComponent();
            textBoxFolder.Text = Settings.Default["Path"].ToString();
            textBoxRegex.Text = Settings.Default["Regex"].ToString();
            Name = "Поиск";
        }
        private int _allCount = 0;
        private int _searchCount = 0;









        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillSearchNodes();
            textBoxAllCount.Text = _allCount.ToString();
            textBoxSearchCount.Text = _searchCount.ToString();
            _allCount = 0;
            _searchCount = 0;
            Settings.Default["Path"] = textBoxFolder.Text;
            Settings.Default["Regex"] = textBoxRegex.Text;
            Settings.Default.Save();
        }
        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxFolder.Text = fbd.SelectedPath;
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            cts = new CancellationTokenSource();
        }




        private void FillTreeNode(TreeNode searchNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
                for (int i = 0; i < dirs.Length; i++)
                {
                    if (Regex.IsMatch(dirs[i], textBoxRegex.Text))
                    {
                        TreeNode dirNode = new TreeNode();
                        dirNode.Text = dirs[i].Remove(0, dirs[i].LastIndexOf("\\") + 1);
                        searchNode.Nodes.Add(dirNode);
                    }
                }
            }
            catch (Exception ex) {}
        }
        private async void FillSearchNodes()
        {
            try
            {
                TreeNode searchNode = new TreeNode { Text = textBoxFolder.Text };
                FillTreeNode(searchNode, textBoxFolder.Text);
                treeViewSearch.Nodes.Add(searchNode);
                searchNode.Nodes.Clear();
                await Task.Run(() => TreeView(searchNode));
            }
            catch (Exception ex) { }
        }

        private async void TreeView(TreeNode searchNode)
        {
            string[] dirs;
            DateTime dateTimeStart = DateTime.Now;
            if (Directory.Exists(searchNode.FullPath))
            {
                dirs = Directory.GetFileSystemEntries(searchNode.FullPath, "*", SearchOption.AllDirectories);
                if (dirs.Length != 0)
                {
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        if (cts.IsCancellationRequested) return;
                        _allCount++;
                        TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                        FillTreeNode(dirNode, dirs[i]);
                        if (Regex.IsMatch(dirs[i], textBoxRegex.Text))
                        {
                            treeViewSearch.BeginInvoke((Action)(() => searchNode.Nodes.Add(dirNode)));
                            _searchCount++;
                        }
                    }
                }
            }
            DateTime dateTimeEnd = DateTime.Now;
            treeViewSearch.BeginInvoke((Action)(() =>
            {
                textBoxTime.Text = (dateTimeEnd - dateTimeStart).ToString();
                textBoxAllCount.Text = _allCount.ToString();
                textBoxSearchCount.Text = _searchCount.ToString();
            }));
        }
    }
}
