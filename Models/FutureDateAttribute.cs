using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DojoSurveyWithValidations.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime)
            {
                DateTime date = (DateTime)value;
                if (date < DateTime.Now)
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Date must be a past date!");
        }
    }
}