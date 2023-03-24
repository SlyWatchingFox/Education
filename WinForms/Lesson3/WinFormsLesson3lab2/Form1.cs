namespace WinFormsLesson3lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //bool on = true;
            //if (on)
            //{
            //    System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            //    myPath.AddEllipse(0, 0, btnStart.Width, btnStart.Height);
            //    Region myRegion = new Region(myPath);
            //    btnStart.Region = myRegion;
            //}
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timerSeconds.Enabled == false) { timerSeconds.Enabled = true; }
            else { timerSeconds.Enabled = false; }
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            int miliSeconds = Int32.Parse(textMiliSeconds.Text);
            miliSeconds++;
            textMiliSeconds.Text = miliSeconds.ToString();
            if (miliSeconds == 100)
            {
                int seconds = Int32.Parse(textSeconds.Text);
                seconds++;
                textSeconds.Text = seconds.ToString();
                textMiliSeconds.Text = 0.ToString();
                if (seconds == 60)
                {
                    int minute = Int32.Parse(textMinute.Text);
                    minute++;
                    textMinute.Text = minute.ToString();
                    textSeconds.Text = 0.ToString();

                }
                
            }
           

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textMiliSeconds.Text = 0.ToString();
            textSeconds.Text = 0.ToString();
            textMinute.Text = 0.ToString();
        }

        private void textDate_TextChanged(object sender, EventArgs e)
        {
            this.Text = "sf";
            textDate.Text = DateTime.Now.ToString();
            textDate.Refresh();
        }
    }
}