using Microsoft.EntityFrameworkCore;

namespace DataBaseTutorial
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MyDatabase.sqlite");
        }
    }    
}
