using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Models
{
    public class Store
    {
        public Store()
        {
            this.CreatedOn = DateTime.Now;
            this.IsDeleted = false;
            this.ProductStores = new List<ProductStore>();
        }
        //Primary key
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        //Meta-data
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DeletedOn { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }

        //Entity relations

        public ICollection<ProductStore> ProductStores { get; set; }
    }
}
