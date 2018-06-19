using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || 
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
            var month = DateTime.Today.Month - customer.Birthdate.Value.Month;
            if (month < 0 || (month == 0 && (DateTime.Today < customer.Birthdate.Value)))
            {
                age--;
            }

            return (age > 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be at least 18 years old to go on an membership.");

        }
    }
}