using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DropletsDB.Models
{
    public class BudgetItem
    {
        [Key]
        public int BudgetItemId { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double Current { get; set; }

    }
}