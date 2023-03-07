using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul
{
    public class Enter
    {
        public static int Check()
        {
            int i;
            while (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Не верный ввод. Повторите");
            }
            return i;
        }
    }
}
