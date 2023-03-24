using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

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
            textBoxRed.Text = trackBarRed.Value.ToString();
            panelRGB.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            textBoxGreen.Text = trackBarGreen.Value.ToString();
            panelRGB.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            textBoxBlue.Text = trackBarBlue.Value.ToString();
            panelRGB.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

     

    }
}
