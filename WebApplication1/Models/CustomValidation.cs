using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CustomValidationAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var AddressValidation = (string)value;
            if (AddressValidation == "cairo" || AddressValidation == "alex" || AddressValidation == "monfia")
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Address must have one of: cairo or alex or monfia");
        }
    }
}
