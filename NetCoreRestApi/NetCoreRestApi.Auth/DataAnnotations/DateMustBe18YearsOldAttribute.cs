using System;
using System.ComponentModel.DataAnnotations;

namespace NetCoreRestApi.Auth.DataAnnotations
{
    public class DateMustBe18YearsOldAttribute : RangeAttribute
    {
        public DateMustBe18YearsOldAttribute()
            : base(typeof(DateTime), DateTime.Now.AddYears(-18).ToShortDateString(), DateTime.Now.AddYears(120).ToShortDateString()) { }
    }
}