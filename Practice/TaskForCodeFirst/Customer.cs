using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForCodeFirst
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string? StateProvince { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }

        public virtual ICollection<ServiceTicket> ServiceTickets { get; set; }
        public virtual ICollection<SalesInvoice> SalesInvoices { get; set; }


    }
}
