using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Exercise_02.Data.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        public string Name { get; set; }

        ICollection<Team> PrimaryKitTeams = new List<Team>();
        ICollection<Team> SecondaryKitTeams = new List<Team>();
    }
}
