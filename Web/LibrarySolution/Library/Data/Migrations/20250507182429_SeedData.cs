using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "George Orwell" },
                    { 2, "Jane Austen" },
                    { 3, "J.K. Rowling" },
                    { 4, "Mark Twain" },
                    { 5, "Haruki Murakami" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fiction" },
                    { 2, "Fantasy" },
                    { 3, "Classic" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CategoryId", "ImageUrl", "Title", "YearPublished" },
                values: new object[,]
                {
                    { 1, 1, 1, "https://miro.medium.com/v2/resize:fit:7084/1*6QXManBm7wsBgDiagqPH8Q.png", "1984", 1949 },
                    { 2, 1, 1, "https://m.media-amazon.com/images/I/91Lbhwt5RzL.jpg", "Animal Farm", 1945 },
                    { 3, 2, 3, "https://m.media-amazon.com/images/I/81a3sr-RgdL.jpg", "Pride and Prejudice", 1813 },
                    { 4, 2, 3, "https://m.media-amazon.com/images/I/A1dZA3BmyKL._AC_UF1000,1000_QL80_.jpg", "Emma", 1815 },
                    { 5, 3, 2, "https://cdn.europosters.eu/image/1300/214926.jpg", "Harry Potter and the Sorcerer's Stone", 1997 },
                    { 6, 3, 2, "https://cdn.europosters.eu/image/1300/214927.jpg", "Harry Potter and the Chamber of Secrets", 1998 },
                    { 7, 3, 2, "https://cdn.europosters.eu/image/1300/214928.jpg", "Harry Potter and the Prisoner of Azkaban", 1999 },
                    { 8, 4, 3, "https://m.media-amazon.com/images/I/51VEmL80JJL._AC_UF1000,1000_QL80_.jpg", "The Adventures of Tom Sawyer", 1876 },
                    { 9, 4, 3, "https://upload.wikimedia.org/wikipedia/commons/6/61/Huckleberry_Finn_book.JPG", "Adventures of Huckleberry Finn", 1884 },
                    { 10, 5, 1, "https://www.ciela.com/media/catalog/product/cache/9a7ceae8a5abbd0253425b80f9ef99a5/k/a/kafka_on_the_shore_-_haruki_murakami_-_9780099458326_-_vintage_classics.jpg", "Kafka on the Shore", 2002 },
                    { 11, 5, 1, "https://m.media-amazon.com/images/I/81zqVhvbHbL.jpg", "Norwegian Wood", 1987 },
                    { 12, 5, 1, "https://m.media-amazon.com/images/I/61iQW5TTZCL._AC_UF1000,1000_QL80_.jpg", "1Q84", 2009 },
                    { 13, 2, 3, "https://m.media-amazon.com/images/I/818mKxj9pAL.jpg", "Sense and Sensibility", 1811 },
                    { 14, 1, 1, "https://m.media-amazon.com/images/I/91VKuMIjd-L.jpg", "Down and Out in Paris and London", 1933 },
                    { 15, 5, 1, "https://m.media-amazon.com/images/I/81Q2BP9rKoL.jpg", "The Elephant Vanishes", 1993 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
