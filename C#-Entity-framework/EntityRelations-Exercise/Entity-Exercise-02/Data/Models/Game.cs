using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Exercise_02.Data.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [ForeignKey(nameof(Team))]
        public int HomeTeamId { get; set; }

        [ForeignKey(nameof(Team))]
        public int AwayTeamId { get; set; }
        public int AwayTeamGoals { get; set; }
        public int HomeTeamGoals { get; set; }
        public DateTime DateTime { get; set; }
        public decimal HomeTeamBetRate { get; set; }
        public decimal AwayTeamBetRate { get; set; }
        public decimal DrawBetRate { get; set; }
        public decimal Result { get; set; }

        ICollection<Game> HomeGames = new List<Game>();
        ICollection<Game> AwayGames = new List<Game>();
        ICollection<Player> PlayersStatistics = new List<Player>();
        ICollection<Bet> Bets = new List<Bet>();

    }
}
