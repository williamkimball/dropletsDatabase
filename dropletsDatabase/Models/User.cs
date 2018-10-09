using System.ComponentModel.DataAnnotations;

namespace dropletsDatabase.Models
{
    public class BudgetItem
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}