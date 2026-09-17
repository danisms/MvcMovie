using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Attributes
{
    public class YearRangeFrom1900ToCurrentYearAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            if (value is int year)
            {
                int currentYear = DateTime.Now.Year;
                if (year < 1900 || year > currentYear)
                {
                    return new ValidationResult($"Please enter a valid year between 1900 and {currentYear}.");
                }
            }
            return ValidationResult.Success;
        }
    }
}