using Microsoft.EntityFrameworkCore;
using WebAPIApp.Models;

namespace WebAPIApp.Data
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Posts>? Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mydb.db");
        }
    }
}