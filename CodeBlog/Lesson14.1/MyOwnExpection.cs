using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14._1
{
    class MyOwnExpection : Exception
    {
        public MyOwnExpection() : base("Это мое исключение")
        {
            
        }
        public MyOwnExpection(string message):base(message)
        {

        }
    }
}
