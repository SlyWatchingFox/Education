using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForCodeFirst
{
    public class SalesInvoice
    {
        [Key]
        public int InvoiceId { get; set; }
        public int InvoiceNumber { get; set; }
        public string Date { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public int SalesPersonId { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Car Car { get; set; }
    }
}
