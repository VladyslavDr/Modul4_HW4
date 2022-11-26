using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Entities
{
    public class CustomerEntity
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public List<OrderEntity> Orders { get; set; } = new List<OrderEntity>();

        public List<SupplierEntitiy> Suppliers { get; set; } = new List<SupplierEntitiy>();
    }
}
