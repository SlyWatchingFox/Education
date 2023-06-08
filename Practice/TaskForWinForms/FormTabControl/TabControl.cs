using System.Reflection;

namespace WinFormsTabControl
{
    public partial class TabControl : Form
    {
        public TabControl()
        {
            InitializeComponent();
            LoadPlug();
        }
        public void LoadPlug()
        {
            try
            {
                var asm = Assembly.GetEntryAssembly();
                if (asm == null) return;
                var path = Path.GetDirectoryName(asm.Location);
                if (path == null) return;
                var directory = new DirectoryInfo(path);
                if (directory != null)
                {
                    Assembly asmDll;
                    FileInfo[] files = directory.GetFiles("*.dll");
                    var dllList = new List<string>();
                    foreach (FileInfo file in files)
                    {
                        asmDll = Assembly.LoadFrom(file.FullName);
                        Type[] types = asmDll.GetTypes();
                        foreach (Type type in types)
                        {
                            if (type.IsSubclassOf(typeof(UserControl)))
                            {
                                var inst = Activator.CreateInstance(type);
                                if (inst == null) continue;
                                UserControl userControl = (UserControl)inst;
                                TabPage tabPage = new TabPage();
                                tabPage.Text = userControl.Name;
                                tabPage.Controls.Add(userControl);
                                tabControl1.TabPages.Add(tabPage);
                            }
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}