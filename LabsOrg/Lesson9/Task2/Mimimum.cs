using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Mimimum
    {
        public int[] FindMin(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach (int i in numbers)
            {
                if (i < min) { min = i; }

            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == min) { numbers[i] = 0; }
            }
            return numbers;

        }

     
    }
}
