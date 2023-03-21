using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21._1
{
    public sealed class Road
    {
        public string Number { get; set; }
        public int Lenght { get; set; }

        public override string ToString()                        // вопрос
        {
            return $"Дорогв {Number} длинной {Lenght}";
        }
    }
}
