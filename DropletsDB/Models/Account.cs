using System.ComponentModel.DataAnnotations;

namespace DropletsDB.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        public int UserId { get; set; }

        public string Access_Token { get; set; }

        public string ItemIdentificationNumber { get; set; }

        //public virtual User User { get; set; }
    }
}