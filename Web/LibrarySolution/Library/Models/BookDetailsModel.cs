namespace Library.Models
{
    public class BookDetailsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public int YearPublished { get; set; }
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }
    }
}
