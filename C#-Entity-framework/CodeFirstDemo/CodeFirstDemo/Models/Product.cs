using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Models
{
    public class Product
    {
        public Product()
        {
            this.CreatedOn = DateTime.Now;
            this.IsDeleted = false;
            this.ProductStores = new List<ProductStore>();
        }

        
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        //Meta-data
        public string? Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? LastModifiedBy { get; set; }

        //public DateTime? DeletedOn { get; set; }
        //public string? CreatedBy { get; set; }
        

        //Entity relations
        public ICollection<ProductStore> ProductStores { get; set; }
    }
}
