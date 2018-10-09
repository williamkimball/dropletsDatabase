using System.ComponentModel.DataAnnotations;

namespace DropletsDB.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        public int UserId { get; set; }

        public long Access_Token { get; set; }

        public long ItemIdentificationNumber { get; set; }

        public User User { get; set; }
    }
}