using RoundTheCode.DA.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace RoundTheCode.DA.Models
{
    public class CustomerModel
    {
        [Required, MinLength(3), MaxLength(30)]
        public string? FirstName { get; init; }

        [Required, MinLength(3), MaxLength(50)]
        public string? Surname { get; init; }

        [EmailAddress]
        public string? Email { get; init; }

        [RegularExpression("^([0-9]{5})$")]
        public string? ZipCode { get; init; }

        [DataType(DataType.Date), Required, CustomerDateOfBirthValidation]
        public DateTime DateOfBirth { get; init; }
    }
}
