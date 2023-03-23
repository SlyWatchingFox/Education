using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul
{
    public class Enter
    {
        public static double Check()
        {
            Console.WriteLine("Введите число");
            double i;
            while (!double.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
            return i;
        }
    }
}
