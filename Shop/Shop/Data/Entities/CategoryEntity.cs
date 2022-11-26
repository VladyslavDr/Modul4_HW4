using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Entities
{
    public class CategoryEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public List<ProductEntity> Products { get; set; } = new List<ProductEntity>();
    }
}
