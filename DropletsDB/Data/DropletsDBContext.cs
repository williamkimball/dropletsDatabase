using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DropletsDB.Models;

namespace DropletsDB.Models
{
    public class DropletsDBContext : DbContext
    {
        public DropletsDBContext (DbContextOptions<DropletsDBContext> options)
            : base(options)
        {
        }

        public DbSet<DropletsDB.Models.User> User { get; set; }

        public DbSet<DropletsDB.Models.Account> Account { get; set; }

        public DbSet<DropletsDB.Models.BudgetItem> BudgetItem { get; set; }

        public DbSet<DropletsDB.Models.Category> Category { get; set; }
    }
}
