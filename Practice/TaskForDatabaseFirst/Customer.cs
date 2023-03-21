using System;
using System.Collections.Generic;

namespace TaskForDatabaseFirst;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? LastName { get; set; }

    public string FirstName { get; set; } = null!;

    public int PhoneNumber { get; set; }

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string? StateProvince { get; set; }

    public string Country { get; set; } = null!;

    public int? PostalCode { get; set; }

    public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();

    public virtual ICollection<ServiceTicket> ServiceTickets { get; } = new List<ServiceTicket>();
}
