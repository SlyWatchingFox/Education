using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13._1
{
    public class Cyborg : ICar, IPerson
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        int ICar.Move(int distance)
        {
            return distance / 100;
        }

        int IPerson.Move(int distance)
        {
            return distance / 5;
        }
    }
}
