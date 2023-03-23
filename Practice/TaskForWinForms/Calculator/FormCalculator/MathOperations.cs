using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculator
{
    public static class MathOperations
    {
        public static string Main1(string s)
        {
            string[] numbers = Regex.Split(s, @"\D");
            string[] signs = Regex.Split(s, @"\d");
            double item = 0;
            if (numbers.Length > 0)
            {
                if (signs[0] == "+")
                {
                    item = Int32.Parse(numbers[0]) + Int32.Parse(numbers[1]);
                }
            }
            return signs[1];
        }
    }
}
