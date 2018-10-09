using System.ComponentModel.DataAnnotations;

namespace DropletsDB.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public User User { get; set; }

    }
}