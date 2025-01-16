using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Models
{
    public class ProductStore
    {
        //Composite primary key(ProductId + StoreId)

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey(nameof(Store))]
        public int StoreId { get; set; }
        public Store Store { get; set; }
    }
}
