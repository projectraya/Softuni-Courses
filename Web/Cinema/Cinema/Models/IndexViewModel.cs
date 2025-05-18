namespace Cinema.Models
{
    public class IndexViewModel
    {
        public IEnumerable<MovieViewModel> AllMovies { get; set; } = new List<MovieViewModel>();
        public int TotalMoviesCount { get; set; }
        public string? LatestMovieTitle { get; set; }
        public string? OldestMovieTitle { get; set; }
        public string? MostLikedMovieTitle { get; set; }
        public string? MostLikedGenre{ get; set; }
        public string? MostLikedDirector { get; set; }
    }
}
