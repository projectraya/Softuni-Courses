namespace Cinema.Models
{
    public class MovieDetailsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Poster { get; set; }
        public int YearPublished { get; set; }
        public string Description { get; set; }
        public int Likes { get; set; }
        public string DirectorFullName { get; set; }
        public string GenreName { get; set; }
    }
}
