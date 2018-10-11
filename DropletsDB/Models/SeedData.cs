using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DropletsDB.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DropletsDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<DropletsDBContext>>()))
            {
                // Look for any users.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                     new User
                     {
                         FirstName = "William",

                     }
                );

                context.Account.AddRange(
                     new Account
                     {
                         UserId = 1,
                         Access_Token = "access-sandbox-913c6392-87de-4889-abe3-9cb25c7463be"

                     }
                );

                context.Category.AddRange(
                     new Category
                     {
                         UserId = 1,
                         Name = "Income"

                     },

                    new Category
                    {
                        UserId = 1,
                        Name = "Savings"

                    },

                    new Category
                    {
                        UserId = 1,
                        Name = "Housing"

                    },
                    new Category
                    {
                        UserId = 1,
                        Name = "Transportation"

                    },
                    new Category
                    {
                        UserId = 1,
                        Name = "Food"

                    },
                    new Category
                    {
                        UserId = 1,
                        Name = "Health"

                    },
                    new Category
                    {
                        UserId = 1,
                        Name = "Insurance"

                    },
                    new Category
                    {
                        UserId = 1,
                        Name = "Debt"

                    },
                    new Category
                    {
                        UserId = 1,
                        Name = "Entertainment"

                    },
                    new Category
                    {
                        UserId = 1,
                        Name = "Miscellaneous"

                    },
                    new Category
                    {
                        UserId = 1,
                        Name = "Bills"

                    }
                );

                context.BudgetItem.AddRange(
                    new BudgetItem
                     {
                         UserId = 1,
                         CategoryId = 1,
                         Name = "Salary",
                         Price = 4500,
                     },
                    new BudgetItem
                     {
                         UserId = 1,
                         CategoryId = 3,
                         Name = "Rent",
                         Price = 1100,
                     },
                    new BudgetItem
                    {
                        UserId = 1,
                        CategoryId = 2,
                        Name = "General Savings",
                        Price = 675,
                    },
                    new BudgetItem
                    {
                        UserId = 1,
                        CategoryId = 4,
                        Name = "Gas",
                        Price = 100,
                    },
                    new BudgetItem
                    {
                        UserId = 1,
                        CategoryId = 5,
                        Name = "Groceries",
                        Price = 200,
                    },
                    new BudgetItem
                    {
                        UserId = 1,
                        CategoryId = 5,
                        Name = "Restaurants",
                        Price = 50,
                    },
                    new BudgetItem
                    {
                        UserId = 1,
                        CategoryId = 6,
                        Name = "General Health",
                        Price = 50,
                    },
                    new BudgetItem
                    {
                        UserId = 1,
                        CategoryId = 7,
                        Name = "Health Insurance",
                        Price = 150,
                    },
                    new BudgetItem
                    {
                        UserId = 1,
                        CategoryId = 7,
                        Name = "Car Insurance",
                        Price = 60,
                    },
                    new BudgetItem
                    {
                        UserId = 1,
                        CategoryId = 8,
                        Name = "NSS Loan",
                        Price = 600,
                    },
                    new BudgetItem
                    {
                        UserId = 1,
                        CategoryId = 9,
                        Name = "Netflix",
                        Price = 15,
                    },
                    new BudgetItem
                    {
                        UserId = 1,
                        CategoryId = 9,
                        Name = "Books",
                        Price = 25,
                    },
                    new BudgetItem
                    {
                        UserId = 1,
                        CategoryId = 10,
                        Name = "Film",
                        Price = 15,
                    },
                    new BudgetItem
                    {
                        UserId = 1,
                        CategoryId = 11,
                        Name = "Electricity",
                        Price = 50,
                    },
                    new BudgetItem
                    {
                        UserId = 1,
                        CategoryId = 11,
                        Name = "Water",
                        Price = 30,
                    },
                    new BudgetItem
                    {
                        UserId = 1,
                        CategoryId = 11,
                        Name = "Internet",
                        Price = 60,
                    },
                    new BudgetItem
                    {
                        UserId = 1,
                        CategoryId = 11,
                        Name = "Phone",
                        Price = 60,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}