using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19._1
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int GroupId { get; set; }    

        public virtual Group Group { get; set; }
    }
}
