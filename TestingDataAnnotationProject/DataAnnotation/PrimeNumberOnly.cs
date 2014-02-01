using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestingDataAnnotationProject.DataAnnotation
{
    public class PrimeNumberOnly : ValidationAttribute, IClientValidatable
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                int valueInteger;
                if (int.TryParse(value.ToString(), out valueInteger))
                {
                    if (IsPrime(valueInteger))
                    {
                        return ValidationResult.Success;
                    }
                    else
                    {
                        return new ValidationResult(string.Concat(validationContext.DisplayName, " is not a prime number"));
                    }
                }
                else
                {
                    return new ValidationResult(string.Concat(validationContext.DisplayName, " must be an integer"));
                }
            }
            return ValidationResult.Success;
        }

        private bool IsPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var rule = new ModelClientValidationRule {
                ValidationType = "primenumber",
                ErrorMessage = FormatErrorMessage(metadata.GetDisplayName()),
               
            };

            //This is not required. For the purpose of showing how to pass information to the Javascript I will set two values.
            rule.ValidationParameters.Add("primenumberparam1", "Value1");
            rule.ValidationParameters.Add("primenumberparam2", "Value2");

            yield return rule;
        }
    }
}