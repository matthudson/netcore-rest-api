using System;
using System.ComponentModel.DataAnnotations;

namespace NetCoreRestApi.Data.Models
{
    public class Customer
    {
        // TODO: RANDOM
        [Key]
        public int CustomerId { get; set; }

        public string Forename { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Deleted { get; set; }
    }
}