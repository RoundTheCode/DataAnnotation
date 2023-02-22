using System.ComponentModel.DataAnnotations;

namespace RoundTheCode.DA.DataAnnotations
{
    public class CustomerDateOfBirthValidation : ValidationAttribute
    {
        public const string MINIMUM_DATE_OF_BIRTH = "The customer is younger than 18 years old";

        /// <summary>
        /// Minimum age 
        /// </summary>
        private int minAge = 18;

        /// <summary>
        /// Whether the date of birth is valid.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var valueString = value != null ? value.ToString() : null;

            if (string.IsNullOrWhiteSpace(valueString))
            {
                // No value, so return success.
                return ValidationResult.Success;
            }

            // Convert to date time.
            if (!DateTime.TryParse(valueString, out DateTime dob))
            {
                // Not a valid date, so return error.
                return new ValidationResult("Unable to convert the date of birth to a valid date");
            }

            // Minimum date of birth
            var minDateOfBirth = DateTime.Now.Date.AddYears(minAge * -1);

            if (dob > minDateOfBirth)
            {
                // Under minimum date of birth, so return error.
                return new ValidationResult(MINIMUM_DATE_OF_BIRTH);
            }

            // Return success
            return ValidationResult.Success;
        }
    }
}
