namespace WinFormsLesson1
{
    public partial class frmSumma : Form
    {
        public frmSumma()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSumma_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            {
                int summa =Int32.Parse(txtA.Text) +
                   Int32.Parse(txtB.Text) + Int32.Parse(txtC.Text);
                txtSumma.Text = summa.ToString();
            }
        }

        private void frmSumma_Load(object sender, EventArgs e)
        {

        }
    }
}