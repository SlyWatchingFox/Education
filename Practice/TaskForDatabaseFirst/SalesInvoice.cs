using System;
using System.Collections.Generic;

namespace TaskForDatabaseFirst;

public partial class SalesInvoice
{
    public int InvoiceId { get; set; }

    public int InvoiceNumber { get; set; }

    public DateTime Date { get; set; }

    public int CarId { get; set; }

    public int CustomerId { get; set; }

    public int SalespersonId { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual Salesperson Salesperson { get; set; } = null!;
}
