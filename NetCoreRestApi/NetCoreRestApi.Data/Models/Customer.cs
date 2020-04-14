using System;
using System.Collections.Generic;

namespace NetCoreRestApi.Data.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public int OnlineReference { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public DateTime Created { get; set; }

        public CustomerRegistration CustomerRegistration { get; set; }
        public ICollection<Policy> Policies { get; set; }
    }
}