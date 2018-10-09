using System.ComponentModel.DataAnnotations;

namespace dropletsDatabase.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; }
    }
}