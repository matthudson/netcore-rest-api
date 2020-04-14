using System;
using System.ComponentModel.DataAnnotations;
using NetCoreRestApi.Auth.DataAnnotations;

namespace NetCoreRestApi.Auth.Dtos
{
    public class CustomerRegistrationDto
    {
        // Required, 3-50
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Forename { get; set; }

        // Required, 3-50
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Surname { get; set; }

        // Optional; Validate 4+[alphanum]@2+[alphanum].co(m/.uk)
        [RegularExpression("^[a-zA-Z0-9]{4,}@[a-zA-Z0-9]{2,}\\.co(m|\\.uk)$")]
        public string Email { get; set; }

        // Optional; Validate >= 18yrs
        [DateMustBe18YearsOld]
        public DateTime? DateOfBirth { get; set; }
    }
}