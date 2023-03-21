using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForCodeFirst
{
    public class Part
    {
        public int PartId { get; set; }
        public int PartNumber { get; set; }
        public string? Descriptione { get; set; }
        public int PurchasePrice { get; set; }
        public int RetailPrice { get; set; }

        public virtual ICollection<PartsUsed> PartsUseds { get; set; }
    }
}
