using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Class1
    {
        public static async Task JopaAsync()
        {
            await Task.Run(() => Jopa());
        }
        public static void Jopa()
        {
            Console.WriteLine("Before");
            Task.Delay(5000);
            Console.WriteLine("After");
        }
    }
}
