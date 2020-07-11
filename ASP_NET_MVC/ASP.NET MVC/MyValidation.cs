using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_MVC
{
    public class MyValidation: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string message = value.ToString();
                if (message.Contains("Haider"))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Field must contain Haider");
        }
       
    }
}