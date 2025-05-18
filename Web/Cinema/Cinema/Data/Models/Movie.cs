using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Poster { get; set; } = null!;

        public int YearReleased { get; set; }

        public string Description { get; set; } = null!;

        public int Likes { get; set; }

        [ForeignKey(nameof(Director))]
        public int DirectorId { get; set; }
        public Director Director { get; set; } = null!;

        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set; }
        public Genre Genre { get; set; } = null!;
    }
}
