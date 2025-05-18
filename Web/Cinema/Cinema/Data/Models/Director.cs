using System.ComponentModel.DataAnnotations;

namespace Cinema.Data.Models
{
    public class Director
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
