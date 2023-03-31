using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson25._1
{
    //[Geo(10, 20)]
    public class Photo
    {
        [Geo(10, 20)]
        public string Name { get; set; }
        public string Path { get; set; }
        [Geo(10, 20)]
        public Photo(string name)
        {
            //Проверка

            Name = name;
        }
    }
}
