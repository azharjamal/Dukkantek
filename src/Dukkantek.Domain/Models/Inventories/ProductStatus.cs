using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukkantek.Domain.Models.Inventories
{
    public class ProductStatus
    {
        public int CategoryId { get; set; }
        public int InStock { get; set; }
        public int Sold { get; set; }
        public int Damaged { get; set; }

    }

}
