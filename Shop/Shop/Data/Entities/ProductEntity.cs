using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Entities
{
    public class ProductEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;

        public int SupplierId { get; set; }
        public SupplierEntitiy Supplier { get; set; } = null!;

        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; } = null!;

        public List<OrderDetailEntity> Details { get; set; } = new List<OrderDetailEntity>();
    }
}
