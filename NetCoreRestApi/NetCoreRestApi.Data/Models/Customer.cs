using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreRestApi.Data.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        // TODO: RANDOM
        public int OnlineReference { get; set; }

        public string Forename { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public DateTime? DateOfBirth { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Modified { get; set; }
        public DateTime? Deleted { get; set; }
    }
}