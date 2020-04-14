using System;
using System.ComponentModel.DataAnnotations;

namespace NetCoreRestApi.Data.Models
{
    public class Policy
    {
        [Key]
        public int PolicyId { get; set; }

        public int CustomerId { get; set; }

        public string ReferenceNumber { get; set; }

        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Deleted { get; set; }
    }
}