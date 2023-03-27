using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson24._1
{
    internal class Lesson
    {
        public string Name { get; }
        public DateTime Begin { get; private set; }
        public event EventHandler<DateTime> Started;
        public Lesson(string name)
        {
            //проверка входных аргументов
            Name = name;
        }
        public void Start()
        {
            Begin = DateTime.Now;
            Started?.Invoke(this, Begin);
        }

    }
}
