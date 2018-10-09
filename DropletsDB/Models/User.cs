using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DropletsDB.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}