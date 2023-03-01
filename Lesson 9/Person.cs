using System;
using System.Xml.Linq;

namespace Lesson_9
{
    public class Person
    {
        public string SecondName { get; set; }

        public string Name { get; set; }

        public string FullName
        {
            get
            {
                return SecondName + " " + Name;
            }
        }
        public string ShortName
        {
            get
            {
                return $"{SecondName} {Name.Substring(0, 1)}.";
            }
        }
    }
}
