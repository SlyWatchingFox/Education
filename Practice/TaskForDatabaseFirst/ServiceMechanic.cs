using System;
using System.Collections.Generic;

namespace TaskForDatabaseFirst;

public partial class ServiceMechanic
{
    public int ServiceMechanicId { get; set; }

    public int ServiceTicketId { get; set; }

    public int ServiceId { get; set; }

    public int MechanicId { get; set; }

    public TimeSpan? Hours { get; set; }

    public string? Comment { get; set; }

    public int? Rate { get; set; }

    public virtual Mechanic Mechanic { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;

    public virtual ServiceTicket ServiceTicket { get; set; } = null!;
}
