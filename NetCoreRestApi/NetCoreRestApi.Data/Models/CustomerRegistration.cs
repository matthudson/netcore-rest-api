using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreRestApi.Data.Models
{
    public class CustomerRegistration
    {
        [Key]
        public int CustomerRegistrationId { get; set; }

        public int? CustomerId { get; set; }

        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        
        public DateTime? DateOfBirth { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; set; }
    }
}
