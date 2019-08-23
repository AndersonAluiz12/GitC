using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoWEBApi.Models
{
    public class CustomNameValidator : ValidationAttribute
    {
            protected override ValidationResult IsValid (Object value,
                ValidationContext validationContext)
            {
                if(value != null)
                {
                    if(value.ToString().Contains("Anderson"))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Novo Teste");
                }
                }

                return new ValidationResult("O Campo: " +
                    validationContext.DisplayName
                    + " é um campo obrigatório");
            }
    }
}