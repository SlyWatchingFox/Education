using System;
using System.Collections.Generic;

namespace TaskForDatabaseFirst;

public partial class PartsUsed
{
    public int PartsUsedId { get; set; }

    public int PartId { get; set; }

    public int ServiceTicketId { get; set; }

    public int NumberUsed { get; set; }

    public int Price { get; set; }

    public virtual Part Part { get; set; } = null!;

    public virtual ServiceTicket ServiceTicket { get; set; } = null!;
}
