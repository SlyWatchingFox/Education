using System;
using System.Collections.Generic;

namespace TaskForDatabaseFirst;

public partial class ServiceTicket
{
    public int ServiceTicketId { get; set; }

    public int ServiceTicketNumber { get; set; }

    public int CarId { get; set; }

    public int CustomerId { get; set; }

    public DateTime DataReceived { get; set; }

    public string? Comments { get; set; }

    public DateTime DateReturnToCustomer { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<PartsUsed> PartsUseds { get; } = new List<PartsUsed>();

    public virtual ICollection<ServiceMechanic> ServiceMechanics { get; } = new List<ServiceMechanic>();
}
