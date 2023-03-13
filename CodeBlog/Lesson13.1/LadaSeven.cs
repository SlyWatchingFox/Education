using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13._1
{
    class LadaSeven : ICar, IDisposable
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Move(int distance)
        {
            return distance / 40;
        }
    }
}
