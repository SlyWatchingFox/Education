﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculator
{
    public partial class UserControlCalculator : UserControl
    {
        public UserControlCalculator()
        {
            InitializeComponent();
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

        private void btnLeftBracket_Click(object sender, EventArgs e)
        {
            textResult.Text += "(";
        }

        private void btnRightBracket_Click(object sender, EventArgs e)
        {
            textResult.Text += ")";
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            textResult.Text += "%";
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            textResult.Text += "sq(";
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            textResult.Text = MathOperations.Main1(textResult.Text);
        }

        public void textResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
