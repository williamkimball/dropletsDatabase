using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DropletsDB.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string FirstName { get; set; }

        //public virtual ICollection<Account> Accounts { get; set; }

        //public virtual ICollection<Category> Category { get; set; }
    }
}