using System;
using System.ComponentModel.DataAnnotations;

namespace DropletsDB.Models
{
    public class SavingsBucket
    {
        [Key]
        public int SavingsBucketId { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public double currentTotal { get; set; }

        public double goalTotal { get; set; }
   
        public DateTime lastLogin { get; set; }
    }
}
