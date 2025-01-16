using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Exercise_02.Data.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }
        public string Name { get; set; }

        ICollection<Player> Players = new List<Player>();
    }
}
