using System;
using System.Collections.Generic;

namespace TaskForDatabaseFirst;

public partial class Service
{
    public int ServiceId { get; set; }

    public string? ServiceName { get; set; }

    public int? HourlyRate { get; set; }

    public virtual ICollection<ServiceMechanic> ServiceMechanics { get; } = new List<ServiceMechanic>();
}
