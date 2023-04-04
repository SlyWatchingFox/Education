using System;
using System.Windows.Forms;

namespace FormCalculator
{
    public partial class UserControlCalculator : UserControl
    {
        public UserControlCalculator()
        {
            InitializeComponent();
            Name = "Калькулятор";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            textResult.Clear();
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            textResult.Text += 0;
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            textResult.Text += 1;
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            textResult.Text += 2;
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            textResult.Text += 3;
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            textResult.Text += 4;
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            textResult.Text += 5;
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            textResult.Text += 6;
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            textResult.Text += 7;
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            textResult.Text += 8;
        }
        private void btnNine_Click(object sender, EventArgs e)
        {
            textResult.Text += 9;
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            textResult.Text += ",";
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            textResult.Text += "+";
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            textResult.Text += "-";
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            textResult.Text += "*";
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            textResult.Text += "/";
        }
        private void btnInterest_Click(object sender, EventArgs e)
        {
            textResult.Text += "%";
        }
        private void btnSquare_Click(object sender, EventArgs e)
        {
            var result = MathOperations.Main1(textResult.Text);
            textResult.Text = Math.Sqrt(Convert.ToDouble(result)).ToString();
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            textResult.Text = MathOperations.Main1(textResult.Text);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textResult.Text.Length > 0)
            {
                textResult.Text = textResult.Text.Substring(0, textResult.Text.Length - 1);
            }
        }
    }
}
