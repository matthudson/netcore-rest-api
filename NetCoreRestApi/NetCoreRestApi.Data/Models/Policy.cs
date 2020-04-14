using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreRestApi.Data.Models
{
    public class Policy
    {
        [Key]
        public int PolicyId { get; set; }

        public int CustomerId { get; set; }

        public string ReferenceNumber { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Modified { get; set; }
        public DateTime? Deleted { get; set; }
    }
}