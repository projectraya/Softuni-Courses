using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Exercise_02.Data.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int SquadNumber { get; set; }

        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public Team Team { get; set; }
        [ForeignKey(nameof(Position))]
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public bool IsInjured { get; set; }

        ICollection<Game> PlayersStatistics = new List<Game>();

    }
}
