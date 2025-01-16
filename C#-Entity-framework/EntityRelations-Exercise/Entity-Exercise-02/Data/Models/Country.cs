using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Exercise_02.Data.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }

        ICollection<Town> Towns = new List<Town>();
    }
}
