using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ControlSearch.Properties;

namespace ControlSearch
{
    public partial class UserControlSearch : UserControl
    {

        public UserControlSearch()
        {
            InitializeComponent();
            textBoxFolder.Text = Settings.Default["Path"].ToString();
            textBoxRegex.Text = Settings.Default["Regex"].ToString();
            //treeViewSearch.BeforeSelect += treeViewSearch_BeforeSelect;
            treeViewSearch.BeforeExpand += treeViewSearch_BeforeExpand;
            Name = "Поиск";
        }
        int allCount = 0;
        int searchCount = 0;









        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FillSearchNodes();
            textBoxAllCount.Text = allCount.ToString();
            textBoxSearchCount.Text = searchCount.ToString();
            allCount = 0;
            searchCount = 0;
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








        private async void treeViewSearch_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {

                    //dirs = Directory.GetFileSystemEntries(e.Node.FullPath);
                    dirs = Directory.GetFiles(e.Node.FullPath, "*", SearchOption.AllDirectories);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            if (Regex.IsMatch(dirs[i], textBoxRegex.Text))
                            {
                                
                                e.Node.Nodes.Add(dirNode);
                            }

                        }
                    }
                }
            }
            catch (Exception ex) { }
        }









        private void FillTreeNode(TreeNode searchNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
                for (int i = 0; i < dirs.Length; i++)
                {
                    allCount++;
                    if (Regex.IsMatch(dirs[i], textBoxRegex.Text))
                    {
                        searchCount++;
                        TreeNode dirNode = new TreeNode();
                        dirNode.Text = dirs[i].Remove(0, dirs[i].LastIndexOf("\\") + 1);
                        searchNode.Nodes.Add(dirNode);
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void FillSearchNodes()
        {
            try
            {
                TreeNode searchNode = new TreeNode { Text = textBoxFolder.Text };
                FillTreeNode(searchNode, textBoxFolder.Text);
                treeViewSearch.Nodes.Add(searchNode);
            }
            catch (Exception ex) { }
        }











        //void treeViewSearch_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        //{
        //    e.Node.Nodes.Clear();
        //    string[] dirs;
        //    try
        //    {
        //        if (Directory.Exists(e.Node.FullPath))
        //        {
        //            dirs = Directory.GetFiles(e.Node.FullPath, "*", SearchOption.AllDirectories);
        //            if (dirs.Length != 0)
        //            {
        //                for (int i = 0; i < dirs.Length; i++)
        //                {

        //                    TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
        //                    FillTreeNode(dirNode, dirs[i]);
        //                    e.Node.Nodes.Add(dirNode);

        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex) { }
        //}





        //private void FillTreeNode2(TreeNode searchNode, string path)
        //{
        //    try
        //    {
        //        string[] dirs = Directory.GetDirectories(path);
        //        foreach (string dir in dirs)
        //        {
        //            TreeNode dirNode = new TreeNode();
        //            dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
        //            searchNode.Nodes.Add(dirNode);
        //        }
        //    }
        //    catch (Exception ex) { }
        //}




        //void treeViewSearch_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        //{
        //    e.Node.Nodes.Clear();
        //    string[] dirs;
        //    try
        //    {
        //        if (Directory.Exists(e.Node.FullPath))
        //        {
        //            dirs = Directory.GetFiles(e.Node.FullPath, "*", SearchOption.AllDirectories);
        //            if (dirs.Length != 0)
        //            {
        //                for (int i = 0; i < dirs.Length; i++)
        //                {
        //                    if (Regex.IsMatch(dirs[i], textBoxRegex.Text))
        //                    {
        //                        TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
        //                        FillTreeNode2(dirNode, dirs[i]);
        //                        e.Node.Nodes.Add(dirNode);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex) { }
        //}

    }
}
