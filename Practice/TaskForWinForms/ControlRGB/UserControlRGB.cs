using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormRGB
{
    public partial class UserControlRGB : UserControl
    {
        public UserControlRGB()
        {
            InitializeComponent();
            trackBarRed.Scroll += trackBarRed_Scroll;
            trackBarGreen.Scroll += trackBarGreen_Scroll;
            trackBarBlue.Scroll += trackBarBlue_Scroll;
        }
        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            textBoxRed.Text = Convert.ToString(trackBarRed.Value, 16);
            EditColor();

        }
        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            textBoxGreen.Text = Convert.ToString(trackBarGreen.Value, 16);
            EditColor();

        }
        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            textBoxBlue.Text = Convert.ToString(trackBarBlue.Value, 16);
            EditColor();
        }

        private void EditColor()
        {
            panelRGB.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            textBoxHEXcode.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            textBoxHEXcode.Text = textBoxRed.Text + textBoxGreen.Text + textBoxBlue.Text;
        }
    }
}
