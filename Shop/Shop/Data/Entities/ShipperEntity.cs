using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Entities
{
    public class ShipperEntity
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public List<OrderEntity> Orders { get; set; } = new List<OrderEntity>();
    }
}
