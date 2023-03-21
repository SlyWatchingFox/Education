using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForCodeFirst
{
    public class Mechanic
    {
        public int MechanicId { get; set; }
        public string LastName { get;set; }
        public string FirstName { get;set; }

        public virtual ICollection<ServiceMechanic> ServiceMechanics { get; set; }
    }
}
