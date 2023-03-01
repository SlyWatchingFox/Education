using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9._1
{
    public class Person
    {
        public string SecondName { get; private set; }

        public string Name { get; private set; }

        public Person(string secondName, string name)
        {
            SecondName = secondName;
            Name = name;
        }
    }
}
