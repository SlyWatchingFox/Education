using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lesson26._1
{
    [Serializable]
    public class Group
    {
        [NonSerialized]
        private readonly Random rnd = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));

        public int Number { get; set; }
        public string Name { get; set; }
        public Group()
        {
            Number = rnd.Next(1, 10);
            Name = "Группа" + rnd;
        }

        public Group(int number, string name)
        {
            // Проверка входных данных

            Number = number;
            Name = name;
        }
        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
