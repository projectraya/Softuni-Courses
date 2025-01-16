using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Exercise_02.Data.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string Initials { get; set; }
        public decimal Budget { get; set; }

        [ForeignKey(nameof(PrimaryKitColorId))]
        public int PrimaryKitColorId { get; set; }

        [ForeignKey(nameof(SecondaryKitColorId))]
        public int SecondaryKitColorId { get; set; }

        [ForeignKey(nameof(Town))]
        public int TownId { get; set; }
        public Town Town { get; set; }

        ICollection<Player> Players = new List<Player>(); 
    }
}
