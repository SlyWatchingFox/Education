using System;
using System.Collections.Generic;

namespace TaskForDatabaseFirst;

public partial class Part
{
    public int PartsId { get; set; }

    public int PartNumber { get; set; }

    public string? Description { get; set; }

    public int PurchasePrice { get; set; }

    public int RetailPrice { get; set; }

    public virtual ICollection<PartsUsed> PartsUseds { get; } = new List<PartsUsed>();
}
