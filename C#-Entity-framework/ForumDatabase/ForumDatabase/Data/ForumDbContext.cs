using ForumDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumDatabase.Data
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext()
        {

        }
        
        public ForumDbContext(DbContextOptions<ForumDbContext> options) : base()
        {
            
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer();
            }
        }
    }
}
