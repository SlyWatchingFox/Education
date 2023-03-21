using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskForCodeFirst
{
    public class Car
    {
        public int CarId { get; set; }
        public int SerialNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int? Year { get; set; }
        public string? CarFoSale { get; set; }


        public virtual ICollection<ServiceTicket> ServiceTickets { get; set; }
        public virtual ICollection<SalesInvoice> SalesInvoices { get; set; }
    }
}
