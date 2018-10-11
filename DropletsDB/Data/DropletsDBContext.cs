using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DropletsDB.Models
{
    public class DropletsDBContext : DbContext
    {
        public DropletsDBContext (DbContextOptions<DropletsDBContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        public DbSet<Account> Account { get; set; }

        public DbSet<BudgetItem> BudgetItem { get; set; }

        public DbSet<Category> Category { get; set; }
    }
}
