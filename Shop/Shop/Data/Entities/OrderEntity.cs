using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Entities
{
    public class OrderEntity
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public CustomerEntity Customer { get; set; } = null!;

        public int PaymentId { get; set; }
        public PaymentEntity Payment { get; set; } = null!;

        public int ShipperId { get; set; }
        public ShipperEntity Shipper { get; set; } = null!;

        public List<OrderDetailEntity> OrderDetails { get; set; } = new List<OrderDetailEntity>();
    }
}
