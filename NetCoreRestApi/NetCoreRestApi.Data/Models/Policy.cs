using System;

namespace NetCoreRestApi.Data.Models
{
    public class Policy
    {
        public int PolicyId { get; set; }

        public int CustomerId { get; set; }

        public string ReferenceNumber { get; set; }

        public DateTime Created { get; set; }

        public Customer Customer { get; set; }
    }
}