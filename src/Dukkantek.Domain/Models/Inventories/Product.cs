using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukkantek.Domain.Models.Inventories
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public Status Status { get; set; }
        public int CategoryId { get; set; }
        /* EF Relation */

        public Category Category { get; set; }
    }

}
