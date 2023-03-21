using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForCodeFirst
{
    public class PartsUsed
    {
        public int PartsUsedId { get; set; }
        public int PartId { get; set; }
        public int ServiceTicketId { get; set; }
        public string NumberUsed { get; set; }
        public int Price { get; set; }

        public virtual Part Part { get; set; }
        public virtual ServiceTicket ServiceTicket { get; set; }

    }
}
