using System;
using System.Collections.Generic;

namespace TaskForDatabaseFirst;

public partial class Salesperson
{
    public int SalespersonId { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();
}
