using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson26._1
{
    [Serializable]
    public class Student
    {
        public string Name { get; }
        public int Age { get; }
        public Group Group { get; set; }

        public Student(string name, int age)
        {
            // Проверка входных параметров
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
