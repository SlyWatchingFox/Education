using System;
using System.Collections.Generic;

namespace TaskForDatabaseFirst;

public partial class Mechanic
{
    public int MechanicId { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public virtual ICollection<ServiceMechanic> ServiceMechanics { get; } = new List<ServiceMechanic>();
}
