using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Entities
{
    public class SupplierEntitiy
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Notes { get; set; } = null!;

        public int CustomerId { get; set; }
        public CustomerEntity Customer { get; set; } = null!;

        public List<ProductEntity> Products { get; set; } = new List<ProductEntity>();
    }
}
