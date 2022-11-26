using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Entities
{
    public class PaymentEntity
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; } = null!;
        public bool Allowed { get; set; }

        public List<OrderEntity> Orders { get; set; } = new List<OrderEntity>();
    }
}
