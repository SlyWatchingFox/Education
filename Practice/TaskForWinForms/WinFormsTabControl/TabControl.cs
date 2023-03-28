using FormCalculator;
using FormMenu;
using FormRGB;
using WindowsFormsControlLibraryArchiver;

namespace WinFormsTabControl
{
    public partial class TabControl : Form
    {
        public TabControl()
        {
            InitializeComponent();
            UserControlCalculator calculatorControl = new UserControlCalculator();
            tabControl1.TabPages[0].Controls.Add(calculatorControl);

            UserControlRGB rgbControl = new UserControlRGB();
            tabControl1.TabPages[1].Controls.Add(rgbControl);

            UserControlMenu menuControl = new UserControlMenu();
            tabControl1.TabPages[2].Controls.Add(menuControl);

            UserControlArchiver archiverControl = new UserControlArchiver();
            tabControl1.TabPages[3].Controls.Add(archiverControl);
        }

        private void TabControl_Load(object sender, EventArgs e)
        {

        }

        private void UserControlCalculator_Click(object sender, EventArgs e)
        {

        }
    }
}