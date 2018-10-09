using System.ComponentModel.DataAnnotations;

namespace dropletsDatabase.Models
{
    public class Account
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        public long Access_Token { get; set; }
        public long ItemId { get; set; }
    }
}