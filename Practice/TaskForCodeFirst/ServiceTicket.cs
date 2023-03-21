using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForCodeFirst
{
    public class ServiceTicket
    {
        public int ServiceTicketId { get; set; }
        public int ServiceTicketNumber { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public int DataReceived { get; set; }
        public string? Comments { get; set; }
        public int DateReturnToCustomer { get; set; }

        public virtual ICollection<ServiceMechanic> ServiceMechanics { get; set; }
        public virtual ICollection<PartsUsed> PartsUseds { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Car Car { get; set; }
    }
}
