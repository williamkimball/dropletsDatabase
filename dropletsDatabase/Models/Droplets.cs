using Microsoft.EntityFrameworkCore;
namespace dropletsDatabase.Models
{
    public class Droplets : DbContext
    {
        public Droplets(DbContextOptions<Droplets> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<BudgetItem> BudgetItems { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
