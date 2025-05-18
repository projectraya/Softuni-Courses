namespace Library.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<BookViewModel> AllBooks { get; set; }
        public int BooksCount { get; set; }
        public string LatestBookTitle { get; set; }
    }
}
