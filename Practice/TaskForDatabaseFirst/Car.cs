using System;
using System.Collections.Generic;

namespace TaskForDatabaseFirst;

public partial class Car
{
    public int CarId { get; set; }

    public int SerialNumber { get; set; }

    public string? Make { get; set; }

    public string Model { get; set; } = null!;

    public string Colour { get; set; } = null!;

    public int? Year { get; set; }

    public string CarFoSaleYN { get; set; } = null!;

    public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();

    public virtual ICollection<ServiceTicket> ServiceTickets { get; } = new List<ServiceTicket>();
}
