namespace WinFormsTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCalcul1_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txtA.Text);
            int b = Int32.Parse(txtB.Text);
            int c = Int32.Parse(txtC.Text);
            double p = (a + b + c) * 0.5;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //double s = a + b + c;
            txtResult.Text = s.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcul2_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txtA.Text);
            int b = Int32.Parse(txtB.Text);
            int c = Int32.Parse(txtC.Text);
            double sin = Math.Sin(c*(Math.PI/180));
            double s = 0.5 * a * b * sin;
            txtResult.Text = s.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listSize.SelectedItem == "Minimal" )
            {
                txtResult.Width = 50;
                
            }
            else if (listSize.SelectedItem == "Middle")
            {
                txtResult.Width = 100;
            }
            else if (listSize.SelectedItem == "Maximum")
            {
                txtResult.Width = 200;
            }
        }

        private void ÷¸ðíûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.ForeColor = System.Drawing.Color.Black;
        }

        private void êðàñíûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.ForeColor = System.Drawing.Color.Red;
        }

        private void ñèíèéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.ForeColor = System.Drawing.Color.Blue;
        }

        private void çåëåíûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.ForeColor = System.Drawing.Color.Green;
        }

        private void áåëûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.WV;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}