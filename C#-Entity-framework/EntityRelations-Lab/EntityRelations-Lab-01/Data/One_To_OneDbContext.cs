using EntityRelations_Lab_01.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityRelations_Lab_01.Data
{
    public class One_To_OneDbContext : DbContext
    {
        
        public One_To_OneDbContext()
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=One_To_One;Integrated Security=True;");
            }
        }

        
    }
}
