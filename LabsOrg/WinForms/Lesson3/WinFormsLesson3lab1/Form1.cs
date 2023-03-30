namespace WinFormsLesson3lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int fromX = Int32.Parse(textX1.Text);
            int toX = Int32.Parse(textX2.Text);
            int fromY = Int32.Parse(textY1.Text);
            int toY = Int32.Parse(textY2.Text);
            if (fromX > toX || fromY > toY)
            {
                MessageBox.Show("Не правильно Пошёл на хуй :P");
                textX1.Text = "";
                textY1.Text = "";
            }
            for (int x = fromX; x <= toX; x++)
            {
                for (int y = fromY; y <= toY; y++)
                {
                    listResult.Items.Add($"z(x,y) = {x}-{y} = {x - y}");
                }
            }
        }
    }
}