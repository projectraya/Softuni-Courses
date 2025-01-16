using CodeFirstDemo.Data;
using CodeFirstDemo.Models;

namespace CodeFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoDbContext dbContext = new DemoDbContext();

            Product product = new Product()
            {
                Name = "Test",
                
            };

            dbContext.Products.Add(product);

            dbContext.SaveChanges();
        }
    }
}
