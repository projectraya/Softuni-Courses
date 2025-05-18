using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region Seeding Data
            // Seed Authors
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "George Orwell" },
                new Author { Id = 2, Name = "Jane Austen" },
                new Author { Id = 3, Name = "J.K. Rowling" },
                new Author { Id = 4, Name = "Mark Twain" },
                new Author { Id = 5, Name = "Haruki Murakami" }
            );

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Fiction" },
                new Category { Id = 2, Name = "Fantasy" },
                new Category { Id = 3, Name = "Classic" }
            );

            // Seed Books
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "1984", ImageUrl = "https://miro.medium.com/v2/resize:fit:7084/1*6QXManBm7wsBgDiagqPH8Q.png", YearPublished = 1949, AuthorId = 1, CategoryId = 1 },
                new Book { Id = 2, Title = "Animal Farm", ImageUrl = "https://m.media-amazon.com/images/I/91Lbhwt5RzL.jpg", YearPublished = 1945, AuthorId = 1, CategoryId = 1 },
                new Book { Id = 3, Title = "Pride and Prejudice", ImageUrl = "https://m.media-amazon.com/images/I/81a3sr-RgdL.jpg", YearPublished = 1813, AuthorId = 2, CategoryId = 3 },
                new Book { Id = 4, Title = "Emma", ImageUrl = "https://m.media-amazon.com/images/I/A1dZA3BmyKL._AC_UF1000,1000_QL80_.jpg", YearPublished = 1815, AuthorId = 2, CategoryId = 3 },
                new Book { Id = 5, Title = "Harry Potter and the Sorcerer's Stone", ImageUrl = "https://cdn.europosters.eu/image/1300/214926.jpg", YearPublished = 1997, AuthorId = 3, CategoryId = 2 },
                new Book { Id = 6, Title = "Harry Potter and the Chamber of Secrets", ImageUrl = "https://cdn.europosters.eu/image/1300/214927.jpg", YearPublished = 1998, AuthorId = 3, CategoryId = 2 },
                new Book { Id = 7, Title = "Harry Potter and the Prisoner of Azkaban", ImageUrl = "https://cdn.europosters.eu/image/1300/214928.jpg", YearPublished = 1999, AuthorId = 3, CategoryId = 2 },
                new Book { Id = 8, Title = "The Adventures of Tom Sawyer", ImageUrl = "https://m.media-amazon.com/images/I/51VEmL80JJL._AC_UF1000,1000_QL80_.jpg", YearPublished = 1876, AuthorId = 4, CategoryId = 3 },
                new Book { Id = 9, Title = "Adventures of Huckleberry Finn", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/61/Huckleberry_Finn_book.JPG", YearPublished = 1884, AuthorId = 4, CategoryId = 3 },
                new Book { Id = 10, Title = "Kafka on the Shore", ImageUrl = "https://www.ciela.com/media/catalog/product/cache/9a7ceae8a5abbd0253425b80f9ef99a5/k/a/kafka_on_the_shore_-_haruki_murakami_-_9780099458326_-_vintage_classics.jpg", YearPublished = 2002, AuthorId = 5, CategoryId = 1 },
                new Book { Id = 11, Title = "Norwegian Wood", ImageUrl = "https://m.media-amazon.com/images/I/81zqVhvbHbL.jpg", YearPublished = 1987, AuthorId = 5, CategoryId = 1 },
                new Book { Id = 12, Title = "1Q84", ImageUrl = "https://m.media-amazon.com/images/I/61iQW5TTZCL._AC_UF1000,1000_QL80_.jpg", YearPublished = 2009, AuthorId = 5, CategoryId = 1 },
                new Book { Id = 13, Title = "Sense and Sensibility", ImageUrl = "https://m.media-amazon.com/images/I/818mKxj9pAL.jpg", YearPublished = 1811, AuthorId = 2, CategoryId = 3 },
                new Book { Id = 14, Title = "Down and Out in Paris and London", ImageUrl = "https://m.media-amazon.com/images/I/91VKuMIjd-L.jpg", YearPublished = 1933, AuthorId = 1, CategoryId = 1 },
                new Book { Id = 15, Title = "The Elephant Vanishes", ImageUrl = "https://m.media-amazon.com/images/I/81Q2BP9rKoL.jpg", YearPublished = 1993, AuthorId = 5, CategoryId = 1 }
            );
            #endregion
        }
    }
}
