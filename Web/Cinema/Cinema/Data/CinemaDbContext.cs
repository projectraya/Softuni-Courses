using Cinema.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Data
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Seeding Data

            // Seed Directors
            modelBuilder.Entity<Director>().HasData(
                new Director { Id = 1, FirstName = "Christopher", LastName = "Nolan" },
                new Director { Id = 2, FirstName = "Steven", LastName = "Spielberg" },
                new Director { Id = 3, FirstName = "Quentin", LastName = "Tarantino" },
                new Director { Id = 4, FirstName = "Hayao", LastName = "Miyazaki" },
                new Director { Id = 5, FirstName = "Greta", LastName = "Gerwig" }
            );

            // Seed Genres
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Science Fiction" },
                new Genre { Id = 2, Name = "Drama" },
                new Genre { Id = 3, Name = "Animation" },
                new Genre { Id = 4, Name = "Action" }
            );

            // Seed Movies
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Inception",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg",
                    YearReleased = 2010,
                    Description = "A thief who steals corporate secrets through the use of dream-sharing technology.",
                    Likes = 194,
                    DirectorId = 1,
                    GenreId = 1
                },
                new Movie
                {
                    Id = 2,
                    Title = "Interstellar",
                    Poster = "https://m.media-amazon.com/images/M/MV5BYzdjMDAxZGItMjI2My00ODA1LTlkNzItOWFjMDU5ZDJlYWY3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                    YearReleased = 2014,
                    Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                    Likes = 827,
                    DirectorId = 1,
                    GenreId = 1
                },
                new Movie
                {
                    Id = 3,
                    Title = "The Dark Knight",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_FMjpg_UX1000_.jpg",
                    YearReleased = 2008,
                    Description = "Batman faces the Joker, a criminal mastermind bent on chaos.",
                    Likes = 963,
                    DirectorId = 1,
                    GenreId = 4
                },
                new Movie
                {
                    Id = 4,
                    Title = "Schindler's List",
                    Poster = "https://m.media-amazon.com/images/M/MV5BNjM1ZDQxYWUtMzQyZS00MTE1LWJmZGYtNGUyNTdlYjM3ZmVmXkEyXkFqcGc@._V1_.jpg",
                    YearReleased = 1993,
                    Description = "The story of Oskar Schindler, a German businessman who saved Jewish lives during the Holocaust.",
                    Likes = 743,
                    DirectorId = 2,
                    GenreId = 2
                },
                new Movie
                {
                    Id = 5,
                    Title = "Jurassic Park",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjM2MDgxMDg0Nl5BMl5BanBnXkFtZTgwNTM2OTM5NDE@._V1_.jpg",
                    YearReleased = 1993,
                    Description = "Scientists clone dinosaurs and create a theme park that quickly spirals out of control.",
                    Likes = 665,
                    DirectorId = 2,
                    GenreId = 1
                },
                new Movie
                {
                    Id = 6,
                    Title = "Saving Private Ryan",
                    Poster = "https://m.media-amazon.com/images/M/MV5BZGZhZGQ1ZWUtZTZjYS00MDJhLWFkYjctN2ZlYjE5NWYwZDM2XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                    YearReleased = 1998,
                    Description = "Captain Miller leads a mission to rescue a paratrooper during WWII.",
                    Likes = 886,
                    DirectorId = 2,
                    GenreId = 4
                },
                new Movie
                {
                    Id = 7,
                    Title = "Pulp Fiction",
                    Poster = "https://m.media-amazon.com/images/M/MV5BYTViYTE3ZGQtNDBlMC00ZTAyLTkyODMtZGRiZDg0MjA2YThkXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                    YearReleased = 1994,
                    Description = "The lives of two mob hitmen, a boxer, and others intertwine in four tales of violence and redemption.",
                    Likes = 934,
                    DirectorId = 3,
                    GenreId = 2
                },
                new Movie
                {
                    Id = 8,
                    Title = "Django Unchained",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjIyNTQ5NjQ1OV5BMl5BanBnXkFtZTcwODg1MDU4OA@@._V1_.jpg",
                    YearReleased = 2012,
                    Description = "A freed slave sets out to rescue his wife with the help of a German bounty hunter.",
                    Likes = 578,
                    DirectorId = 3,
                    GenreId = 4
                },
                new Movie
                {
                    Id = 9,
                    Title = "Kill Bill: Vol. 1",
                    Poster = "https://m.media-amazon.com/images/M/MV5BZmMyYzJlZmYtY2I3NC00NjAyLTkyZWItZjdjZDI1YTYyYTEwXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                    YearReleased = 2003,
                    Description = "A former assassin seeks revenge on the team that betrayed her.",
                    Likes = 442,
                    DirectorId = 3,
                    GenreId = 4
                },
                new Movie
                {
                    Id = 10,
                    Title = "Spirited Away",
                    Poster = "https://m.media-amazon.com/images/M/MV5BNTEyNmEwOWUtYzkyOC00ZTQ4LTllZmUtMjk0Y2YwOGUzYjRiXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                    YearReleased = 2001,
                    Description = "A young girl enters a magical world and must find her way back.",
                    Likes = 792,
                    DirectorId = 4,
                    GenreId = 3
                },
                new Movie
                {
                    Id = 11,
                    Title = "My Neighbor Totoro",
                    Poster = "https://m.media-amazon.com/images/M/MV5BYWM3MDE3YjEtMzIzZC00ODE5LTgxNTItNmUyMTBkM2M2NmNiXkEyXkFqcGc@._V1_.jpg",
                    YearReleased = 1988,
                    Description = "Two girls discover magical creatures in the countryside.",
                    Likes = 311,
                    DirectorId = 4,
                    GenreId = 3
                },
                new Movie
                {
                    Id = 12,
                    Title = "Princess Mononoke",
                    Poster = "https://m.media-amazon.com/images/M/MV5BNjAzODViNGEtMjBkYi00N2U5LWJjNjAtY2U0MGJhZTEwOTU0XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                    YearReleased = 1997,
                    Description = "A young warrior gets caught in a struggle between forest gods and humans.",
                    Likes = 667,
                    DirectorId = 4,
                    GenreId = 3
                },
                new Movie
                {
                    Id = 13,
                    Title = "Lady Bird",
                    Poster = "https://m.media-amazon.com/images/M/MV5BNjk5MzcyOWQtNzE1Mi00NzdmLTlkM2QtOTdjZThhMDc2Y2NjXkEyXkFqcGc@._V1_.jpg",
                    YearReleased = 2017,
                    Description = "A teenager navigates love, family, and identity during her final year of high school.",
                    Likes = 249,
                    DirectorId = 5,
                    GenreId = 2
                },
                new Movie
                {
                    Id = 14,
                    Title = "Little Women",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMWMzYjNiZWMtMDg4NS00MDgyLTk5MWItOTFmNjg4NzRhZmExXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                    YearReleased = 2019,
                    Description = "The lives of the March sisters as they grow up in post-Civil War America.",
                    Likes = 358,
                    DirectorId = 5,
                    GenreId = 2
                },
                new Movie
                {
                    Id = 15,
                    Title = "Barbie",
                    Poster = "https://m.media-amazon.com/images/M/MV5BYjI3NDU0ZGYtYjA2YS00Y2RlLTgwZDAtYTE2YTM5ZjE1M2JlXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                    YearReleased = 2023,
                    Description = "Barbie and Ken experience the real world on a journey of self-discovery.",
                    Likes = 999,
                    DirectorId = 5,
                    GenreId = 3
                }

            );

            #endregion

        }
    }
}
