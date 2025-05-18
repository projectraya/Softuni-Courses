using System.ComponentModel;

namespace Cinema.Models
{
    public class MovieFormModel
    {
        public int Id { get; set; }

        [DisplayName("Movie Title")]
        public string Title { get; set; }

        [DisplayName("Poster URL")]
        public string Poster { get; set; }

        [DisplayName("Premiered On (year)")]
        public int YearPublished { get; set; }

        [DisplayName("Summary")]
        public string Description { get; set; }

        public int Likes { get; set; }

        [DisplayName("Director's Name")]
        public string DirectorFullName { get; set; }

        [DisplayName("Genre")]
        public string GenreName { get; set; }
    }
}
