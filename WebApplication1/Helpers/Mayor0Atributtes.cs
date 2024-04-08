using Microsoft.AspNetCore.Mvc.Filters;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace WebApplication1.Helpers
{
    public class Mayor0Atributtes: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object value, ValidationContext validationContext)

        {

            if (double.Parse(value.ToString()) > 0 || string.IsNullOrEmpty(value.ToString()))
            {

                return ValidationResult.Success;

            }
            return new ValidationResult("El número debe ser mayor a 0!");

        }

    }
}
