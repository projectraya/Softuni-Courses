using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Christopher", "Nolan" },
                    { 2, "Steven", "Spielberg" },
                    { 3, "Quentin", "Tarantino" },
                    { 4, "Hayao", "Miyazaki" },
                    { 5, "Greta", "Gerwig" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Science Fiction" },
                    { 2, "Drama" },
                    { 3, "Animation" },
                    { 4, "Action" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "DirectorId", "GenreId", "Likes", "Poster", "Title", "YearReleased" },
                values: new object[,]
                {
                    { 1, "A thief who steals corporate secrets through the use of dream-sharing technology.", 1, 1, 194, "https://m.media-amazon.com/images/I/81p+xe8cbnL._AC_SY679_.jpg", "Inception", 2010 },
                    { 2, "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", 1, 1, 827, "https://m.media-amazon.com/images/I/71y8mldFZ+L._AC_SY679_.jpg", "Interstellar", 2014 },
                    { 3, "Batman faces the Joker, a criminal mastermind bent on chaos.", 1, 4, 963, "https://m.media-amazon.com/images/I/51k0qa6zY-L._AC_.jpg", "The Dark Knight", 2008 },
                    { 4, "The story of Oskar Schindler, a German businessman who saved Jewish lives during the Holocaust.", 2, 2, 743, "https://m.media-amazon.com/images/I/51byLt5WTOL._AC_.jpg", "Schindler's List", 1993 },
                    { 5, "Scientists clone dinosaurs and create a theme park that quickly spirals out of control.", 2, 1, 665, "https://m.media-amazon.com/images/I/81+E9CN7GmL._AC_SY679_.jpg", "Jurassic Park", 1993 },
                    { 6, "Captain Miller leads a mission to rescue a paratrooper during WWII.", 2, 4, 886, "https://m.media-amazon.com/images/I/71XshhhnzTL._AC_SY679_.jpg", "Saving Private Ryan", 1998 },
                    { 7, "The lives of two mob hitmen, a boxer, and others intertwine in four tales of violence and redemption.", 3, 2, 934, "https://m.media-amazon.com/images/I/71c05lTE03L._AC_SY679_.jpg", "Pulp Fiction", 1994 },
                    { 8, "A freed slave sets out to rescue his wife with the help of a German bounty hunter.", 3, 4, 578, "https://m.media-amazon.com/images/I/71y7zD2zCtL._AC_SY679_.jpg", "Django Unchained", 2012 },
                    { 9, "A former assassin seeks revenge on the team that betrayed her.", 3, 4, 442, "https://m.media-amazon.com/images/I/71zPnvKW+lL._AC_SY679_.jpg", "Kill Bill: Vol. 1", 2003 },
                    { 10, "A young girl enters a magical world and must find her way back.", 4, 3, 792, "https://m.media-amazon.com/images/I/81GqtNbs+PL._AC_SY679_.jpg", "Spirited Away", 2001 },
                    { 11, "Two girls discover magical creatures in the countryside.", 4, 3, 311, "https://m.media-amazon.com/images/I/91rwk3OUixL._AC_SY679_.jpg", "My Neighbor Totoro", 1988 },
                    { 12, "A young warrior gets caught in a struggle between forest gods and humans.", 4, 3, 667, "https://m.media-amazon.com/images/I/81jFqTz4oqL._AC_SY679_.jpg", "Princess Mononoke", 1997 },
                    { 13, "A teenager navigates love, family, and identity during her final year of high school.", 5, 2, 249, "https://m.media-amazon.com/images/I/71AmT2x2lJL._AC_SY679_.jpg", "Lady Bird", 2017 },
                    { 14, "The lives of the March sisters as they grow up in post-Civil War America.", 5, 2, 358, "https://m.media-amazon.com/images/I/81l3rZK4lnL._AC_SY679_.jpg", "Little Women", 2019 },
                    { 15, "Barbie and Ken experience the real world on a journey of self-discovery.", 5, 3, 999, "https://m.media-amazon.com/images/I/81F+GvnKwLL._AC_SY679_.jpg", "Barbie", 2023 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Movies");
        }
    }
}
