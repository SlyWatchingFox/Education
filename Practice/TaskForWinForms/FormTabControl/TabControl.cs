using ControlArchiver;
using FormCalculator;
using FormMenu;
using FormRGB;
using System.Reflection;

namespace WinFormsTabControl
{
    public partial class TabControl : Form
    {
        public TabControl()
        {
            InitializeComponent();
            //UserControlCalculator calculatorControl = new UserControlCalculator();
            //tabControl1.TabPages[0].Controls.Add(calculatorControl);

            //UserControlRGB rgbControl = new UserControlRGB();
            //tabControl1.TabPages[1].Controls.Add(rgbControl);

            //UserControlMenu menuControl = new UserControlMenu();
            //tabControl1.TabPages[2].Controls.Add(menuControl);

            //UserControlArchiver archiverControl = new UserControlArchiver();
            //tabControl1.TabPages[3].Controls.Add(archiverControl);

            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
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
                        if (type == typeof(UserControl))
                        {
                            UserControl uesrControl = (UserControl)Activator.CreateInstance(type);
                            TabPage tabPage= new TabPage();
                            //tabPage.Controls.Add(uesrControl);
                            tabControl1.Controls.Add(uesrControl);
                        }
                    }
                }
            }
        }
    }
}