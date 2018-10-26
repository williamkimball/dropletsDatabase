using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DropletsDB.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string IdString { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }

        public virtual ICollection<BudgetItem> BudgetItems { get; set; }

        public virtual ICollection<SavingsBucket> SavingsBuckets { get; set; }
    }
}