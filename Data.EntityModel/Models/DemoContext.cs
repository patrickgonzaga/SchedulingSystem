using Microsoft.EntityFrameworkCore;

namespace Data.Web.Models
{
    public class DemoContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite(@"Data Source=./Database/Database.db");
    }
}
