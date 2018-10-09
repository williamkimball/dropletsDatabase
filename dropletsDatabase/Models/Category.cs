using System.ComponentModel.DataAnnotations;

namespace dropletsDatabase.Models
{
    public class Category
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
    }
}