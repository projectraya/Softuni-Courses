using Entity_Relations_Lab_02.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Relations_Lab_02.Data
{
    public class One_To_ManyDbContext : DbContext
    {
        public One_To_ManyDbContext()
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=One_To_Many;Integrated Security=True;");
            }
        }
    }
}
