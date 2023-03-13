using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12._1
{
    public class Eating<T>
        where T : Product
    {
        public int Volume { get; private set; }
        public void Add(T product)
        {
            Volume += product.Volume * product.Energy;
        }
    }
}
